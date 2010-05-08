namespace NoIdeas.Phone
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.namelabel = new System.Windows.Forms.Label();
            this.percentlabel = new System.Windows.Forms.Label();
            this.resultslabel = new System.Windows.Forms.Label();
            this.Homebutton = new System.Windows.Forms.Button();
            this.resultslistbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.BackColor = System.Drawing.Color.Black;
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(45, 34);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(51, 20);
            this.namelabel.Text = "Name";
            // 
            // percentlabel
            // 
            this.percentlabel.BackColor = System.Drawing.Color.Black;
            this.percentlabel.ForeColor = System.Drawing.Color.White;
            this.percentlabel.Location = new System.Drawing.Point(144, 34);
            this.percentlabel.Name = "percentlabel";
            this.percentlabel.Size = new System.Drawing.Size(76, 20);
            this.percentlabel.Text = "% Match";
            // 
            // resultslabel
            // 
            this.resultslabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.resultslabel.ForeColor = System.Drawing.Color.White;
            this.resultslabel.Location = new System.Drawing.Point(54, 10);
            this.resultslabel.Name = "resultslabel";
            this.resultslabel.Size = new System.Drawing.Size(134, 24);
            this.resultslabel.Text = "Your Match Results";
            // 
            // Homebutton
            // 
            this.Homebutton.Location = new System.Drawing.Point(78, 205);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(85, 24);
            this.Homebutton.TabIndex = 22;
            this.Homebutton.Text = "Home";
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // resultslistbox
            // 
            this.resultslistbox.Items.Add("TEST");
            this.resultslistbox.Location = new System.Drawing.Point(20, 57);
            this.resultslistbox.Name = "resultslistbox";
            this.resultslistbox.Size = new System.Drawing.Size(204, 142);
            this.resultslistbox.TabIndex = 26;
            this.resultslistbox.SelectedIndexChanged += new System.EventHandler(this.resultslistbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultslistbox);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.resultslabel);
            this.Controls.Add(this.percentlabel);
            this.Controls.Add(this.namelabel);
            this.Menu = this.mainMenu1;
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label percentlabel;
        private System.Windows.Forms.Label resultslabel;
        private System.Windows.Forms.Button Homebutton;
        private System.Windows.Forms.ListBox resultslistbox;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}