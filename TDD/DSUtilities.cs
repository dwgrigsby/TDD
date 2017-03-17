using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class DSUtilities
    {
        public static string XDSAuthHeaderValue(string username, string password, string integratorkey)
        {
            const string xdsAuthHeaderValue = "{\"Username\":\"[USER]\",\"Password\":\"[PASS]\",\"IntegratorKey\":\"[INTKEY]\"}";
            StringBuilder sbxdsAHv = new StringBuilder(xdsAuthHeaderValue);
            sbxdsAHv.Replace("[USER]", username);
            sbxdsAHv.Replace("[PASS]", password);
            sbxdsAHv.Replace("[INTKEY]", integratorkey);

            return sbxdsAHv.ToString();
        }
    }
}
