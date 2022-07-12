
namespace PerfectCover4PetsMH.screens
{
    partial class frmPetDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMenuBackPet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtMixedBreed = new System.Windows.Forms.RadioButton();
            this.rbtnCrossBreed = new System.Windows.Forms.RadioButton();
            this.rbtnPedigree = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewHealth = new System.Windows.Forms.DataGridView();
            this.Health = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precentHealth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.PetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.btnAcceptPet = new PerfectCover4PetsMH.components.ButtonCircle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuBackPet
            // 
            this.btnMenuBackPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBackPet.Location = new System.Drawing.Point(709, 530);
            this.btnMenuBackPet.Name = "btnMenuBackPet";
            this.btnMenuBackPet.Size = new System.Drawing.Size(127, 55);
            this.btnMenuBackPet.TabIndex = 17;
            this.btnMenuBackPet.Text = "Menu";
            this.btnMenuBackPet.UseVisualStyleBackColor = true;
            this.btnMenuBackPet.Click += new System.EventHandler(this.btnMenuBackPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pet DoB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMixedBreed);
            this.groupBox1.Controls.Add(this.rbtnCrossBreed);
            this.groupBox1.Controls.Add(this.rbtnPedigree);
            this.groupBox1.Location = new System.Drawing.Point(115, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Breed";
            // 
            // rbtMixedBreed
            // 
            this.rbtMixedBreed.AutoSize = true;
            this.rbtMixedBreed.Location = new System.Drawing.Point(6, 82);
            this.rbtMixedBreed.Name = "rbtMixedBreed";
            this.rbtMixedBreed.Size = new System.Drawing.Size(111, 21);
            this.rbtMixedBreed.TabIndex = 2;
            this.rbtMixedBreed.TabStop = true;
            this.rbtMixedBreed.Text = "Mixed Breed ";
            this.rbtMixedBreed.UseVisualStyleBackColor = true;
            // 
            // rbtnCrossBreed
            // 
            this.rbtnCrossBreed.AutoSize = true;
            this.rbtnCrossBreed.Location = new System.Drawing.Point(7, 50);
            this.rbtnCrossBreed.Name = "rbtnCrossBreed";
            this.rbtnCrossBreed.Size = new System.Drawing.Size(147, 21);
            this.rbtnCrossBreed.TabIndex = 1;
            this.rbtnCrossBreed.TabStop = true;
            this.rbtnCrossBreed.Text = "Cross Breed   +5%";
            this.rbtnCrossBreed.UseVisualStyleBackColor = true;
            // 
            // rbtnPedigree
            // 
            this.rbtnPedigree.AutoSize = true;
            this.rbtnPedigree.Location = new System.Drawing.Point(7, 22);
            this.rbtnPedigree.Name = "rbtnPedigree";
            this.rbtnPedigree.Size = new System.Drawing.Size(146, 21);
            this.rbtnPedigree.TabIndex = 0;
            this.rbtnPedigree.TabStop = true;
            this.rbtnPedigree.Text = "Pedigree      +10%";
            this.rbtnPedigree.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pet Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Health Conditions";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 37);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 80);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewHealth);
            this.panel1.Controls.Add(this.dataGridViewType);
            this.panel1.Location = new System.Drawing.Point(40, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 219);
            this.panel1.TabIndex = 9;
            // 
            // dataGridViewHealth
            // 
            this.dataGridViewHealth.AllowUserToAddRows = false;
            this.dataGridViewHealth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewHealth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewHealth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHealth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Health,
            this.precentHealth});
            this.dataGridViewHealth.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewHealth.Location = new System.Drawing.Point(310, 0);
            this.dataGridViewHealth.Name = "dataGridViewHealth";
            this.dataGridViewHealth.RowHeadersWidth = 30;
            this.dataGridViewHealth.RowTemplate.Height = 24;
            this.dataGridViewHealth.Size = new System.Drawing.Size(304, 219);
            this.dataGridViewHealth.TabIndex = 1;
            this.dataGridViewHealth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewHealth_MouseClick);
            // 
            // Health
            // 
            this.Health.HeaderText = "Health Condition";
            this.Health.MinimumWidth = 6;
            this.Health.Name = "Health";
            this.Health.Width = 125;
            // 
            // precentHealth
            // 
            this.precentHealth.HeaderText = "Precent";
            this.precentHealth.MinimumWidth = 6;
            this.precentHealth.Name = "precentHealth";
            this.precentHealth.Width = 50;
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AllowUserToAddRows = false;
            this.dataGridViewType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetType,
            this.Precent});
            this.dataGridViewType.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewType.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.RowHeadersWidth = 30;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewType.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewType.RowTemplate.Height = 24;
            this.dataGridViewType.Size = new System.Drawing.Size(301, 219);
            this.dataGridViewType.TabIndex = 0;
            this.dataGridViewType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewType_MouseClick);
            // 
            // PetType
            // 
            this.PetType.HeaderText = "Pet Type";
            this.PetType.MinimumWidth = 6;
            this.PetType.Name = "PetType";
            this.PetType.Width = 125;
            // 
            // Precent
            // 
            this.Precent.HeaderText = "Precent";
            this.Precent.MinimumWidth = 6;
            this.Precent.Name = "Precent";
            this.Precent.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pet Number 1";
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.Location = new System.Drawing.Point(388, 69);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(400, 202);
            this.labelDisplay.TabIndex = 13;
            // 
            // btnAcceptPet
            // 
            this.btnAcceptPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAcceptPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptPet.Location = new System.Drawing.Point(691, 347);
            this.btnAcceptPet.Name = "btnAcceptPet";
            this.btnAcceptPet.Size = new System.Drawing.Size(160, 154);
            this.btnAcceptPet.TabIndex = 16;
            this.btnAcceptPet.Text = "Accept Pet";
            this.btnAcceptPet.UseVisualStyleBackColor = false;
            this.btnAcceptPet.Click += new System.EventHandler(this.btnAcceptPet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAcceptPet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuBackPet);
            this.Name = "frmPetDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Details";
            this.Load += new System.EventHandler(this.frmPetDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuBackPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMixedBreed;
        private System.Windows.Forms.RadioButton rbtnCrossBreed;
        private System.Windows.Forms.RadioButton rbtnPedigree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private components.ButtonCircle btnAcceptPet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewHealth;
        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Health;
        private System.Windows.Forms.DataGridViewTextBoxColumn precentHealth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precent;
        private System.Windows.Forms.Timer timer1;
    }
}