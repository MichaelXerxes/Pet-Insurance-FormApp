
namespace PerfectCover4PetsMH.screens
{
    partial class frmDecison
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecison));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSIngle = new PerfectCover4PetsMH.components.ButtonCircle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmBoxNumberPets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMutli = new PerfectCover4PetsMH.components.ButtonCircle();
            this.timerMultiBtn = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSIngle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single Pet";
            // 
            // btnSIngle
            // 
            this.btnSIngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSIngle.Font = new System.Drawing.Font("Franklin Gothic Medium", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIngle.ForeColor = System.Drawing.Color.Yellow;
            this.btnSIngle.Image = ((System.Drawing.Image)(resources.GetObject("btnSIngle.Image")));
            this.btnSIngle.Location = new System.Drawing.Point(57, 128);
            this.btnSIngle.Name = "btnSIngle";
            this.btnSIngle.Size = new System.Drawing.Size(250, 250);
            this.btnSIngle.TabIndex = 4;
            this.btnSIngle.Text = "One Pet";
            this.btnSIngle.UseVisualStyleBackColor = false;
            this.btnSIngle.Click += new System.EventHandler(this.btnSIngle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmBoxNumberPets);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMutli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 450);
            this.panel2.TabIndex = 1;
            // 
            // cmBoxNumberPets
            // 
            this.cmBoxNumberPets.FormattingEnabled = true;
            this.cmBoxNumberPets.Items.AddRange(new object[] {
            "Number of Pets",
            " 2 Pets",
            " 3 Pets",
            " 4 Pets",
            " 5 Pets",
            " 6 Pets",
            " 7 Pets",
            " 8 Pets",
            " 9 Pets",
            "10 Pets"});
            this.cmBoxNumberPets.Location = new System.Drawing.Point(131, 90);
            this.cmBoxNumberPets.Name = "cmBoxNumberPets";
            this.cmBoxNumberPets.Size = new System.Drawing.Size(138, 24);
            this.cmBoxNumberPets.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Two or More Pets";
            // 
            // btnMutli
            // 
            this.btnMutli.BackColor = System.Drawing.Color.Black;
            this.btnMutli.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutli.ForeColor = System.Drawing.Color.Yellow;
            this.btnMutli.Image = ((System.Drawing.Image)(resources.GetObject("btnMutli.Image")));
            this.btnMutli.Location = new System.Drawing.Point(75, 139);
            this.btnMutli.Name = "btnMutli";
            this.btnMutli.Size = new System.Drawing.Size(250, 250);
            this.btnMutli.TabIndex = 6;
            this.btnMutli.Text = "More Pets";
            this.btnMutli.UseVisualStyleBackColor = false;
            this.btnMutli.Click += new System.EventHandler(this.btnMutli_Click);
            // 
            // timerMultiBtn
            // 
            this.timerMultiBtn.Interval = 2000;
            this.timerMultiBtn.Tick += new System.EventHandler(this.timerMultiBtn_Tick);
            // 
            // frmDecison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDecison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decison";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private components.ButtonCircle btnSIngle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmBoxNumberPets;
        private System.Windows.Forms.Label label2;
        private components.ButtonCircle btnMutli;
        private System.Windows.Forms.Timer timerMultiBtn;
    }
}