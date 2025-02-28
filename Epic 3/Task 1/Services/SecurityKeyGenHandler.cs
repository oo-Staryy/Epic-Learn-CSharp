using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;

namespace Task_1.Services
{
    public static class SecurityKeyGenHandler
    {
        public static void Gen (User user)
        {
            user.SecurityKey = Convert.ToBase64String(SHA1.HashData(user.Id.ToByteArray()));
        }
    }
}
