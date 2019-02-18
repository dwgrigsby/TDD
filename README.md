# TDD
<img src="https://blog.grigsbyconsultingllc.com/wp-content/uploads/GCLLCBannerLogov1.gif" />

Background
=========

I was given a fantastic opportunity to speak to the undergraduate students at the University of North Florida taking course CGS3001: Current Trends in Computing Technology 1 http://www.unf.edu/catalog/link/UGCGS3001C/ Friday, March 17th, 2017.

From Blog Post at: 
https://blog.grigsbyconsultingllc.com/test-driven-development-tools-for-developers-business-and-life/

Slides at:
https://blog.grigsbyconsultingllc.com/wp-content/uploads/CGS3001-20170317-DavidWGrigsby.pptx


Testing:
=========

Tested on: Visual Studio Community 2015 TDD Project (Windows)

[Note: App will run on Visual Studio Community for Mac 2017/2019, however the MSTest(s) will not run without changes. Plan is to create a new branch in the near future for this configuration support 2019-02-16]

Branches
=========
There are three branches to see each phase with the final state as master:

BaseFromUX – This is how the project was handed to the developer from UX and Solution Architect
FirstTestFails – This is our first test that tests the final requirement
FinalTestPasses – This is our test passing after adding code and one additional test for the helper function.
The requirements are below from the project Requirements.txt:

Requirements for TDD Project
=========

a. Use Text box values for values to us in call DocuSign API login_information

b. Create a service broker to call the DocuSign API login_information

c. Create related service broker utility methods to setup requests for service broker

d. Create related service broker utility methods to tear down response from service broker

e. Click the call docusign api button call the service broker and utilty methods with the text box values

f. Place the response into the multi-line text box for results

g. Expected result in multi-line text box for results is:

 "{\r\n  \"loginAccounts\": [\r\n    {\r\n      \"name\": \"eLawDocs\",\r\n      \"accountId\": \"26096\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/26096\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"DocuSign for GApps Trial for grigsbyconsultingllc.com\",\r\n      \"accountId\": \"79642\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/79642\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"GCLLC - TDD\",\r\n      \"accountId\": \"2773666\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/2773666\",\r\n      \"isDefault\": \"false\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    },\r\n    {\r\n      \"name\": \"GE Global Operations HR\",\r\n      \"accountId\": \"1559756\",\r\n      \"baseUrl\": \"https://demo.docusign.net/restapi/v2/accounts/1559756\",\r\n      \"isDefault\": \"true\",\r\n      \"userName\": \"David Grigsby\",\r\n      \"userId\": \"8375f42f-4d39-476f-9b5b-83aef3d9899b\",\r\n      \"email\": \"dgrigsby@grigsbyconsultingllc.com\",\r\n      \"siteDescription\": \"\"\r\n    }\r\n  ],\r\n  \"apiPassword\": \"P1ffoIdNbatKf537ghKlB1At98o=\"\r\n}"

Now the Password will not work nor the user id, so you will need to create your own free DocuSign developer account at the DocuSign Developer Center Free Sandbox and replace the expected results string with the results from your login_information call using postman. You can find the developer labs for the X-DocuSign-Authentication Best Practices for DocuSign™ via REST or SOAP in 10 minutes and the How to login to DocuSign™ via REST in 10 minutes at my Software Integration Author site davidwgrigsby.com. Signup before 3/24/2017 and receive them both for free.
