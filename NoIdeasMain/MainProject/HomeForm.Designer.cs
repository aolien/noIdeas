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
            this.createAdbutton = new System.Windows.Forms.Button();
            this.btnGetMatches = new System.Windows.Forms.Button();
            this.btExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noideasdatelabel
            // 
            this.noideasdatelabel.BackColor = System.Drawing.Color.Pink;
            this.noideasdatelabel.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.noideasdatelabel.ForeColor = System.Drawing.Color.Black;
            this.noideasdatelabel.Location = new System.Drawing.Point(65, 10);
            this.noideasdatelabel.Name = "noideasdatelabel";
            this.noideasdatelabel.Size = new System.Drawing.Size(107, 35);
            this.noideasdatelabel.Text = "No Ideas Dating Service";
            this.noideasdatelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // editprofilebutton
            // 
            this.editprofilebutton.Location = new System.Drawing.Point(65, 48);
            this.editprofilebutton.Name = "editprofilebutton";
            this.editprofilebutton.Size = new System.Drawing.Size(107, 22);
            this.editprofilebutton.TabIndex = 14;
            this.editprofilebutton.Text = "Edit Profile";
            this.editprofilebutton.Click += new System.EventHandler(this.editprofilebutton_Click);
            // 
            // createAdbutton
            // 
            this.createAdbutton.Location = new System.Drawing.Point(65, 76);
            this.createAdbutton.Name = "createAdbutton";
            this.createAdbutton.Size = new System.Drawing.Size(107, 22);
            this.createAdbutton.TabIndex = 15;
            this.createAdbutton.Text = "Create Date Ad";
            this.createAdbutton.Click += new System.EventHandler(this.createAdbutton_Click);
            // 
            // btnGetMatches
            // 
            this.btnGetMatches.Location = new System.Drawing.Point(65, 104);
            this.btnGetMatches.Name = "btnGetMatches";
            this.btnGetMatches.Size = new System.Drawing.Size(107, 20);
            this.btnGetMatches.TabIndex = 30;
            this.btnGetMatches.Text = "Get Matches";
            this.btnGetMatches.Click += new System.EventHandler(this.btnGetMatches_Click);
            // 
            // btExitApp
            // 
            this.btExitApp.Location = new System.Drawing.Point(82, 327);
            this.btExitApp.Name = "btExitApp";
            this.btExitApp.Size = new System.Drawing.Size(72, 20);
            this.btExitApp.TabIndex = 34;
            this.btExitApp.Text = "Exit App";
            this.btExitApp.Click += new System.EventHandler(this.btExitApp_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btExitApp);
            this.Controls.Add(this.btnGetMatches);
            this.Controls.Add(this.createAdbutton);
            this.Controls.Add(this.editprofilebutton);
            this.Controls.Add(this.noideasdatelabel);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "HomeForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Label noideasdatelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editprofilebutton;
        private System.Windows.Forms.Button createAdbutton;
        private System.Windows.Forms.Button btnGetMatches;
        private System.Windows.Forms.Button btExitApp;
    }
}

