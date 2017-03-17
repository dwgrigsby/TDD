namespace TDD
{
    partial class tdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbIntKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbURI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbLoginURI = new System.Windows.Forms.TextBox();
            this.CallDSAPI = new System.Windows.Forms.Button();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(104, 12);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(202, 20);
            this.TbUserName.TabIndex = 0;
            this.TbUserName.Text = "dgrigsby@grigsbyconsultingllc.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(104, 38);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(202, 20);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.Text = "P1ffoIdNbatKf537ghKlB1At98o=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int Key";
            // 
            // TbIntKey
            // 
            this.TbIntKey.Location = new System.Drawing.Point(104, 64);
            this.TbIntKey.Name = "TbIntKey";
            this.TbIntKey.Size = new System.Drawing.Size(245, 20);
            this.TbIntKey.TabIndex = 4;
            this.TbIntKey.Text = "GCLL-24fc8a04-7fbc-4a12-b547-4d02bde7dd28";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "URI";
            // 
            // TbURI
            // 
            this.TbURI.Location = new System.Drawing.Point(104, 90);
            this.TbURI.Name = "TbURI";
            this.TbURI.Size = new System.Drawing.Size(245, 20);
            this.TbURI.TabIndex = 6;
            this.TbURI.Text = "https://demo.docusign.net/restapi/v2/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "URI - Login Info";
            // 
            // TbLoginURI
            // 
            this.TbLoginURI.Location = new System.Drawing.Point(104, 116);
            this.TbLoginURI.Name = "TbLoginURI";
            this.TbLoginURI.Size = new System.Drawing.Size(245, 20);
            this.TbLoginURI.TabIndex = 8;
            this.TbLoginURI.Text = "login_information?api_password=true";
            // 
            // CallDSAPI
            // 
            this.CallDSAPI.Location = new System.Drawing.Point(368, 116);
            this.CallDSAPI.Name = "CallDSAPI";
            this.CallDSAPI.Size = new System.Drawing.Size(107, 23);
            this.CallDSAPI.TabIndex = 10;
            this.CallDSAPI.Text = "Call DS API";
            this.CallDSAPI.UseVisualStyleBackColor = true;
            this.CallDSAPI.Click += new System.EventHandler(this.CallDSAPI_Click);
            // 
            // TbResults
            // 
            this.TbResults.Location = new System.Drawing.Point(104, 154);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.Size = new System.Drawing.Size(403, 142);
            this.TbResults.TabIndex = 11;
            this.TbResults.Text = "No Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result of API Call";
            // 
            // tdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 308);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.CallDSAPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbLoginURI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbURI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbIntKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbUserName);
            this.Name = "tdd";
            this.Text = "tdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbIntKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbURI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbLoginURI;
        private System.Windows.Forms.Button CallDSAPI;
        private System.Windows.Forms.TextBox TbResults;
        private System.Windows.Forms.Label label6;
    }
}

