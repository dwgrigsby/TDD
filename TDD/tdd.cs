using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class tdd : Form
    {
        public tdd()
        {
            InitializeComponent();
        }


        public void CallDSAPI_Click(object sender, EventArgs e)
        {
            dsParameters parameters = new dsParameters();
            dsResponse responseFromServer = new dsResponse();
            DSServiceBroker dsServiceBroker = new DSServiceBroker();

            parameters.dsmethodURI = TbLoginURI.Text;
            parameters.restEndpoint = TbURI.Text;
            parameters.userName = TbUserName.Text;
            parameters.password = TbPassword.Text;
            parameters.integratorKey = TbIntKey.Text;

            responseFromServer = dsServiceBroker.CallDSAPI(parameters);

            if(responseFromServer.responseOK)
            {
                TbResults.Text = responseFromServer.response;
            }
            else
            {
                TbResults.Text = responseFromServer.responseError + "\n" + responseFromServer.responseErrorResponse;
            }
            


        }
    }
}
