namespace DentalClinic
{
    partial class AddCheckUpcs
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
            this.label8 = new System.Windows.Forms.Label();
            this.DGVPatient = new System.Windows.Forms.DataGridView();
            this.LblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.TbxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.TbxCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(22, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 14);
            this.label8.TabIndex = 96;
            this.label8.Text = "Double-click on a row in the DataGridView to select the person for a checkup";
            // 
            // DGVPatient
            // 
            this.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatient.Location = new System.Drawing.Point(21, 69);
            this.DGVPatient.Name = "DGVPatient";
            this.DGVPatient.Size = new System.Drawing.Size(747, 211);
            this.DGVPatient.TabIndex = 95;
            this.DGVPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatient_CellContentClick);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(101, 292);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(30, 25);
            this.LblId.TabIndex = 100;
            this.LblId.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "ID:";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxName.Location = new System.Drawing.Point(106, 329);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(218, 32);
            this.TbxName.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Type:";
            // 
            // CbxType
            // 
            this.CbxType.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.CbxType.FormattingEnabled = true;
            this.CbxType.Items.AddRange(new object[] {
            "Dental Cleanings",
            "Dental Exams",
            "Fillings",
            "Crowns",
            "Bridges",
            "Dentures",
            "Braces",
            "Retainers",
            "Teeth Whitening",
            "Veneers",
            "Tooth Extractions"});
            this.CbxType.Location = new System.Drawing.Point(106, 385);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(218, 33);
            this.CbxType.TabIndex = 102;
            this.CbxType.TextChanged += new System.EventHandler(this.CbxType_TextChanged);
            this.CbxType.MouseLeave += new System.EventHandler(this.CbxType_MouseLeave);
            // 
            // TbxCost
            // 
            this.TbxCost.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxCost.Location = new System.Drawing.Point(482, 328);
            this.TbxCost.Name = "TbxCost";
            this.TbxCost.ReadOnly = true;
            this.TbxCost.Size = new System.Drawing.Size(218, 32);
            this.TbxCost.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cost: ";
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.Blue;
            this.BtnDone.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDone.Location = new System.Drawing.Point(637, 495);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(131, 42);
            this.BtnDone.TabIndex = 105;
            this.BtnDone.Text = "DONE";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // TbxCash
            // 
            this.TbxCash.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.TbxCash.Location = new System.Drawing.Point(482, 381);
            this.TbxCash.Name = "TbxCash";
            this.TbxCash.Size = new System.Drawing.Size(218, 32);
            this.TbxCash.TabIndex = 107;
            this.TbxCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxCash_KeyDown);
            this.TbxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCash_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 106;
            this.label4.Text = "Cash: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(398, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "Change: ";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Image = global::DentalClinic.Properties.Resources.back;
            this.BtnBack.Location = new System.Drawing.Point(1, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(38, 23);
            this.BtnBack.TabIndex = 110;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(322, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 111;
            this.label6.Text = "CHECK UP";
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.ForeColor = System.Drawing.Color.White;
            this.LblChange.Location = new System.Drawing.Point(480, 434);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(63, 25);
            this.LblChange.TabIndex = 112;
            this.LblChange.Text = "Pesos";
            // 
            // AddCheckUpcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxCash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.TbxCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGVPatient);
            this.Name = "AddCheckUpcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCheckUpcs";
            this.Load += new System.EventHandler(this.AddCheckUpcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVPatient;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.TextBox TbxCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.TextBox TbxCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblChange;
    }
}