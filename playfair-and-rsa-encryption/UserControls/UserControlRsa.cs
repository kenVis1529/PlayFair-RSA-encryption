using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playfair_and_rsa_encryption.UserControls
{
    public partial class UserControlRsa : UserControl
    {
        string charsList = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+-*/=_?.,#";
        List<int> primeList = GeneratePrimesUpTo(100);


        public UserControlRsa()
        {
            InitializeComponent();
        }

        // Điền thêm chữ số 0 phía trước số 
        string FillLeadingZeros(int x)
        {
            string result;
            if (x < 10)
                result = "00" + x.ToString();
            else if (x < 100)
                result = "0" + x.ToString();
            else
                result = x.ToString();
            return result;
        }

        // Lấy mã vị trí của ký tự
        string GetIndexOfChar(char x)
        {

            string result;
            int index;
            index = charsList.IndexOf(x);
            result = FillLeadingZeros(index);
            return result;
        }

        // Lấy ký tự từ mã số vị trí
        char GetCharFromIndex(int index)
        {
            char result;
            result = this.charsList[index];
            return result;
        }

        // Tạo danh sách số nguyên tố từ 1 đến n
        static List<int> GeneratePrimesUpTo(int n)
        {
            if (n <= 1)
            {
                return new List<int>();
            }

            List<bool> isPrime = new List<bool>(n + 1) { true };
            for (int i = 0; i <= n; i++)
            {
                isPrime.Add(true);
            }

            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // Lấy ngẫu nhiên 1 số từ danh sách
        int GetRandom(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            var random = new Random();
            int index = random.Next(0, list.Count);

            return list[index];
        }

        // Kiểm tra số nguyên tố
        bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        // Kiểm tra số nguyên tố bằng thuật toán Miller-Rabin
        bool IsPrime2(int number)
        {
            return false;
        }

        // Tính UCLN
        int CalculateGreatestCommonDivisor(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            return CalculateGreatestCommonDivisor(b % a, a);
        }

        // Kiểm tra 2 số là số nguyên tố cùng nhau
        bool IsRelativelyPrime(int a, int b)
        {
            return CalculateGreatestCommonDivisor(a, b) == 1;
        }

        // Kiểm tra input để giải mã có hợp lệ không
        bool IsValidDecryptInput(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length; i++)
            {
                bool isNumeric = int.TryParse(input[i].ToString(), out int _);
                bool isHashSign = input[i] == '#';
                if (!isNumeric && !isHashSign) return false;
            }
            return result;
        }

        // Tính phi(N) = (p-1)*(q-1)
        int CalculatePhiN(int p, int q)
        {
            return (p - 1) * (q - 1);
        }

        bool ValidatePrimeNumP(bool isPNumeric, int p)
        {
            if (!isPNumeric || p == 0 || !IsPrime(p)) return false;
            return true;
        }

        bool ValidatePrimeNumQ(bool isQNumeric, int q)
        {
            if (!isQNumeric || q == 0 || !IsPrime(q)) return false;
            return true;
        }

        bool ValidatePublicKeyE(bool isENumeric, int e, int phiN)
        {
            if (!isENumeric || e >= phiN || !IsRelativelyPrime(phiN, e)) return false;
            return true;
        }

        // Kiểm tra q, p, e, input hợp lệ
        int ValidateInput(bool isEncrypt)
        {
            string mess = "";
            bool isPNumeric = int.TryParse(tb_p.Text, out int a);
            bool isQNumeric = int.TryParse(tb_q.Text, out int b);
            bool isENumeric = int.TryParse(tb_e.Text, out int c);
            int phiN = CalculatePhiN(a, b);
            string d = tb_input.Text;

            if (ValidatePrimeNumP(isPNumeric, a)) { mess += "Invalid prime number p!" + Environment.NewLine; }
            if (ValidatePrimeNumQ(isQNumeric, b)) { mess += "Invalid prime number q!" + Environment.NewLine; }
            if (ValidatePublicKeyE(isENumeric, c, phiN)) { mess += "Invalid public key e!" + Environment.NewLine; }
            if (!isEncrypt && !IsValidDecryptInput(d)) { mess += "Invalid input for decryption!" + Environment.NewLine; }

            if (mess != "")
            {
                MessageBox.Show(mess);
                return 0;
            }
            else
            {
                return 1;
            }
        }

        // Tính RSA Modulus N = p*q
        int CalculateModulusN(int p, int q)
        {
            return p * q;
        }

        // Tính private key d
        int CalculatePrivateKeyD(int e, int phiN)
        {
            for (int X = 1; X < phiN; X++)
                if (((e % phiN) * (X % phiN)) % phiN == 1)
                    return X;
            return 1;
        }

        // Chuyển input thành chuỗi các cặp chữ số (encrypt)
        List<string> ParseEncryptInputToIndexList(string input)
        {
            List<string> result = new List<string> { };

            // Tạo thành mảng 2 chữ số của mỗi kí tự
            for (int i = 0; i < input.Length; i++)
            {
                result.Add(GetIndexOfChar(input[i]));
            }
            return result;
        }

        // Tách input thành các nhóm chữ số (decrypt)
        List<string> BreakDecryptInputToIndexList(string input)
        {
            List<string> result = input.Split('#').ToList<string>();
            return result;
        }

        // Mã hóa bảo mật
        string EncryptForConfidentiality(int e, int n, string input)
        {
            string result = "";
            int val = int.Parse(input);
            int encryptedVal = (int)BigInteger.ModPow(val, e, n);
            // Debug.WriteLine("Big number: " + BigInteger.ModPow(val, e, phin));
            result = FillLeadingZeros(encryptedVal);
            return result;
        }

        // Mã hóa chứng thực
        string EncryptForAuthentication(int d, int n, string input)
        {
            string result = "";
            int val = int.Parse(input);
            int encryptedVal = (int)BigInteger.ModPow(val, d, n);
            result = FillLeadingZeros(encryptedVal);
            return result;
        }

        // Giải mã bảo mật
        string DecryptForConfidentiality(int d, int n, string input)
        {
            return EncryptForAuthentication(d, n, input);
        }

        // Giải mã chứng thực
        string DecryptForAuthentication(int e, int n, string input)
        {
            return EncryptForConfidentiality(e, n, input);
        }


        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string input = tb_input.Text;
            string output = "";
            int p = 1, q = 1, eKey = 1, n = 1, dKey = 1, phiN = 1;

            int status = ValidateInput(true);
            if (status == 0)
                return;
            else
            {
                p = int.Parse(tb_p.Text);
                q = int.Parse(tb_q.Text);
                eKey = int.Parse(tb_e.Text);
            }

            n = CalculateModulusN(p, q);
            phiN = CalculatePhiN(p, q);
            dKey = CalculatePrivateKeyD(eKey, phiN);
            tb_n.Text = n.ToString();
            tb_phi.Text = phiN.ToString();
            tb_d.Text = dKey.ToString();

            if (input == "") return;

            List<string> twoDigitList = ParseEncryptInputToIndexList(input);

            List<string> confidentialityEncryptCode = new List<string>(twoDigitList.Count);
            for (int i = 0; i < twoDigitList.Count; i++)
            {
                string temp = EncryptForConfidentiality(eKey, n, twoDigitList[i]);
                confidentialityEncryptCode.Add(temp);
            }

            List<string> authenticationEncryptCode = new List<string>(twoDigitList.Count);
            for (int i = 0; i < confidentialityEncryptCode.Count; i++)
            {
                string temp = EncryptForAuthentication(dKey, n, confidentialityEncryptCode[i]);
                authenticationEncryptCode.Add(temp);
            }

            output = String.Join("#", authenticationEncryptCode);
            tb_output.Text = output;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string input = tb_input.Text;
            string output = "";
            int p = 1, q = 1, eKey = 1, n = 1, dKey = 1, phiN = 1;

            // TODO: Làm sao để tính N, phiN, E và D ngay khi q và p hợp lệ

            int status = ValidateInput(false);

            if (status == 0)
                return;
            else
            {
                p = int.Parse(tb_p.Text);
                q = int.Parse(tb_q.Text);
                eKey = int.Parse(tb_e.Text);
            }

            n = CalculateModulusN(p, q);
            phiN = CalculatePhiN(p, q);
            dKey = CalculatePrivateKeyD(eKey, phiN);
            tb_n.Text = n.ToString();
            tb_phi.Text = phiN.ToString();
            tb_d.Text = dKey.ToString();

            if (input == "") return;

            List<string> chunkList = BreakDecryptInputToIndexList(input);

            List<string> authenticationDecryptCode = new List<string>(chunkList.Count);
            for (int i = 0; i < chunkList.Count; i++)
            {
                string temp = DecryptForAuthentication(eKey, n, chunkList[i]);
                authenticationDecryptCode.Add(temp);
            }

            List<string> confidentialityDecryptCode = new List<string>(chunkList.Count);
            for (int i = 0; i < authenticationDecryptCode.Count; i++)
            {
                string temp = DecryptForConfidentiality(dKey, n, authenticationDecryptCode[i]);
                confidentialityDecryptCode.Add(temp);
            }

            output = String.Join("", confidentialityDecryptCode.Select<string, char>(x => GetCharFromIndex(int.Parse(x))));
            tb_output.Text = output;
        }
        private void btn_gen_prime_numbers_Click(object sender, EventArgs e)
        {
            // Random 2 số nguyên tố khác nhau

            int p = GetRandom(primeList);
            int q = GetRandom(primeList);

            while (p == q)
            {
                q = GetRandom(primeList);
            }

            tb_p.Text = p.ToString();
            tb_q.Text = q.ToString();
        }

        private void tb_p_TextChanged(object sender, EventArgs e)
        {
            if (tb_p.Text != "" && tb_q.Text != "")
            {
                tb_n.Text = CalculateModulusN(int.Parse(tb_p.Text), int.Parse(tb_q.Text)).ToString();
                tb_phi.Text = CalculatePhiN(int.Parse(tb_p.Text), int.Parse(tb_q.Text)).ToString();
            }
            else
            {
                tb_n.Text = "";
                tb_phi.Text = "";
            }
        }
    }
}
