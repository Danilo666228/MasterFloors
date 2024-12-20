namespace MasterFloor.Forms
{
    partial class AddPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartner));
            this.numericPartnerRating = new System.Windows.Forms.NumericUpDown();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.cmbPartnerType = new System.Windows.Forms.ComboBox();
            this.txbPartnerDirector = new System.Windows.Forms.TextBox();
            this.txbPartnerPhone = new System.Windows.Forms.TextBox();
            this.txbPartnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTaxpayeer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPartnerRating
            // 
            this.numericPartnerRating.Location = new System.Drawing.Point(141, 206);
            this.numericPartnerRating.Name = "numericPartnerRating";
            this.numericPartnerRating.Size = new System.Drawing.Size(120, 20);
            this.numericPartnerRating.TabIndex = 9;
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.Location = new System.Drawing.Point(508, 380);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(143, 44);
            this.btnEditPartner.TabIndex = 8;
            this.btnEditPartner.Text = "Добавить";
            this.btnEditPartner.UseVisualStyleBackColor = true;
            this.btnEditPartner.Click += new System.EventHandler(this.btnEditPartner_Click);
            // 
            // cmbPartnerType
            // 
            this.cmbPartnerType.FormattingEnabled = true;
            this.cmbPartnerType.Location = new System.Drawing.Point(140, 26);
            this.cmbPartnerType.Name = "cmbPartnerType";
            this.cmbPartnerType.Size = new System.Drawing.Size(121, 21);
            this.cmbPartnerType.TabIndex = 7;
            // 
            // txbPartnerDirector
            // 
            this.txbPartnerDirector.Location = new System.Drawing.Point(140, 165);
            this.txbPartnerDirector.Name = "txbPartnerDirector";
            this.txbPartnerDirector.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerDirector.TabIndex = 4;
            // 
            // txbPartnerPhone
            // 
            this.txbPartnerPhone.Location = new System.Drawing.Point(140, 121);
            this.txbPartnerPhone.Name = "txbPartnerPhone";
            this.txbPartnerPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerPhone.TabIndex = 5;
            // 
            // txbPartnerName
            // 
            this.txbPartnerName.Location = new System.Drawing.Point(140, 75);
            this.txbPartnerName.Name = "txbPartnerName";
            this.txbPartnerName.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя партнера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Директор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Рейтинг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип партнера";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(141, 247);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ИНН";
            // 
            // txbTaxpayeer
            // 
            this.txbTaxpayeer.Location = new System.Drawing.Point(141, 281);
            this.txbTaxpayeer.Name = "txbTaxpayeer";
            this.txbTaxpayeer.Size = new System.Drawing.Size(100, 20);
            this.txbTaxpayeer.TabIndex = 4;
            // 
            // AddPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericPartnerRating);
            this.Controls.Add(this.btnEditPartner);
            this.Controls.Add(this.cmbPartnerType);
            this.Controls.Add(this.txbTaxpayeer);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPartnerDirector);
            this.Controls.Add(this.txbPartnerPhone);
            this.Controls.Add(this.txbPartnerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPartner";
            this.Text = "AddPartner";
            this.Activated += new System.EventHandler(this.AddPartner_Activated);
            this.Load += new System.EventHandler(this.AddPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericPartnerRating;
        private System.Windows.Forms.Button btnEditPartner;
        private System.Windows.Forms.ComboBox cmbPartnerType;
        private System.Windows.Forms.TextBox txbPartnerDirector;
        private System.Windows.Forms.TextBox txbPartnerPhone;
        private System.Windows.Forms.TextBox txbPartnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTaxpayeer;
    }
}