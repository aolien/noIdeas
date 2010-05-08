namespace NoIdeas.Phone
{
    partial class Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.textlabel = new System.Windows.Forms.Label();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // textlabel
            // 
            this.textlabel.BackColor = System.Drawing.Color.Black;
            this.textlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textlabel.ForeColor = System.Drawing.Color.White;
            this.textlabel.Location = new System.Drawing.Point(65, 12);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(136, 24);
            this.textlabel.Text = "Text Your Match";
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(21, 39);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(204, 79);
            this.messageTB.TabIndex = 2;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(91, 124);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(72, 20);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Send Text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Text";
            this.Text = "Text";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}