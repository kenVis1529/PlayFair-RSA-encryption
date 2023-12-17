using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playfair_and_rsa_encryption.UserControls
{
    public partial class UserControlPlayfair : UserControl
    {
        public UserControlPlayfair()
        {
            InitializeComponent();
        }
        const int SIZE = 30;

        //Convert the plain text to lowercase
        static void ToLowerCase(char[] plain, int ps)
        {
            for (int i = 0; i < ps; i++)
            {
                if (plain[i] > 64 && plain[i] < 91)
                    plain[i] += (char)32;
            }
        }

        //Remove all spaces in a string
        static int RemoveSpace(ref char[] plain, int ps)
        {
            char[] result = new char[ps];
            int count = 0;

            for (int i = 0; i < ps; i++)
            {
                if (plain[i] != ' ')
                    result[count++] = plain[i];
            }

            result.CopyTo(plain, 0);
            return count;
        }
        //Generate the key square
        static void generateKeyTable(char[] key, int ks, char[,] keyT)
        {
            int i, j, k, flag = 0;
            int[] dicty = new int[26];

            for (i = 0; i < ks; i++)
            {
                if (key[i] != 'j')
                    dicty[key[i] - 97] = 2;
            }

            dicty['j' - 97] = 1;

            i = 0;
            j = 0;

            for (k = 0; k < ks; k++)
            {
                if (dicty[key[k] - 97] == 2)
                {
                    dicty[key[k] - 97] -= 1;
                    keyT[i, j] = key[k];
                    j++;
                    if (j == 5)
                    {
                        i++;
                        j = 0;
                    }
                }
            }

            for (k = 0; k < 26; k++)
            {
                if (dicty[k] == 0)
                {
                    keyT[i, j] = (char)(k + 97);
                    j++;
                    if (j == 5)
                    {
                        i++;
                        j = 0;
                    }
                }
            }
        }

        //Search for the characters of a digraph
        //in the key square and return their position
        static void Search(char[,] keyT, char a, char b, int[] arr)
        {
            int i, j;

            if (a == 'j')
                a = 'i';
            else if (b == 'j')
                b = 'i';

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (keyT[i, j] == a)
                    {
                        arr[0] = i;
                        arr[1] = j;
                    }
                    else if (keyT[i, j] == b)
                    {
                        arr[2] = i;
                        arr[3] = j;
                    }
                }
            }
        }

        //Find the modulis with number
        static int Mod5(int a)
        {
            return (a % 5);
        }

        static int Mod5v2(int a)
        {
            if (a < 0)
                a += 5;
            return (a % 5);
        }

        //Make the plain text length to be even
        static int Prepare(char[] str, int ptrs)
        {
            if (ptrs % 2 != 0)
            {
                str[ptrs++] = 'x';
            }
            return ptrs;
        }

        private int CheckForNumbersOrSpecialCharacters(string input)
        {
            if (input.Any(char.IsDigit) || input.Any(c => !char.IsLetterOrDigit(c)))
            {
                return 1; // Chuỗi chứa số hoặc kí tự đặc biệt.
            }
            else
            {
                return 0; // Chuỗi không chứa số hoặc kí tự đặc biệt.
            }
        }

        static void Encrypt(char[] str, char[,] keyT, int ps)
        {
            int[] a = new int[4];

            for (int i = 0; i < ps; i += 2)
            {
                Search(keyT, str[i], str[i + 1], a);

                if (a[0] == a[2])
                {
                    str[i] = keyT[a[0], Mod5(a[1] + 1)];
                    str[i + 1] = keyT[a[0], Mod5(a[3] + 1)];
                }
                else if (a[1] == a[3])
                {
                    str[i] = keyT[Mod5(a[0] + 1), a[1]];
                    str[i + 1] = keyT[Mod5(a[2] + 1), a[1]];
                }
                else
                {
                    str[i] = keyT[a[0], a[3]];
                    str[i + 1] = keyT[a[2], a[1]];
                }

            }
        }

        static void Decrypt(char[] str, char[,] keyT, int ps)
        {
            int[] a = new int[4];
            for (int i = 0; i < ps; i += 2)
            {
                Search(keyT, str[i], str[i + 1], a);
                if (a[0] == a[2])
                {
                    str[i] = keyT[a[0], Mod5v2(a[1] - 1)];
                    str[i + 1] = keyT[a[0], Mod5v2(a[3] - 1)];
                }
                else if (a[1] == a[3])
                {
                    str[i] = keyT[Mod5v2(a[0] - 1), a[1]];
                    str[i + 1] = keyT[Mod5v2(a[2] - 1), a[1]];
                }
                else
                {
                    str[i] = keyT[a[0], a[3]];
                    str[i + 1] = keyT[a[2], a[1]];
                }
            }
        }

        private void tbKey_LostFocus(object sender, EventArgs e)
        {
            string keyValue = tbKey.Text;
            if (CheckForNumbersOrSpecialCharacters(keyValue) == 1)
                MessageBox.Show("The key contains numbers or special characters.");

        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            rtbEncrypted.Clear();
            rtbTable.Clear();
            lbEncrypted.Text = "Encrypted text";
            char[] str = rtbPlain.Text.ToCharArray();
            char[] key = tbKey.Text.ToCharArray();
            int ps, ks;
            char[,] keyT = new char[5, 5];

            //Key
            ks = key.Length;
            ks = RemoveSpace(ref key, ks);
            ToLowerCase(key, ks);

            //PlainText
            ps = str.Length;
            ps = RemoveSpace(ref str, ps);
            ToLowerCase(str, ps);

            ps = Prepare(str, ps);

            generateKeyTable(key, ks, keyT);


            //Display Key matrix
            int cellWidth = 8;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string value = keyT[i, j].ToString();
                    int padding = cellWidth - value.Length;
                    string paddedValue = value.PadLeft(value.Length + padding / 2).PadRight(cellWidth);
                    rtbTable.AppendText(paddedValue);
                }
                rtbTable.AppendText(Environment.NewLine);
            }

            Encrypt(str, keyT, ps);

            for (int i = 0; i < str.Length; i++)
            {
                rtbEncrypted.AppendText(str[i].ToString());
                if ((i + 1) % 2 == 0 && i != str.Length - 1)
                    rtbEncrypted.AppendText(" ");

            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            rtbEncrypted.Clear();
            rtbTable.Clear();
            lbEncrypted.Text = "Decrypted text";
            char[] str = rtbPlain.Text.ToCharArray();
            char[] key = tbKey.Text.ToCharArray();
            int ps, ks;
            char[,] keyT = new char[5, 5];

            //Key
            ks = key.Length;
            ks = RemoveSpace(ref key, ks);
            ToLowerCase(key, ks);

            //PlainText
            ps = str.Length;
            ps = RemoveSpace(ref str, ps);
            ToLowerCase(str, ps);

            ps = Prepare(str, ps);

            generateKeyTable(key, ks, keyT);


            //Display Key matrix
            int cellWidth = 8;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string value = keyT[i, j].ToString();
                    int padding = cellWidth - value.Length;
                    string paddedValue = value.PadLeft(value.Length + padding / 2).PadRight(cellWidth);
                    rtbTable.AppendText(paddedValue);
                }
                rtbTable.AppendText(Environment.NewLine);
            }

            Decrypt(str, keyT, ps);

            for (int i = 0; i < str.Length; i++)
            {
                rtbEncrypted.AppendText(str[i].ToString());
                if ((i + 1) % 2 == 0 && i != str.Length - 1)
                    rtbEncrypted.AppendText(" ");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbKey.Clear();
            rtbPlain.Clear();
            rtbEncrypted.Clear();
            rtbTable.Clear();
        }
    }
}
