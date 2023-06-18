using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Authentication
{
    internal interface IPasswordHasher
    {
        string CreateHashPassword(string password);
        string GetPasswordFromHash(string hash, string enteredPassword);

    }
}
