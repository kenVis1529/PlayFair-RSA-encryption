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

        // Kiểm tra số nguyên tố
        // TODO: Khuyến khích dùng sàng nguyên tố
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

        // Tính UCLN
        int CalculateGreatestCommonDivisor(int a, int b)
        {
            int t;
            if (b < a)
            {
                t = b;
                b = a;
                a = t;
            }
            while (b != 0)
            {
                t = a;
                a = b;
                b = t % b;
            }
            return a;
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


        // Kiểm tra q, p, e, input hợp lệ
        int validateInput(bool isEncrypt)
        {
            string mess = "";
            bool isPNumeric = int.TryParse(tb_p.Text, out int a);
            bool isQNumeric = int.TryParse(tb_q.Text, out int b);
            bool isENumeric = int.TryParse(tb_e.Text, out int c);
            string d = tb_input.Text;

            if (!isPNumeric || a == 0 || !IsPrime(a)) { mess += "Invalid prime number p!" + Environment.NewLine; }
            if (!isQNumeric || b == 0 || !IsPrime(b)) { mess += "Invalid prime number q!" + Environment.NewLine; }
            int phiN = CalculatePhiN(a, b);
            if (!isENumeric || c >= phiN || !IsRelativelyPrime(phiN, c)) { mess += "Invalid public key e!" + Environment.NewLine; }
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


        private void UserControlRsa_Load(object sender, EventArgs e)
        {

        }

        private void btn_gen_prime_numbers_Click(object sender, EventArgs e)
        {

        }
    }
}
