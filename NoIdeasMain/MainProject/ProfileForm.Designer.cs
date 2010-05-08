namespace NoIdeas.Phone
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.txtbNickName = new System.Windows.Forms.TextBox();
            this.lbNickName = new System.Windows.Forms.Label();
            this.txtbxFN = new System.Windows.Forms.TextBox();
            this.txtbxLN = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.lbSex = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNickError = new System.Windows.Forms.Label();
            this.lbSexError = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.lbYears = new System.Windows.Forms.Label();
            this.lbAgeError = new System.Windows.Forms.Label();
            this.race_label = new System.Windows.Forms.Label();
            this.hair_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.hairComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightCmTextbox = new System.Windows.Forms.TextBox();
            this.lbRaceError = new System.Windows.Forms.Label();
            this.lbHairError = new System.Windows.Forms.Label();
            this.lbHeightError = new System.Windows.Forms.Label();
            this.lbWeightError = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txPass = new System.Windows.Forms.TextBox();
            this.lbErrorPassword = new System.Windows.Forms.Label();
            this.lbErrorHeight = new System.Windows.Forms.Label();
            this.lbErrorWeight = new System.Windows.Forms.Label();
            this.cbInterest = new System.Windows.Forms.ComboBox();
            this.lbInterest = new System.Windows.Forms.Label();
            this.lbErrorInterest = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbErrorPhone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // txtbNickName
            // 
            this.txtbNickName.Location = new System.Drawing.Point(73, 12);
            this.txtbNickName.Name = "txtbNickName";
            this.txtbNickName.Size = new System.Drawing.Size(128, 21);
            this.txtbNickName.TabIndex = 0;
            this.txtbNickName.TextChanged += new System.EventHandler(this.txtbxNickName_TextChanged);
            // 
            // lbNickName
            // 
            this.lbNickName.BackColor = System.Drawing.Color.Black;
            this.lbNickName.ForeColor = System.Drawing.Color.White;
            this.lbNickName.Location = new System.Drawing.Point(4, 13);
            this.lbNickName.Name = "lbNickName";
            this.lbNickName.Size = new System.Drawing.Size(63, 20);
            this.lbNickName.Text = "Nick Name";
            // 
            // txtbxFN
            // 
            this.txtbxFN.Location = new System.Drawing.Point(73, 81);
            this.txtbxFN.Name = "txtbxFN";
            this.txtbxFN.Size = new System.Drawing.Size(128, 21);
            this.txtbxFN.TabIndex = 2;
            // 
            // txtbxLN
            // 
            this.txtbxLN.Location = new System.Drawing.Point(73, 109);
            this.txtbxLN.Name = "txtbxLN";
            this.txtbxLN.Size = new System.Drawing.Size(128, 21);
            this.txtbxLN.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.BackColor = System.Drawing.Color.Black;
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(2, 81);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(71, 20);
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.BackColor = System.Drawing.Color.Black;
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(2, 109);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 20);
            this.lbLastName.Text = "Last Name";
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.BackColor = System.Drawing.Color.Black;
            this.rdbtnMale.ForeColor = System.Drawing.Color.White;
            this.rdbtnMale.Location = new System.Drawing.Point(82, 168);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(64, 20);
            this.rdbtnMale.TabIndex = 6;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtMale_Checked);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.BackColor = System.Drawing.Color.Black;
            this.rdbtnFemale.ForeColor = System.Drawing.Color.White;
            this.rdbtnFemale.Location = new System.Drawing.Point(146, 168);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(64, 20);
            this.rdbtnFemale.TabIndex = 7;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.rdbtFemale_Checked);
            // 
            // lbSex
            // 
            this.lbSex.BackColor = System.Drawing.Color.Black;
            this.lbSex.ForeColor = System.Drawing.Color.White;
            this.lbSex.Location = new System.Drawing.Point(7, 167);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(71, 20);
            this.lbSex.Text = "Sex";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Back";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNickError
            // 
            this.lbNickError.ForeColor = System.Drawing.Color.Red;
            this.lbNickError.Location = new System.Drawing.Point(207, 13);
            this.lbNickError.Name = "lbNickError";
            this.lbNickError.Size = new System.Drawing.Size(21, 20);
            this.lbNickError.Text = "(*)";
            this.lbNickError.Visible = false;
            // 
            // lbSexError
            // 
            this.lbSexError.ForeColor = System.Drawing.Color.Red;
            this.lbSexError.Location = new System.Drawing.Point(210, 168);
            this.lbSexError.Name = "lbSexError";
            this.lbSexError.Size = new System.Drawing.Size(21, 20);
            this.lbSexError.Text = "(*)";
            this.lbSexError.Visible = false;
            // 
            // lbAge
            // 
            this.lbAge.BackColor = System.Drawing.Color.Black;
            this.lbAge.ForeColor = System.Drawing.Color.White;
            this.lbAge.Location = new System.Drawing.Point(5, 191);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(71, 20);
            this.lbAge.Text = "Age";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(82, 190);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(58, 21);
            this.txtbxAge.TabIndex = 19;
            this.txtbxAge.TextChanged += new System.EventHandler(this.txtbxAge_TextChanged);
            // 
            // lbYears
            // 
            this.lbYears.BackColor = System.Drawing.Color.Black;
            this.lbYears.ForeColor = System.Drawing.Color.White;
            this.lbYears.Location = new System.Drawing.Point(146, 191);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(58, 20);
            this.lbYears.Text = "Years";
            // 
            // lbAgeError
            // 
            this.lbAgeError.ForeColor = System.Drawing.Color.Red;
            this.lbAgeError.Location = new System.Drawing.Point(210, 191);
            this.lbAgeError.Name = "lbAgeError";
            this.lbAgeError.Size = new System.Drawing.Size(21, 20);
            this.lbAgeError.Text = "(*)";
            this.lbAgeError.Visible = false;
            // 
            // race_label
            // 
            this.race_label.BackColor = System.Drawing.Color.Black;
            this.race_label.ForeColor = System.Drawing.Color.White;
            this.race_label.Location = new System.Drawing.Point(6, 220);
            this.race_label.Name = "race_label";
            this.race_label.Size = new System.Drawing.Size(71, 20);
            this.race_label.Text = "Race";
            // 
            // hair_label
            // 
            this.hair_label.BackColor = System.Drawing.Color.Black;
            this.hair_label.ForeColor = System.Drawing.Color.White;
            this.hair_label.Location = new System.Drawing.Point(7, 245);
            this.hair_label.Name = "hair_label";
            this.hair_label.Size = new System.Drawing.Size(71, 20);
            this.hair_label.Text = "Hair";
            // 
            // height_label
            // 
            this.height_label.BackColor = System.Drawing.Color.Black;
            this.height_label.ForeColor = System.Drawing.Color.White;
            this.height_label.Location = new System.Drawing.Point(6, 274);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(71, 20);
            this.height_label.Text = "Height";
            // 
            // weight_label
            // 
            this.weight_label.BackColor = System.Drawing.Color.Black;
            this.weight_label.ForeColor = System.Drawing.Color.White;
            this.weight_label.Location = new System.Drawing.Point(5, 305);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(71, 20);
            this.weight_label.Text = "Weight";
            // 
            // raceComboBox
            // 
            this.raceComboBox.Items.Add("White");
            this.raceComboBox.Items.Add("Asian");
            this.raceComboBox.Items.Add("Latino/a");
            this.raceComboBox.Items.Add("Black");
            this.raceComboBox.Items.Add("Indian");
            this.raceComboBox.Items.Add("Native");
            this.raceComboBox.Location = new System.Drawing.Point(82, 217);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(59, 22);
            this.raceComboBox.TabIndex = 36;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // hairComboBox
            // 
            this.hairComboBox.Items.Add("Blonde");
            this.hairComboBox.Items.Add("Brunette");
            this.hairComboBox.Items.Add("Brown");
            this.hairComboBox.Items.Add("Red");
            this.hairComboBox.Items.Add("Other");
            this.hairComboBox.Location = new System.Drawing.Point(82, 245);
            this.hairComboBox.Name = "hairComboBox";
            this.hairComboBox.Size = new System.Drawing.Size(59, 22);
            this.hairComboBox.TabIndex = 41;
            this.hairComboBox.SelectedIndexChanged += new System.EventHandler(this.hairComboBox_SelectedIndexChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(82, 301);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(35, 21);
            this.weightTextBox.TabIndex = 46;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // heightCmTextbox
            // 
            this.heightCmTextbox.Location = new System.Drawing.Point(82, 274);
            this.heightCmTextbox.Name = "heightCmTextbox";
            this.heightCmTextbox.Size = new System.Drawing.Size(35, 21);
            this.heightCmTextbox.TabIndex = 47;
            this.heightCmTextbox.TextChanged += new System.EventHandler(this.heightCmTextbox_TextChanged);
            // 
            // lbRaceError
            // 
            this.lbRaceError.ForeColor = System.Drawing.Color.Red;
            this.lbRaceError.Location = new System.Drawing.Point(147, 220);
            this.lbRaceError.Name = "lbRaceError";
            this.lbRaceError.Size = new System.Drawing.Size(21, 20);
            this.lbRaceError.Text = "(*)";
            this.lbRaceError.Visible = false;
            // 
            // lbHairError
            // 
            this.lbHairError.ForeColor = System.Drawing.Color.Red;
            this.lbHairError.Location = new System.Drawing.Point(147, 247);
            this.lbHairError.Name = "lbHairError";
            this.lbHairError.Size = new System.Drawing.Size(21, 20);
            this.lbHairError.Text = "(*)";
            this.lbHairError.Visible = false;
            // 
            // lbHeightError
            // 
            this.lbHeightError.ForeColor = System.Drawing.Color.Red;
            this.lbHeightError.Location = new System.Drawing.Point(146, 275);
            this.lbHeightError.Name = "lbHeightError";
            this.lbHeightError.Size = new System.Drawing.Size(21, 20);
            this.lbHeightError.Text = "(*)";
            this.lbHeightError.Visible = false;
            // 
            // lbWeightError
            // 
            this.lbWeightError.ForeColor = System.Drawing.Color.Red;
            this.lbWeightError.Location = new System.Drawing.Point(146, 302);
            this.lbWeightError.Name = "lbWeightError";
            this.lbWeightError.Size = new System.Drawing.Size(21, 20);
            this.lbWeightError.Text = "(*)";
            this.lbWeightError.Visible = false;
            // 
            // lbPass
            // 
            this.lbPass.BackColor = System.Drawing.Color.Black;
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(4, 45);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(71, 20);
            this.lbPass.Text = "Password";
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(73, 44);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(128, 21);
            this.txPass.TabIndex = 68;
            this.txPass.TextChanged += new System.EventHandler(this.txPass_TextChanged);
            // 
            // lbErrorPassword
            // 
            this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassword.Location = new System.Drawing.Point(207, 45);
            this.lbErrorPassword.Name = "lbErrorPassword";
            this.lbErrorPassword.Size = new System.Drawing.Size(21, 20);
            this.lbErrorPassword.Text = "(*)";
            this.lbErrorPassword.Visible = false;
            // 
            // lbErrorHeight
            // 
            this.lbErrorHeight.BackColor = System.Drawing.Color.Black;
            this.lbErrorHeight.ForeColor = System.Drawing.Color.White;
            this.lbErrorHeight.Location = new System.Drawing.Point(118, 274);
            this.lbErrorHeight.Name = "lbErrorHeight";
            this.lbErrorHeight.Size = new System.Drawing.Size(23, 20);
            this.lbErrorHeight.Text = "cm";
            // 
            // lbErrorWeight
            // 
            this.lbErrorWeight.BackColor = System.Drawing.Color.Black;
            this.lbErrorWeight.ForeColor = System.Drawing.Color.White;
            this.lbErrorWeight.Location = new System.Drawing.Point(123, 305);
            this.lbErrorWeight.Name = "lbErrorWeight";
            this.lbErrorWeight.Size = new System.Drawing.Size(16, 20);
            this.lbErrorWeight.Text = "lb";
            // 
            // cbInterest
            // 
            this.cbInterest.Items.Add("Books");
            this.cbInterest.Items.Add("Music");
            this.cbInterest.Items.Add("Games");
            this.cbInterest.Items.Add("Beer");
            this.cbInterest.Location = new System.Drawing.Point(76, 342);
            this.cbInterest.Name = "cbInterest";
            this.cbInterest.Size = new System.Drawing.Size(92, 22);
            this.cbInterest.TabIndex = 89;
            this.cbInterest.SelectedIndexChanged += new System.EventHandler(this.cbInterest_SelectedIndexChanged);
            // 
            // lbInterest
            // 
            this.lbInterest.BackColor = System.Drawing.Color.Black;
            this.lbInterest.ForeColor = System.Drawing.Color.White;
            this.lbInterest.Location = new System.Drawing.Point(5, 343);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(65, 20);
            this.lbInterest.Text = "Interest";
            // 
            // lbErrorInterest
            // 
            this.lbErrorInterest.ForeColor = System.Drawing.Color.Red;
            this.lbErrorInterest.Location = new System.Drawing.Point(207, 343);
            this.lbErrorInterest.Name = "lbErrorInterest";
            this.lbErrorInterest.Size = new System.Drawing.Size(21, 20);
            this.lbErrorInterest.Text = "(*)";
            this.lbErrorInterest.Visible = false;
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(73, 141);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(128, 21);
            this.txPhone.TabIndex = 111;
            this.txPhone.TextChanged += new System.EventHandler(this.txPhone_TextChanged);
            // 
            // lbPhone
            // 
            this.lbPhone.BackColor = System.Drawing.Color.Black;
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(2, 141);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(65, 20);
            this.lbPhone.Text = "Phone";
            // 
            // lbErrorPhone
            // 
            this.lbErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPhone.Location = new System.Drawing.Point(207, 141);
            this.lbErrorPhone.Name = "lbErrorPhone";
            this.lbErrorPhone.Size = new System.Drawing.Size(21, 20);
            this.lbErrorPhone.Text = "(*)";
            this.lbErrorPhone.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbErrorPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txPhone);
            this.Controls.Add(this.lbErrorInterest);
            this.Controls.Add(this.lbInterest);
            this.Controls.Add(this.cbInterest);
            this.Controls.Add(this.lbErrorWeight);
            this.Controls.Add(this.lbErrorHeight);
            this.Controls.Add(this.lbErrorPassword);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbWeightError);
            this.Controls.Add(this.lbHeightError);
            this.Controls.Add(this.lbHairError);
            this.Controls.Add(this.lbRaceError);
            this.Controls.Add(this.heightCmTextbox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.hairComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.hair_label);
            this.Controls.Add(this.race_label);
            this.Controls.Add(this.lbAgeError);
            this.Controls.Add(this.lbYears);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSexError);
            this.Controls.Add(this.lbNickError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.txtbxLN);
            this.Controls.Add(this.txtbxFN);
            this.Controls.Add(this.lbNickName);
            this.Controls.Add(this.txtbNickName);
            this.Menu = this.mainMenu1;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNickName;
        private System.Windows.Forms.Label lbNickName;
        private System.Windows.Forms.TextBox txtbxFN;
        private System.Windows.Forms.TextBox txtbxLN;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNickError;
        private System.Windows.Forms.Label lbSexError;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.Label lbYears;

        private System.Windows.Forms.Label lbAgeError;
        private System.Windows.Forms.Label race_label;
        private System.Windows.Forms.Label hair_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox hairComboBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightCmTextbox;
        private System.Windows.Forms.Label lbRaceError;
        private System.Windows.Forms.Label lbHairError;
        private System.Windows.Forms.Label lbHeightError;
        private System.Windows.Forms.Label lbWeightError;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorHeight;
        private System.Windows.Forms.Label lbErrorWeight;
        private System.Windows.Forms.ComboBox cbInterest;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.Label lbErrorInterest;
        private System.Windows.Forms.TextBox txPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbErrorPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}