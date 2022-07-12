
namespace PerfectCover4PetsMH.screens
{
    partial class frmHolderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolderDetails));
            this.btnMenuBackHolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerNumberYears = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerHolder = new System.Windows.Forms.Timer(this.components);
            this.btnAcceptHolder = new PerfectCover4PetsMH.components.ButtonCircle();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStartingDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuBackHolder
            // 
            this.btnMenuBackHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBackHolder.Location = new System.Drawing.Point(534, 392);
            this.btnMenuBackHolder.Name = "btnMenuBackHolder";
            this.btnMenuBackHolder.Size = new System.Drawing.Size(93, 40);
            this.btnMenuBackHolder.TabIndex = 12;
            this.btnMenuBackHolder.Text = "Menu";
            this.btnMenuBackHolder.UseVisualStyleBackColor = true;
            this.btnMenuBackHolder.Click += new System.EventHandler(this.btnMenuBackHolder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dateTimePickerStartingDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAcceptHolder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePickerNumberYears);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 350);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 61);
            this.label5.TabIndex = 8;
            this.label5.Text = "Holder Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 136);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 85);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePickerNumberYears
            // 
            this.dateTimePickerNumberYears.Location = new System.Drawing.Point(120, 255);
            this.dateTimePickerNumberYears.MaxDate = new System.DateTime(2022, 5, 17, 16, 42, 33, 0);
            this.dateTimePickerNumberYears.MinDate = new System.DateTime(2016, 5, 5, 0, 0, 0, 0);
            this.dateTimePickerNumberYears.Name = "dateTimePickerNumberYears";
            this.dateTimePickerNumberYears.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNumberYears.TabIndex = 10;
            this.dateTimePickerNumberYears.Value = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "When the client joined the insurance company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIrst Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(451, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timerHolder
            // 
            this.timerHolder.Interval = 1000;
            this.timerHolder.Tick += new System.EventHandler(this.timerHolder_Tick);
            // 
            // btnAcceptHolder
            // 
            this.btnAcceptHolder.BackColor = System.Drawing.Color.Red;
            this.btnAcceptHolder.Enabled = false;
            this.btnAcceptHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptHolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcceptHolder.Location = new System.Drawing.Point(489, 205);
            this.btnAcceptHolder.Name = "btnAcceptHolder";
            this.btnAcceptHolder.Size = new System.Drawing.Size(120, 120);
            this.btnAcceptHolder.TabIndex = 11;
            this.btnAcceptHolder.Text = "Accept";
            this.btnAcceptHolder.UseVisualStyleBackColor = false;
            this.btnAcceptHolder.Click += new System.EventHandler(this.btnAcceptHolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Policy Start Date";
            // 
            // dateTimePickerStartingDate
            // 
            this.dateTimePickerStartingDate.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateTimePickerStartingDate.CalendarTitleBackColor = System.Drawing.Color.LightSalmon;
            this.dateTimePickerStartingDate.Location = new System.Drawing.Point(276, 136);
            this.dateTimePickerStartingDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartingDate.MinDate = new System.DateTime(2022, 5, 17, 16, 41, 28, 0);
            this.dateTimePickerStartingDate.Name = "dateTimePickerStartingDate";
            this.dateTimePickerStartingDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartingDate.TabIndex = 9;
            this.dateTimePickerStartingDate.Value = new System.DateTime(2022, 5, 17, 16, 44, 2, 0);
            // 
            // frmHolderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenuBackHolder);
            this.Name = "frmHolderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holder Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuBackHolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNumberYears;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private components.ButtonCircle btnAcceptHolder;
        private System.Windows.Forms.Timer timerHolder;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartingDate;
        private System.Windows.Forms.Label label4;
    }
}