namespace NoIdeas.Phone
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.noideasdatelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editprofilebutton = new System.Windows.Forms.Button();
            this.finddatebutton = new System.Windows.Forms.Button();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.signinbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noideasdatelabel
            // 
            this.noideasdatelabel.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.noideasdatelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.noideasdatelabel.Location = new System.Drawing.Point(65, 10);
            this.noideasdatelabel.Name = "noideasdatelabel";
            this.noideasdatelabel.Size = new System.Drawing.Size(107, 35);
            this.noideasdatelabel.Text = "No Ideas Dating Service";
            this.noideasdatelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.noideasdatelabel.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-32, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 304);
            // 
            // editprofilebutton
            // 
            this.editprofilebutton.Location = new System.Drawing.Point(75, 153);
            this.editprofilebutton.Name = "editprofilebutton";
            this.editprofilebutton.Size = new System.Drawing.Size(83, 22);
            this.editprofilebutton.TabIndex = 14;
            this.editprofilebutton.Text = "Edit Profile";
            this.editprofilebutton.Visible = false;
            this.editprofilebutton.Click += new System.EventHandler(this.editprofilebutton_Click);
            // 
            // finddatebutton
            // 
            this.finddatebutton.Location = new System.Drawing.Point(75, 183);
            this.finddatebutton.Name = "finddatebutton";
            this.finddatebutton.Size = new System.Drawing.Size(83, 22);
            this.finddatebutton.TabIndex = 15;
            this.finddatebutton.Text = "Find Date!";
            this.finddatebutton.Visible = false;
            this.finddatebutton.Click += new System.EventHandler(this.finddatebutton_Click);
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(95, 67);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(100, 21);
            this.usernametextbox.TabIndex = 20;
            // 
            // usernamelabel
            // 
            this.usernamelabel.Location = new System.Drawing.Point(25, 70);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(67, 14);
            this.usernamelabel.Text = "User Name";
            // 
            // passwordlabel
            // 
            this.passwordlabel.Location = new System.Drawing.Point(34, 100);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(58, 15);
            this.passwordlabel.Text = "Password";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(95, 97);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(100, 21);
            this.passwordtextbox.TabIndex = 23;
            // 
            // signinbutton
            // 
            this.signinbutton.Location = new System.Drawing.Point(86, 124);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(60, 20);
            this.signinbutton.TabIndex = 25;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.finddatebutton);
            this.Controls.Add(this.editprofilebutton);
            this.Controls.Add(this.noideasdatelabel);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "HomeForm";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Label noideasdatelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editprofilebutton;
        private System.Windows.Forms.Button finddatebutton;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button signinbutton;
    }
}

