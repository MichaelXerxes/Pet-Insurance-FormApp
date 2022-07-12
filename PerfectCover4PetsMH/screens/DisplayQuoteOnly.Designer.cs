
namespace PerfectCover4PetsMH.screens
{
    partial class DisplayQuoteOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuoteOnly));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHolder = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonCircle1 = new PerfectCover4PetsMH.components.ButtonCircle();
            this.lblStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHolder
            // 
            this.labelHolder.BackColor = System.Drawing.Color.Black;
            this.labelHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHolder.Location = new System.Drawing.Point(17, 15);
            this.labelHolder.Name = "labelHolder";
            this.labelHolder.Padding = new System.Windows.Forms.Padding(3);
            this.labelHolder.Size = new System.Drawing.Size(236, 231);
            this.labelHolder.TabIndex = 2;
            this.labelHolder.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 262);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(712, 180);
            this.listBox1.TabIndex = 4;
            // 
            // buttonCircle1
            // 
            this.buttonCircle1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCircle1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonCircle1.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle1.ForeColor = System.Drawing.Color.White;
            this.buttonCircle1.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle1.Image")));
            this.buttonCircle1.Location = new System.Drawing.Point(738, 171);
            this.buttonCircle1.Name = "buttonCircle1";
            this.buttonCircle1.Size = new System.Drawing.Size(161, 151);
            this.buttonCircle1.TabIndex = 23;
            this.buttonCircle1.Text = "C l o s e";
            this.buttonCircle1.UseVisualStyleBackColor = false;
            this.buttonCircle1.Click += new System.EventHandler(this.buttonCircle1_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(273, 15);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(459, 32);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "label1";
            // 
            // DisplayQuoteOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelHolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCircle1);
            this.Name = "DisplayQuoteOnly";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuoteOnly";
            this.Load += new System.EventHandler(this.DisplayQuoteOnly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private components.ButtonCircle buttonCircle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHolder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblStartDate;
    }
}