
namespace PerfectCover4PetsMH.screens
{
    partial class frmSummary
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
            this.btnAcceptQuote = new PerfectCover4PetsMH.components.ButtonCircle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDecline = new PerfectCover4PetsMH.components.ButtonCircle();
            this.btnBackMenu2 = new PerfectCover4PetsMH.components.ButtonCircle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceptQuote
            // 
            this.btnAcceptQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcceptQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptQuote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcceptQuote.Location = new System.Drawing.Point(618, 277);
            this.btnAcceptQuote.Name = "btnAcceptQuote";
            this.btnAcceptQuote.Size = new System.Drawing.Size(136, 123);
            this.btnAcceptQuote.TabIndex = 18;
            this.btnAcceptQuote.Text = "Accept Quote";
            this.btnAcceptQuote.UseVisualStyleBackColor = false;
            this.btnAcceptQuote.Click += new System.EventHandler(this.btnAcceptQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Quote Cost is : 0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 130);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(37, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 188);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetName,
            this.Status,
            this.PetDoB,
            this.PetBreed,
            this.PetType,
            this.PetHealth,
            this.PetTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // PetName
            // 
            this.PetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PetName.HeaderText = "Pet Name";
            this.PetName.MaxInputLength = 200;
            this.PetName.MinimumWidth = 6;
            this.PetName.Name = "PetName";
            this.PetName.ReadOnly = true;
            this.PetName.Width = 99;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // PetDoB
            // 
            this.PetDoB.HeaderText = "Pet DoB";
            this.PetDoB.MinimumWidth = 6;
            this.PetDoB.Name = "PetDoB";
            this.PetDoB.Width = 125;
            // 
            // PetBreed
            // 
            this.PetBreed.HeaderText = "Pet Breed";
            this.PetBreed.MinimumWidth = 6;
            this.PetBreed.Name = "PetBreed";
            this.PetBreed.Width = 120;
            // 
            // PetType
            // 
            this.PetType.HeaderText = "Type";
            this.PetType.MinimumWidth = 6;
            this.PetType.Name = "PetType";
            this.PetType.Width = 125;
            // 
            // PetHealth
            // 
            this.PetHealth.HeaderText = "Health";
            this.PetHealth.MinimumWidth = 6;
            this.PetHealth.Name = "PetHealth";
            this.PetHealth.Width = 150;
            // 
            // PetTotal
            // 
            this.PetTotal.HeaderText = "Total Cost";
            this.PetTotal.MinimumWidth = 6;
            this.PetTotal.Name = "PetTotal";
            this.PetTotal.Width = 125;
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.Red;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecline.Location = new System.Drawing.Point(394, 277);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(134, 123);
            this.btnDecline.TabIndex = 19;
            this.btnDecline.Text = "Decline Quote";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnBackMenu2
            // 
            this.btnBackMenu2.BackColor = System.Drawing.Color.Blue;
            this.btnBackMenu2.Enabled = false;
            this.btnBackMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackMenu2.Location = new System.Drawing.Point(509, 277);
            this.btnBackMenu2.Name = "btnBackMenu2";
            this.btnBackMenu2.Size = new System.Drawing.Size(135, 121);
            this.btnBackMenu2.TabIndex = 20;
            this.btnBackMenu2.Text = "Back Menu";
            this.btnBackMenu2.UseVisualStyleBackColor = false;
            this.btnBackMenu2.Click += new System.EventHandler(this.btnBackMenu2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date : ";
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackMenu2);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptQuote);
            this.Name = "frmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.ButtonCircle btnAcceptQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private components.ButtonCircle btnDecline;
        private components.ButtonCircle btnBackMenu2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetTotal;
        private System.Windows.Forms.Label label3;
    }
}