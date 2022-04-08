using System.Security.Cryptography;
using System.Text;
using System;

namespace Biblioteca.Models
{
    public class Criptografo
    {
        
        public static string TextoCriptografado(string textoSemformatacao)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(textoSemformatacao);
            byte[] bytesCritografado = md5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in bytesCritografado)
            {
                string Debug = b.ToString("x2");
                SB.Append(Debug);
            }
            return SB.ToString();
        }
    }
}