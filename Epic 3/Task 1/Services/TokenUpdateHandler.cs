using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;

namespace Task_1.Services
{
    public static class TokenUpdateHandler
    {
        public static void Update(User user)
        {
            if (user.Token is not null && user.TokenGenCount <= user.Token.LastTokenGenCount)
                throw new Exception("Updating collision");

            var temp = user.Id.ToString() + user.SecurityKey;

            user.Token = new()
            {
                LastTokenGenCount = user.TokenGenCount,
                Mark = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(temp)))
            };
            user.TokenGenCount++;
        }
    }
}
