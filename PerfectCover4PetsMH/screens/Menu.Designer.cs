
namespace PerfectCover4PetsMH
{
    partial class frmMenuStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuStart));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewQuote = new PerfectCover4PetsMH.components.ButtonCircle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuotes
            // 
            this.btnQuotes.BackColor = System.Drawing.Color.White;
            this.btnQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotes.Location = new System.Drawing.Point(12, 201);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(127, 77);
            this.btnQuotes.TabIndex = 2;
            this.btnQuotes.Text = "Open Quotes";
            this.btnQuotes.UseVisualStyleBackColor = false;
            this.btnQuotes.Click += new System.EventHandler(this.btnQuotes_Click);
            this.btnQuotes.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // btnNewQuote
            // 
            this.btnNewQuote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewQuote.BackgroundImage")));
            this.btnNewQuote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuote.ForeColor = System.Drawing.Color.Red;
            this.btnNewQuote.Location = new System.Drawing.Point(339, 157);
            this.btnNewQuote.Name = "btnNewQuote";
            this.btnNewQuote.Size = new System.Drawing.Size(171, 141);
            this.btnNewQuote.TabIndex = 1;
            this.btnNewQuote.Text = "START NEW QUOTE";
            this.btnNewQuote.UseVisualStyleBackColor = true;
            this.btnNewQuote.Click += new System.EventHandler(this.btnNewQuote_Click);
            // 
            // frmMenuStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewQuote);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuotes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.Button btnExit;
        private components.ButtonCircle btnNewQuote;
    }
}

