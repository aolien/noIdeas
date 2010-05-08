namespace NoIdeas.Phone

{
    partial class DateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.datePrefLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ageMinLabel = new System.Windows.Forms.Label();
            this.ageMinComboBox = new System.Windows.Forms.TextBox();
            this.ageMaxComboBox = new System.Windows.Forms.TextBox();
            this.ageMaxLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.heightMinCmTextbox = new System.Windows.Forms.TextBox();
            this.heightMinLabel = new System.Windows.Forms.Label();
            this.ftLabel1 = new System.Windows.Forms.Label();
            this.ftLabel2 = new System.Windows.Forms.Label();
            this.heightMaxCmTextBox = new System.Windows.Forms.TextBox();
            this.heightMaxLabel = new System.Windows.Forms.Label();
            this.hairLabel = new System.Windows.Forms.Label();
            this.weightMaxTextBox = new System.Windows.Forms.TextBox();
            this.weightMaxLabel = new System.Windows.Forms.Label();
            this.weightMinTextBox = new System.Windows.Forms.TextBox();
            this.weightMinLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.lbSexError = new System.Windows.Forms.Label();
            this.lbAgeMinError = new System.Windows.Forms.Label();
            this.lbAgeMaxError = new System.Windows.Forms.Label();
            this.lbRangeError = new System.Windows.Forms.Label();
            this.lbRaceError = new System.Windows.Forms.Label();
            this.lbHeightMinError = new System.Windows.Forms.Label();
            this.lbHeightMaxError = new System.Windows.Forms.Label();
            this.lbWeightMinError = new System.Windows.Forms.Label();
            this.lbWeightMaxError = new System.Windows.Forms.Label();
            this.lbHairError = new System.Windows.Forms.Label();
            this.txRange = new System.Windows.Forms.TextBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.hairComboBox = new System.Windows.Forms.ComboBox();
            this.lbErrorInterest = new System.Windows.Forms.Label();
            this.lbInterest = new System.Windows.Forms.Label();
            this.cbInterest = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // datePrefLabel
            // 
            this.datePrefLabel.BackColor = System.Drawing.Color.Black;
            this.datePrefLabel.ForeColor = System.Drawing.Color.White;
            this.datePrefLabel.Location = new System.Drawing.Point(13, 15);
            this.datePrefLabel.Name = "datePrefLabel";
            this.datePrefLabel.Size = new System.Drawing.Size(141, 18);
            this.datePrefLabel.Text = "My Date Preferences:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Items.Add("f");
            this.sexComboBox.Items.Add("m");
            this.sexComboBox.Location = new System.Drawing.Point(180, 37);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(33, 22);
            this.sexComboBox.TabIndex = 2;
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.sexComboBox_SelectedIndexChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.BackColor = System.Drawing.Color.Black;
            this.sexLabel.ForeColor = System.Drawing.Color.White;
            this.sexLabel.Location = new System.Drawing.Point(142, 39);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(27, 20);
            this.sexLabel.Text = "Sex";
            // 
            // ageMinLabel
            // 
            this.ageMinLabel.BackColor = System.Drawing.Color.Black;
            this.ageMinLabel.ForeColor = System.Drawing.Color.White;
            this.ageMinLabel.Location = new System.Drawing.Point(88, 70);
            this.ageMinLabel.Name = "ageMinLabel";
            this.ageMinLabel.Size = new System.Drawing.Size(82, 20);
            this.ageMinLabel.Text = "Age Minimum";
            // 
            // ageMinComboBox
            // 
            this.ageMinComboBox.Location = new System.Drawing.Point(180, 69);
            this.ageMinComboBox.Name = "ageMinComboBox";
            this.ageMinComboBox.Size = new System.Drawing.Size(33, 21);
            this.ageMinComboBox.TabIndex = 7;
            this.ageMinComboBox.TextChanged += new System.EventHandler(this.ageMinComboBox_TextChanged);
            // 
            // ageMaxComboBox
            // 
            this.ageMaxComboBox.Location = new System.Drawing.Point(180, 100);
            this.ageMaxComboBox.Name = "ageMaxComboBox";
            this.ageMaxComboBox.Size = new System.Drawing.Size(33, 21);
            this.ageMaxComboBox.TabIndex = 9;
            this.ageMaxComboBox.TextChanged += new System.EventHandler(this.ageMaxComboBox_TextChanged);
            // 
            // ageMaxLabel
            // 
            this.ageMaxLabel.BackColor = System.Drawing.Color.Black;
            this.ageMaxLabel.ForeColor = System.Drawing.Color.White;
            this.ageMaxLabel.Location = new System.Drawing.Point(85, 101);
            this.ageMaxLabel.Name = "ageMaxLabel";
            this.ageMaxLabel.Size = new System.Drawing.Size(82, 20);
            this.ageMaxLabel.Text = "Age Maximum";
            // 
            // rangeLabel
            // 
            this.rangeLabel.BackColor = System.Drawing.Color.Black;
            this.rangeLabel.ForeColor = System.Drawing.Color.White;
            this.rangeLabel.Location = new System.Drawing.Point(81, 131);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(67, 20);
            this.rangeLabel.Text = "Range (m)";
            // 
            // raceLabel
            // 
            this.raceLabel.BackColor = System.Drawing.Color.Black;
            this.raceLabel.ForeColor = System.Drawing.Color.White;
            this.raceLabel.Location = new System.Drawing.Point(119, 166);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(32, 20);
            this.raceLabel.Text = "Race";
            // 
            // heightMinCmTextbox
            // 
            this.heightMinCmTextbox.Location = new System.Drawing.Point(151, 197);
            this.heightMinCmTextbox.Name = "heightMinCmTextbox";
            this.heightMinCmTextbox.Size = new System.Drawing.Size(35, 21);
            this.heightMinCmTextbox.TabIndex = 22;
            this.heightMinCmTextbox.TextChanged += new System.EventHandler(this.heightMinFtTextbox_TextChanged);
            // 
            // heightMinLabel
            // 
            this.heightMinLabel.BackColor = System.Drawing.Color.Black;
            this.heightMinLabel.ForeColor = System.Drawing.Color.White;
            this.heightMinLabel.Location = new System.Drawing.Point(55, 198);
            this.heightMinLabel.Name = "heightMinLabel";
            this.heightMinLabel.Size = new System.Drawing.Size(96, 20);
            this.heightMinLabel.Text = "Height Minimum";
            // 
            // ftLabel1
            // 
            this.ftLabel1.BackColor = System.Drawing.Color.Black;
            this.ftLabel1.ForeColor = System.Drawing.Color.White;
            this.ftLabel1.Location = new System.Drawing.Point(192, 199);
            this.ftLabel1.Name = "ftLabel1";
            this.ftLabel1.Size = new System.Drawing.Size(32, 20);
            this.ftLabel1.Text = "Cm";
            // 
            // ftLabel2
            // 
            this.ftLabel2.BackColor = System.Drawing.Color.Black;
            this.ftLabel2.ForeColor = System.Drawing.Color.White;
            this.ftLabel2.Location = new System.Drawing.Point(192, 226);
            this.ftLabel2.Name = "ftLabel2";
            this.ftLabel2.Size = new System.Drawing.Size(32, 20);
            this.ftLabel2.Text = "Cm";
            // 
            // heightMaxCmTextBox
            // 
            this.heightMaxCmTextBox.Location = new System.Drawing.Point(151, 226);
            this.heightMaxCmTextBox.Name = "heightMaxCmTextBox";
            this.heightMaxCmTextBox.Size = new System.Drawing.Size(35, 21);
            this.heightMaxCmTextBox.TabIndex = 32;
            this.heightMaxCmTextBox.TextChanged += new System.EventHandler(this.heightMaxFtTextBox_TextChanged);
            // 
            // heightMaxLabel
            // 
            this.heightMaxLabel.BackColor = System.Drawing.Color.Black;
            this.heightMaxLabel.ForeColor = System.Drawing.Color.White;
            this.heightMaxLabel.Location = new System.Drawing.Point(52, 227);
            this.heightMaxLabel.Name = "heightMaxLabel";
            this.heightMaxLabel.Size = new System.Drawing.Size(96, 20);
            this.heightMaxLabel.Text = "Height Maximum";
            // 
            // hairLabel
            // 
            this.hairLabel.BackColor = System.Drawing.Color.Black;
            this.hairLabel.ForeColor = System.Drawing.Color.White;
            this.hairLabel.Location = new System.Drawing.Point(96, 321);
            this.hairLabel.Name = "hairLabel";
            this.hairLabel.Size = new System.Drawing.Size(29, 20);
            this.hairLabel.Text = "Hair";
            // 
            // weightMaxTextBox
            // 
            this.weightMaxTextBox.Location = new System.Drawing.Point(151, 289);
            this.weightMaxTextBox.Name = "weightMaxTextBox";
            this.weightMaxTextBox.Size = new System.Drawing.Size(35, 21);
            this.weightMaxTextBox.TabIndex = 45;
            this.weightMaxTextBox.TextChanged += new System.EventHandler(this.weightMaxTextBox_TextChanged);
            // 
            // weightMaxLabel
            // 
            this.weightMaxLabel.BackColor = System.Drawing.Color.Black;
            this.weightMaxLabel.ForeColor = System.Drawing.Color.White;
            this.weightMaxLabel.Location = new System.Drawing.Point(48, 290);
            this.weightMaxLabel.Name = "weightMaxLabel";
            this.weightMaxLabel.Size = new System.Drawing.Size(100, 20);
            this.weightMaxLabel.Text = "Weight Maximum";
            // 
            // weightMinTextBox
            // 
            this.weightMinTextBox.Location = new System.Drawing.Point(151, 258);
            this.weightMinTextBox.Name = "weightMinTextBox";
            this.weightMinTextBox.Size = new System.Drawing.Size(35, 21);
            this.weightMinTextBox.TabIndex = 44;
            this.weightMinTextBox.TextChanged += new System.EventHandler(this.weightMinTextBox_TextChanged);
            // 
            // weightMinLabel
            // 
            this.weightMinLabel.BackColor = System.Drawing.Color.Black;
            this.weightMinLabel.ForeColor = System.Drawing.Color.White;
            this.weightMinLabel.Location = new System.Drawing.Point(50, 259);
            this.weightMinLabel.Name = "weightMinLabel";
            this.weightMinLabel.Size = new System.Drawing.Size(98, 20);
            this.weightMinLabel.Text = "Weight Minimum";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 390);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 20);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lbSexError
            // 
            this.lbSexError.ForeColor = System.Drawing.Color.Red;
            this.lbSexError.Location = new System.Drawing.Point(115, 39);
            this.lbSexError.Name = "lbSexError";
            this.lbSexError.Size = new System.Drawing.Size(21, 20);
            this.lbSexError.Text = "(*)";
            this.lbSexError.Visible = false;
            this.lbSexError.ParentChanged += new System.EventHandler(this.lbSexError_ParentChanged);
            // 
            // lbAgeMinError
            // 
            this.lbAgeMinError.BackColor = System.Drawing.Color.Transparent;
            this.lbAgeMinError.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMinError.Location = new System.Drawing.Point(61, 69);
            this.lbAgeMinError.Name = "lbAgeMinError";
            this.lbAgeMinError.Size = new System.Drawing.Size(21, 20);
            this.lbAgeMinError.Text = "(*)";
            this.lbAgeMinError.Visible = false;
            // 
            // lbAgeMaxError
            // 
            this.lbAgeMaxError.ForeColor = System.Drawing.Color.Red;
            this.lbAgeMaxError.Location = new System.Drawing.Point(61, 100);
            this.lbAgeMaxError.Name = "lbAgeMaxError";
            this.lbAgeMaxError.Size = new System.Drawing.Size(21, 20);
            this.lbAgeMaxError.Text = "(*)";
            this.lbAgeMaxError.Visible = false;
            // 
            // lbRangeError
            // 
            this.lbRangeError.ForeColor = System.Drawing.Color.Red;
            this.lbRangeError.Location = new System.Drawing.Point(54, 131);
            this.lbRangeError.Name = "lbRangeError";
            this.lbRangeError.Size = new System.Drawing.Size(21, 20);
            this.lbRangeError.Text = "(*)";
            this.lbRangeError.Visible = false;
            // 
            // lbRaceError
            // 
            this.lbRaceError.ForeColor = System.Drawing.Color.Red;
            this.lbRaceError.Location = new System.Drawing.Point(92, 166);
            this.lbRaceError.Name = "lbRaceError";
            this.lbRaceError.Size = new System.Drawing.Size(21, 20);
            this.lbRaceError.Text = "(*)";
            this.lbRaceError.Visible = false;
            // 
            // lbHeightMinError
            // 
            this.lbHeightMinError.ForeColor = System.Drawing.Color.Red;
            this.lbHeightMinError.Location = new System.Drawing.Point(32, 199);
            this.lbHeightMinError.Name = "lbHeightMinError";
            this.lbHeightMinError.Size = new System.Drawing.Size(21, 20);
            this.lbHeightMinError.Text = "(*)";
            this.lbHeightMinError.Visible = false;
            // 
            // lbHeightMaxError
            // 
            this.lbHeightMaxError.ForeColor = System.Drawing.Color.Red;
            this.lbHeightMaxError.Location = new System.Drawing.Point(32, 228);
            this.lbHeightMaxError.Name = "lbHeightMaxError";
            this.lbHeightMaxError.Size = new System.Drawing.Size(21, 20);
            this.lbHeightMaxError.Text = "(*)";
            this.lbHeightMaxError.Visible = false;
            // 
            // lbWeightMinError
            // 
            this.lbWeightMinError.ForeColor = System.Drawing.Color.Red;
            this.lbWeightMinError.Location = new System.Drawing.Point(29, 259);
            this.lbWeightMinError.Name = "lbWeightMinError";
            this.lbWeightMinError.Size = new System.Drawing.Size(21, 20);
            this.lbWeightMinError.Text = "(*)";
            this.lbWeightMinError.Visible = false;
            // 
            // lbWeightMaxError
            // 
            this.lbWeightMaxError.ForeColor = System.Drawing.Color.Red;
            this.lbWeightMaxError.Location = new System.Drawing.Point(28, 289);
            this.lbWeightMaxError.Name = "lbWeightMaxError";
            this.lbWeightMaxError.Size = new System.Drawing.Size(21, 20);
            this.lbWeightMaxError.Text = "(*)";
            this.lbWeightMaxError.Visible = false;
            // 
            // lbHairError
            // 
            this.lbHairError.ForeColor = System.Drawing.Color.Red;
            this.lbHairError.Location = new System.Drawing.Point(74, 321);
            this.lbHairError.Name = "lbHairError";
            this.lbHairError.Size = new System.Drawing.Size(21, 20);
            this.lbHairError.Text = "(*)";
            this.lbHairError.Visible = false;
            // 
            // txRange
            // 
            this.txRange.Location = new System.Drawing.Point(152, 127);
            this.txRange.Name = "txRange";
            this.txRange.Size = new System.Drawing.Size(61, 21);
            this.txRange.TabIndex = 177;
            this.txRange.TextChanged += new System.EventHandler(this.txRange_TextChanged);
            // 
            // raceComboBox
            // 
            this.raceComboBox.Items.Add("White");
            this.raceComboBox.Items.Add("Asian");
            this.raceComboBox.Items.Add("Latino/a");
            this.raceComboBox.Items.Add("Black");
            this.raceComboBox.Items.Add("Indian");
            this.raceComboBox.Items.Add("Native");
            this.raceComboBox.Location = new System.Drawing.Point(152, 164);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(59, 22);
            this.raceComboBox.TabIndex = 178;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged_1);
            // 
            // hairComboBox
            // 
            this.hairComboBox.Items.Add("Blonde");
            this.hairComboBox.Items.Add("Brunette");
            this.hairComboBox.Items.Add("Brown");
            this.hairComboBox.Items.Add("Red");
            this.hairComboBox.Items.Add("Other");
            this.hairComboBox.Location = new System.Drawing.Point(127, 316);
            this.hairComboBox.Name = "hairComboBox";
            this.hairComboBox.Size = new System.Drawing.Size(59, 22);
            this.hairComboBox.TabIndex = 179;
            this.hairComboBox.SelectedIndexChanged += new System.EventHandler(this.hairComboBox_SelectedIndexChanged_1);
            // 
            // lbErrorInterest
            // 
            this.lbErrorInterest.ForeColor = System.Drawing.Color.Red;
            this.lbErrorInterest.Location = new System.Drawing.Point(29, 356);
            this.lbErrorInterest.Name = "lbErrorInterest";
            this.lbErrorInterest.Size = new System.Drawing.Size(21, 20);
            this.lbErrorInterest.Text = "(*)";
            this.lbErrorInterest.Visible = false;
            // 
            // lbInterest
            // 
            this.lbInterest.BackColor = System.Drawing.Color.Black;
            this.lbInterest.ForeColor = System.Drawing.Color.White;
            this.lbInterest.Location = new System.Drawing.Point(55, 356);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(65, 20);
            this.lbInterest.Text = "Interest";
            // 
            // cbInterest
            // 
            this.cbInterest.Items.Add("Books");
            this.cbInterest.Items.Add("Music");
            this.cbInterest.Items.Add("Games");
            this.cbInterest.Items.Add("Beer");
            this.cbInterest.Location = new System.Drawing.Point(127, 354);
            this.cbInterest.Name = "cbInterest";
            this.cbInterest.Size = new System.Drawing.Size(92, 22);
            this.cbInterest.TabIndex = 182;
            this.cbInterest.SelectedIndexChanged += new System.EventHandler(this.cbInterest_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 206;
            this.btnCancel.Text = "Back";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbErrorInterest);
            this.Controls.Add(this.lbInterest);
            this.Controls.Add(this.cbInterest);
            this.Controls.Add(this.hairComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.txRange);
            this.Controls.Add(this.lbHairError);
            this.Controls.Add(this.lbWeightMaxError);
            this.Controls.Add(this.lbWeightMinError);
            this.Controls.Add(this.lbHeightMaxError);
            this.Controls.Add(this.lbHeightMinError);
            this.Controls.Add(this.lbRaceError);
            this.Controls.Add(this.lbRangeError);
            this.Controls.Add(this.lbAgeMaxError);
            this.Controls.Add(this.lbAgeMinError);
            this.Controls.Add(this.lbSexError);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.weightMaxTextBox);
            this.Controls.Add(this.weightMaxLabel);
            this.Controls.Add(this.weightMinTextBox);
            this.Controls.Add(this.weightMinLabel);
            this.Controls.Add(this.hairLabel);
            this.Controls.Add(this.ftLabel2);
            this.Controls.Add(this.heightMaxCmTextBox);
            this.Controls.Add(this.heightMaxLabel);
            this.Controls.Add(this.ftLabel1);
            this.Controls.Add(this.heightMinCmTextbox);
            this.Controls.Add(this.heightMinLabel);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.ageMaxComboBox);
            this.Controls.Add(this.ageMaxLabel);
            this.Controls.Add(this.ageMinComboBox);
            this.Controls.Add(this.ageMinLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.datePrefLabel);
            this.Menu = this.mainMenu1;
            this.Name = "DateForm";
            this.Text = "DateForm";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label datePrefLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label ageMinLabel;
        private System.Windows.Forms.TextBox ageMinComboBox;
        private System.Windows.Forms.TextBox ageMaxComboBox;
        private System.Windows.Forms.Label ageMaxLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox heightMinCmTextbox;
        private System.Windows.Forms.Label heightMinLabel;
        private System.Windows.Forms.Label ftLabel1;
        private System.Windows.Forms.Label ftLabel2;
        private System.Windows.Forms.TextBox heightMaxCmTextBox;
        private System.Windows.Forms.Label heightMaxLabel;
        private System.Windows.Forms.Label hairLabel;
        private System.Windows.Forms.TextBox weightMaxTextBox;
        private System.Windows.Forms.Label weightMaxLabel;
        private System.Windows.Forms.TextBox weightMinTextBox;
        private System.Windows.Forms.Label weightMinLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label lbSexError;
        private System.Windows.Forms.Label lbAgeMinError;
        private System.Windows.Forms.Label lbAgeMaxError;
        private System.Windows.Forms.Label lbRangeError;
        private System.Windows.Forms.Label lbRaceError;
        private System.Windows.Forms.Label lbHeightMinError;
        private System.Windows.Forms.Label lbHeightMaxError;
        private System.Windows.Forms.Label lbWeightMinError;
        private System.Windows.Forms.Label lbWeightMaxError;
        private System.Windows.Forms.Label lbHairError;
        private System.Windows.Forms.TextBox txRange;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox hairComboBox;
        private System.Windows.Forms.Label lbErrorInterest;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.ComboBox cbInterest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}