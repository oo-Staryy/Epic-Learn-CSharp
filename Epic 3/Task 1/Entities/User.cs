using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string SecurityKey { get; set; }
        public int TokenGenCount { get; set; }
        public UserToken? Token { get; set; }    
    }
}
