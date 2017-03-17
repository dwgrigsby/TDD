using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;


namespace TDDUnitTest
{
    [TestClass]
    public class TDD
    {
        [TestMethod]
        public void FinalRequirement()
        {

            tdd _tddform = new tdd();
            object sender = new object();
            EventArgs e = new EventArgs();
            _tddform.CallDSAPI_Click(sender, e);

            TextBox _tbresults = new TextBox();
            Control[] _controls = _tddform.Controls.Find("tbResults",true);

            if(_controls.Length>0)
            {
                _tbresults = (TextBox) _controls[0];
            }

            string expectedResult = "{\r\n  \"loginAccounts\": [\r\n    {\r\n      \"name\": \"eLawDocs\",\r\n      \"accountId\": \"26096\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/26096\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"DocuSign for GApps Trial for grigsbyconsultingllc.com\",\r\n      \"accountId\": \"79642\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/79642\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"GCLLC - TDD\",\r\n      \"accountId\": \"2773666\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/2773666\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"GE Global Operations HR\",\r\n      \"accountId\": \"1559756\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/1559756\",\r\n      \"isDefault\": \"true\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    }\r\n  ],\r\n  \"apiPassword\": \"P1ffoIdNbatKf537ghKlB1At98o=\"\r\n}";

            Assert.AreEqual(expectedResult, _tbresults.Text);

        }
        [TestMethod]
        public void UtilityXDSAuthHeaderValueTest()
        {
            const string expectedResult = "{\"Username\":\"1\",\"Password\":\"2\",\"IntegratorKey\":\"3\"}";
            Assert.AreEqual(DSUtilities.XDSAuthHeaderValue("1", "2", "3"), expectedResult);
        }
    }
}
