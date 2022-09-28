using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.ApiRequests
{
    class TokenAuthRequest
    {
        public string Token { get; set; }

        public TokenAuthRequest(string token)
        {
            this.Token = token;
        }
    }
}
