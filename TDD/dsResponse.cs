using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class dsResponse
    {
        public string response { get; set; }
        public bool responseOK { get; set; }
        public string responseError { get; set; }
        public string responseErrorResponse { get; set; }
        public string responseCode { get; set; }
    }
}
