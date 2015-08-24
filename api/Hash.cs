using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Util;
using System.Text.RegularExpressions;


namespace CryptoApi
{
    public class Hash
    {
        /// <summary>
        /// Tis function dont have a hashing algorithm hard coded into it you need to specify one acording to the docs;
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="input"></param>
        /// <param name="rd"></param>
        /// <returns>the hashed string</returns>
        public static string CryptoGeneric(string algorithm, string input, bool rd)
        {
            string output;
            byte[] src_prep = ASCIIEncoding.ASCII.GetBytes(input);
            byte[] hash;
            if (algorithm == null || algorithm == "" || algorithm == "Algorithm")
            {
                hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(src_prep);
            }
            else
            {
                hash = ((HashAlgorithm)CryptoConfig.CreateFromName(algorithm)).ComputeHash(src_prep);
            }

            if (rd)
            {
               return output = BitConverter.ToString(hash).Replace("-", string.Empty);
            }
            else
            {
               return output = BitConverter.ToString(hash);
            }
        }
        public static bool ValidateFileByHash(string input, string hashToTest, string algorithm)
        {
            string hash = CryptoApi.Hash.CryptoGeneric(algorithm, input, true);
            if(hash == hashToTest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
