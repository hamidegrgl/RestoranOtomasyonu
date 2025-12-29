using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon_1
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
