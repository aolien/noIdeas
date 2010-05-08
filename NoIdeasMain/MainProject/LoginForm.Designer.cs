namespace NoIdeas.Phone
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.signinbutton = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signinbutton
            // 
            this.signinbutton.Location = new System.Drawing.Point(140, 115);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(60, 20);
            this.signinbutton.TabIndex = 30;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.BackColor = System.Drawing.Color.Black;
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(39, 91);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(58, 15);
            this.passwordlabel.Text = "Password";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(100, 88);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(100, 21);
            this.passwordtextbox.TabIndex = 29;
            // 
            // usernamelabel
            // 
            this.usernamelabel.BackColor = System.Drawing.Color.Black;
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(30, 61);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(67, 14);
            this.usernamelabel.Text = "User Name";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(100, 58);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(100, 21);
            this.usernametextbox.TabIndex = 28;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(30, 115);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(72, 20);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // errorTextBox
            // 
            this.errorTextBox.BackColor = System.Drawing.Color.Red;
            this.errorTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.errorTextBox.ForeColor = System.Drawing.Color.Black;
            this.errorTextBox.Location = new System.Drawing.Point(39, 149);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(170, 42);
            this.errorTextBox.TabIndex = 36;
            this.errorTextBox.Text = "Try Again: Invalid User name/password combination";
            this.errorTextBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // sloganLabel
            // 
            this.sloganLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic);
            this.sloganLabel.ForeColor = System.Drawing.Color.White;
            this.sloganLabel.Location = new System.Drawing.Point(16, 37);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(221, 18);
            this.sloganLabel.Text = "...Where you walk into love!";
            // 
            // companyLabel
            // 
            this.companyLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.companyLabel.ForeColor = System.Drawing.Color.White;
            this.companyLabel.Location = new System.Drawing.Point(16, 12);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(224, 25);
            this.companyLabel.Text = "NoIdeas Dating Service";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "LoginForm";
            this.Text = "NoIdeas Dating Service";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label companyLabel;
    }
}