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
        /*   static int RemoveSpace(ref char[] plain,ref int ps)
           {
               char[] result = new char[ps];
               int count = 0;

               for (int i = 0; i < ps; i++)
               {
                   if (plain[i] != ' ')
                       result[count++] = plain[i];
               }

               result.CopyTo(plain, 0);
               ps = count-1;
               return count;
           }*/
        static int RemoveSpace(ref char[] plain, ref int ps)
        {

            List<char> newList = new List<char>();
            for (int i = 0; i < ps; i++)
            {
                if (plain[i] != ' ')
                {
                    newList.Add(plain[i]);
                }
            }

            plain = newList.ToArray();

            ps = plain.Length;
            return ps;
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

        static char[] AddCharacterToEnd(ref char[] str, char newCharacter)
        {
            // Create a new array with increased length
            char[] newArray = new char[str.Length + 1];

            // Copy the elements from the original array to the new array
            Array.Copy(str, newArray, str.Length);

            // Add the new character at the end of the new array
            newArray[newArray.Length - 1] = newCharacter;

            return newArray;
        }

        static int Prepare(ref char[] str, ref int ptrs)
        {
            List<char> newList = new List<char>();
            for (int i = 0; i < ptrs - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    newList.Add(str[i]);
                }
                else
                {
                    newList.Add(str[i]);
                    newList.Add('x');
                }
            }

            newList.Add(str[ptrs - 1]);

            str = newList.ToArray();
            ptrs = str.Length;


            if (ptrs % 2 != 0)
            {
                str = AddCharacterToEnd(ref str, 'x');
                ptrs++;
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

        static void Encrypt(ref char[] str, char[,] keyT, int ps)
          {
              int[] a = new int[4];

              for (int i = 0; i<ps-1; i += 2)
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

        static void Decrypt(ref char[] str, char[,] keyT, int ps)
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
            ks = RemoveSpace(ref key,ref ks);
            ToLowerCase(key, ks);

            //PlainText
            ps = str.Length;
            ps = RemoveSpace(ref str, ref ps);
            ToLowerCase(str, ps);

            ps = Prepare(ref str,ref ps);

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

            Encrypt(ref str, keyT, ps);

            for (int i = 0; i < ps; i++)
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
            char[,] keyT = new char[5,5];

            if (str.Length % 2 == 1)
            {
                MessageBox.Show("The ciphertext always have even number of characters");
            }    
            else
            {
                //Key
                ks = key.Length;
                ks = RemoveSpace(ref key,ref ks);
                ToLowerCase(key, ks);

                //PlainText
                ps = str.Length;
                ps = RemoveSpace(ref str,ref ps);
                ToLowerCase(str, ps);

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

                Decrypt(ref str, keyT, ps);

                for (int i = 0; i < ps; i++)
                {
                    rtbEncrypted.AppendText(str[i].ToString());
                    if ((i + 1) % 2 == 0 && i != str.Length - 1)
                        rtbEncrypted.AppendText(" ");
                }
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
