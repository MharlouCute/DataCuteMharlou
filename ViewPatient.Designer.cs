namespace DentalClinic
{
    partial class ViewPatient
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
            this.CbxCivilStatus = new System.Windows.Forms.ComboBox();
            this.CbxGender = new System.Windows.Forms.ComboBox();
            this.DTPBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPatient = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxCivilStatus
            // 
            this.CbxCivilStatus.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.CbxCivilStatus.FormattingEnabled = true;
            this.CbxCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Annulled"});
            this.CbxCivilStatus.Location = new System.Drawing.Point(505, 88);
            this.CbxCivilStatus.Name = "CbxCivilStatus";
            this.CbxCivilStatus.Size = new System.Drawing.Size(218, 33);
            this.CbxCivilStatus.TabIndex = 90;
            // 
            // CbxGender
            // 
            this.CbxGender.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.CbxGender.FormattingEnabled = true;
            this.CbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CbxGender.Location = new System.Drawing.Point(124, 134);
            this.CbxGender.Name = "CbxGender";
            this.CbxGender.Size = new System.Drawing.Size(218, 33);
            this.CbxGender.TabIndex = 89;
            // 
            // DTPBirthdate
            // 
            this.DTPBirthdate.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.DTPBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthdate.Location = new System.Drawing.Point(124, 181);
            this.DTPBirthdate.Name = "DTPBirthdate";
            this.DTPBirthdate.Size = new System.Drawing.Size(218, 32);
            this.DTPBirthdate.TabIndex = 88;
            this.DTPBirthdate.ValueChanged += new System.EventHandler(this.DTPBirthdate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 87;
            this.label9.Text = "BIrthdate: ";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(104, 50);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(30, 25);
            this.LblId.TabIndex = 86;
            this.LblId.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 85;
            this.label7.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(335, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 32);
            this.label6.TabIndex = 84;
            this.label6.Text = " PATIENT";
            // 
            // TbxAddress
            // 
            this.TbxAddress.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxAddress.Location = new System.Drawing.Point(505, 132);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(218, 32);
            this.TbxAddress.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(413, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(380, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Civil Status: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Gender: ";
            // 
            // TbxContact
            // 
            this.TbxContact.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxContact.Location = new System.Drawing.Point(505, 181);
            this.TbxContact.Name = "TbxContact";
            this.TbxContact.Size = new System.Drawing.Size(218, 32);
            this.TbxContact.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Contact: ";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxName.Location = new System.Drawing.Point(124, 87);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(218, 32);
            this.TbxName.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Name: ";
            // 
            // DGVPatient
            // 
            this.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatient.Location = new System.Drawing.Point(27, 239);
            this.DGVPatient.Name = "DGVPatient";
            this.DGVPatient.Size = new System.Drawing.Size(747, 230);
            this.DGVPatient.TabIndex = 91;
            this.DGVPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatient_CellContentClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(643, 475);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(131, 42);
            this.BtnDelete.TabIndex = 92;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Blue;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(495, 475);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(131, 42);
            this.BtnUpdate.TabIndex = 93;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(28, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 14);
            this.label8.TabIndex = 94;
            this.label8.Text = "Double Click the Content in the Data Grid View to Edit and Delete";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Image = global::DentalClinic.Properties.Resources.back;
            this.BtnBack.Location = new System.Drawing.Point(1, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(38, 23);
            this.BtnBack.TabIndex = 95;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DGVPatient);
            this.Controls.Add(this.CbxCivilStatus);
            this.Controls.Add(this.CbxGender);
            this.Controls.Add(this.DTPBirthdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label1);
            this.Name = "ViewPatient";
            this.Text = "ViewPatient";
            this.Load += new System.EventHandler(this.ViewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCivilStatus;
        private System.Windows.Forms.ComboBox CbxGender;
        private System.Windows.Forms.DateTimePicker DTPBirthdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVPatient;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBack;
    }
}