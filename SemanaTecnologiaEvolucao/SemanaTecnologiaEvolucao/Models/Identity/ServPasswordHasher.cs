using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace SemanaTecnologiaEvolucao.Models.Identity
{
    public class ServPasswordHasher : IPasswordHasher
    {
        public string HashPassword(string pass)
        {
            return pass;
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            if (hashedPassword == providedPassword)
                return PasswordVerificationResult.Success;

            return PasswordVerificationResult.Failed;
        }
    }
}