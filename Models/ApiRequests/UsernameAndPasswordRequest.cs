using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.ApiRequests
{
    class UsernameAndPasswordRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UsernameAndPasswordRequest(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
