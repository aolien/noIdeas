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
            this.interests_label = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.hairComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.heightFtTextbox = new System.Windows.Forms.TextBox();
            this.ftLabel1 = new System.Windows.Forms.Label();
            this.inLabel1 = new System.Windows.Forms.Label();
            this.heightInTextBox = new System.Windows.Forms.TextBox();
            this.lbRaceError = new System.Windows.Forms.Label();
            this.lbHairError = new System.Windows.Forms.Label();
            this.lbHeightError = new System.Windows.Forms.Label();
            this.lbWeightError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNickName
            // 
            this.txtbNickName.Location = new System.Drawing.Point(81, 14);
            this.txtbNickName.Name = "txtbNickName";
            this.txtbNickName.Size = new System.Drawing.Size(128, 21);
            this.txtbNickName.TabIndex = 0;
            this.txtbNickName.TextChanged += new System.EventHandler(this.txtbxNickName_TextChanged);
            // 
            // lbNickName
            // 
            this.lbNickName.Location = new System.Drawing.Point(4, 14);
            this.lbNickName.Name = "lbNickName";
            this.lbNickName.Size = new System.Drawing.Size(71, 20);
            this.lbNickName.Text = "Nick Name";
            // 
            // txtbxFN
            // 
            this.txtbxFN.Location = new System.Drawing.Point(81, 42);
            this.txtbxFN.Name = "txtbxFN";
            this.txtbxFN.Size = new System.Drawing.Size(128, 21);
            this.txtbxFN.TabIndex = 2;
            // 
            // txtbxLN
            // 
            this.txtbxLN.Location = new System.Drawing.Point(81, 70);
            this.txtbxLN.Name = "txtbxLN";
            this.txtbxLN.Size = new System.Drawing.Size(128, 21);
            this.txtbxLN.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.Location = new System.Drawing.Point(4, 42);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(71, 20);
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.Location = new System.Drawing.Point(4, 70);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 20);
            this.lbLastName.Text = "Last Name";
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.Location = new System.Drawing.Point(81, 97);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(64, 20);
            this.rdbtnMale.TabIndex = 6;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtMale_Checked);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.Location = new System.Drawing.Point(145, 97);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(64, 20);
            this.rdbtnFemale.TabIndex = 7;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.rdbtFemale_Checked);
            // 
            // lbSex
            // 
            this.lbSex.Location = new System.Drawing.Point(4, 96);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(71, 20);
            this.lbSex.Text = "Sex";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Back";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNickError
            // 
            this.lbNickError.ForeColor = System.Drawing.Color.Red;
            this.lbNickError.Location = new System.Drawing.Point(215, 15);
            this.lbNickError.Name = "lbNickError";
            this.lbNickError.Size = new System.Drawing.Size(21, 20);
            this.lbNickError.Text = "(*)";
            this.lbNickError.Visible = false;
            this.lbNickError.ParentChanged += new System.EventHandler(this.lbNickError_ParentChanged);
            // 
            // lbSexError
            // 
            this.lbSexError.ForeColor = System.Drawing.Color.Red;
            this.lbSexError.Location = new System.Drawing.Point(215, 97);
            this.lbSexError.Name = "lbSexError";
            this.lbSexError.Size = new System.Drawing.Size(21, 20);
            this.lbSexError.Text = "(*)";
            this.lbSexError.Visible = false;
            // 
            // lbAge
            // 
            this.lbAge.Location = new System.Drawing.Point(4, 120);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(71, 20);
            this.lbAge.Text = "Age";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(81, 119);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(46, 21);
            this.txtbxAge.TabIndex = 19;
            this.txtbxAge.TextChanged += new System.EventHandler(this.txtbxAge_TextChanged);
            // 
            // lbYears
            // 
            this.lbYears.Location = new System.Drawing.Point(145, 120);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(58, 20);
            this.lbYears.Text = "Years";
            // 
            // lbAgeError
            // 
            this.lbAgeError.ForeColor = System.Drawing.Color.Red;
            this.lbAgeError.Location = new System.Drawing.Point(215, 120);
            this.lbAgeError.Name = "lbAgeError";
            this.lbAgeError.Size = new System.Drawing.Size(21, 20);
            this.lbAgeError.Text = "(*)";
            this.lbAgeError.Visible = false;
            // 
            // race_label
            // 
            this.race_label.Location = new System.Drawing.Point(5, 149);
            this.race_label.Name = "race_label";
            this.race_label.Size = new System.Drawing.Size(71, 20);
            this.race_label.Text = "Race";
            // 
            // hair_label
            // 
            this.hair_label.Location = new System.Drawing.Point(6, 174);
            this.hair_label.Name = "hair_label";
            this.hair_label.Size = new System.Drawing.Size(71, 20);
            this.hair_label.Text = "Hair";
            // 
            // height_label
            // 
            this.height_label.Location = new System.Drawing.Point(5, 203);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(71, 20);
            this.height_label.Text = "Height";
            // 
            // weight_label
            // 
            this.weight_label.Location = new System.Drawing.Point(4, 234);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(71, 20);
            this.weight_label.Text = "Weight";
            // 
            // interests_label
            // 
            this.interests_label.Location = new System.Drawing.Point(5, 254);
            this.interests_label.Name = "interests_label";
            this.interests_label.Size = new System.Drawing.Size(55, 20);
            this.interests_label.Text = "Interests";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(226, 229);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(13, 100);
            this.vScrollBar1.TabIndex = 35;
            // 
            // raceComboBox
            // 
            this.raceComboBox.Items.Add("White");
            this.raceComboBox.Items.Add("Asian");
            this.raceComboBox.Items.Add("Latino/a");
            this.raceComboBox.Items.Add("Black");
            this.raceComboBox.Items.Add("Indian");
            this.raceComboBox.Items.Add("Native");
            this.raceComboBox.Location = new System.Drawing.Point(81, 146);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(59, 22);
            this.raceComboBox.TabIndex = 36;
            // 
            // hairComboBox
            // 
            this.hairComboBox.Items.Add("Blonde");
            this.hairComboBox.Items.Add("Brunette");
            this.hairComboBox.Items.Add("Brown");
            this.hairComboBox.Items.Add("Red");
            this.hairComboBox.Items.Add("Other");
            this.hairComboBox.Location = new System.Drawing.Point(81, 174);
            this.hairComboBox.Name = "hairComboBox";
            this.hairComboBox.Size = new System.Drawing.Size(59, 22);
            this.hairComboBox.TabIndex = 41;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(81, 230);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(33, 21);
            this.weightTextBox.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 326);
            // 
            // heightFtTextbox
            // 
            this.heightFtTextbox.Location = new System.Drawing.Point(81, 203);
            this.heightFtTextbox.Name = "heightFtTextbox";
            this.heightFtTextbox.Size = new System.Drawing.Size(26, 21);
            this.heightFtTextbox.TabIndex = 47;
            // 
            // ftLabel1
            // 
            this.ftLabel1.Location = new System.Drawing.Point(119, 204);
            this.ftLabel1.Name = "ftLabel1";
            this.ftLabel1.Size = new System.Drawing.Size(21, 20);
            this.ftLabel1.Text = "Ft";
            // 
            // inLabel1
            // 
            this.inLabel1.Location = new System.Drawing.Point(182, 204);
            this.inLabel1.Name = "inLabel1";
            this.inLabel1.Size = new System.Drawing.Size(21, 20);
            this.inLabel1.Text = "In";
            // 
            // heightInTextBox
            // 
            this.heightInTextBox.Location = new System.Drawing.Point(145, 203);
            this.heightInTextBox.Name = "heightInTextBox";
            this.heightInTextBox.Size = new System.Drawing.Size(27, 21);
            this.heightInTextBox.TabIndex = 51;
            // 
            // lbRaceError
            // 
            this.lbRaceError.ForeColor = System.Drawing.Color.Red;
            this.lbRaceError.Location = new System.Drawing.Point(151, 146);
            this.lbRaceError.Name = "lbRaceError";
            this.lbRaceError.Size = new System.Drawing.Size(21, 20);
            this.lbRaceError.Text = "(*)";
            this.lbRaceError.Visible = false;
            // 
            // lbHairError
            // 
            this.lbHairError.ForeColor = System.Drawing.Color.Red;
            this.lbHairError.Location = new System.Drawing.Point(151, 174);
            this.lbHairError.Name = "lbHairError";
            this.lbHairError.Size = new System.Drawing.Size(21, 20);
            this.lbHairError.Text = "(*)";
            this.lbHairError.Visible = false;
            // 
            // lbHeightError
            // 
            this.lbHeightError.ForeColor = System.Drawing.Color.Red;
            this.lbHeightError.Location = new System.Drawing.Point(199, 204);
            this.lbHeightError.Name = "lbHeightError";
            this.lbHeightError.Size = new System.Drawing.Size(21, 20);
            this.lbHeightError.Text = "(*)";
            this.lbHeightError.Visible = false;
            // 
            // lbWeightError
            // 
            this.lbWeightError.ForeColor = System.Drawing.Color.Red;
            this.lbWeightError.Location = new System.Drawing.Point(124, 230);
            this.lbWeightError.Name = "lbWeightError";
            this.lbWeightError.Size = new System.Drawing.Size(21, 20);
            this.lbWeightError.Text = "(*)";
            this.lbWeightError.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lbWeightError);
            this.Controls.Add(this.lbHeightError);
            this.Controls.Add(this.lbHairError);
            this.Controls.Add(this.lbRaceError);
            this.Controls.Add(this.inLabel1);
            this.Controls.Add(this.heightInTextBox);
            this.Controls.Add(this.ftLabel1);
            this.Controls.Add(this.heightFtTextbox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.hairComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.interests_label);
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
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Label interests_label;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox hairComboBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox heightFtTextbox;
        private System.Windows.Forms.Label ftLabel1;
        private System.Windows.Forms.Label inLabel1;
        private System.Windows.Forms.TextBox heightInTextBox;
        private System.Windows.Forms.Label lbRaceError;
        private System.Windows.Forms.Label lbHairError;
        private System.Windows.Forms.Label lbHeightError;
        private System.Windows.Forms.Label lbWeightError;
    }
}