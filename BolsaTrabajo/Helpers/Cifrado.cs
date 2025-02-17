using System.Security.Cryptography;
using System.Text;

namespace BolsaTrabajo.Helpers
{
    public class Cifrado
    {
        public static bool CompareArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals(b[i])) return false;
            }
            return true;
        }

        public static string GenerateSalt()
        {
            Random random = new Random();
            string salt = "";
            for (int i = 0; i < 50; i++)
            {
                int rand = random.Next(0, 255);
                char x = Convert.ToChar(rand);
                salt += x;
            }
            return salt;
        }

        public static byte[] EncryptPassword(string password,string salt)
        {
            string content = password + salt;
            SHA512 sHA512 = SHA512.Create();
            byte[] output = Encoding.UTF8.GetBytes(content);
            for (int i = 0; i < 107; i++)
            {
                output = sHA512.ComputeHash(output);
            }
            sHA512.Clear();
            return output;
        }
    }
}
