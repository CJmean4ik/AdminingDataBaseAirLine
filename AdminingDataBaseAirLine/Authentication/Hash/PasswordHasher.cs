using AirlineDataBase;
using System.Security.Cryptography;
using System.Text;

namespace AdminingDataBaseAirLine.Authentication.Hash
{
    internal class PasswordHasher : IPasswordHasher
    {

        public string CreateHashPassword(string password)
        {
            MD5 CSP = MD5.Create();
            var hash = CSP.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }

        public string GetPasswordFromHash(string hash, string enteredPassword)
        {
            var hashPassword = CreateHashPassword(enteredPassword);

            if (hash == hashPassword) return enteredPassword;

            return "none";
        }
    }
}
