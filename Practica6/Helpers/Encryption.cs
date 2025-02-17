using System;
using System.Security.Cryptography;
using System.Text;

namespace Practica6.Helpers
{
    public class Encryption
    {
        // Método para comparar arrays de bytes de manera segura
        public static bool CompareArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            uint diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }

        // Genera un salt criptográficamente seguro
        public static byte[] GenerateSalt(int length = 32)
        {
            byte[] saltBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return saltBytes;  // El salt debe ser un byte[] y no un string Base64
        }

        // Método para encriptar la contraseña utilizando PBKDF2
        public static byte[] EncryptPassword(string password, byte[] salt)
        {
            // Convertir la contraseña a bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Usar PBKDF2 con SHA-512
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordBytes, salt, 100000, HashAlgorithmName.SHA512))
            {
                return pbkdf2.GetBytes(64); // Devolver el hash de 64 bytes
            }
        }
    }
}