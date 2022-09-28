using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public static User CurrentUser { get; set; }
    }
}
