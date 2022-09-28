using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.ApiResponses
{
    abstract class BaseResponse
    {
        public int Status { get; set; }

        public string Message { get; set; }
    }
}
