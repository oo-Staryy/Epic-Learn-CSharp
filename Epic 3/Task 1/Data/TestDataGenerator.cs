using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;

namespace Task_1.Data
{
    public static class TestDataGenerator
    {
        public static List<User> GetUsers()
        {
            List<User> result = new(1000000);

            for (int i = 0; i < result.Capacity; i++)
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid(),
                };

                result.Add(newUser);
            }

            return result;
        }
    }
}
