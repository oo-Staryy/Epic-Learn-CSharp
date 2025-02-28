using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Data;
using Task_1.Entities;

namespace Task_1.Services
{
    public class UserUpdateService
    {
        private List<User> UsersList { get; set; }
        public void UpdateUsers()
        {
            UsersList = TestDataGenerator.GetUsers();

            // TODO
            UpdateTokens(UsersList);
            GenerateSecurityKeys(UsersList);
        }

        private void GenerateSecurityKeys(List<User> users)
        {
            for (int i = 0; i < users.Count; i++) 
            {
                SecurityKeyGenHandler.Gen(users[i]);
                TokenUpdateHandler.Update(users[i]);
            }
        }
        private void UpdateTokens(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                TokenUpdateHandler.Update(users[i]);
            }
        }
    }
}
