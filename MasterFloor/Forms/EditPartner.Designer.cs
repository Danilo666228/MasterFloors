namespace MasterFloor.Forms
{
    partial class EditPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPartner));
            this.txbPartnerName = new System.Windows.Forms.TextBox();
            this.txbPartnerPhone = new System.Windows.Forms.TextBox();
            this.txbPartnerDirector = new System.Windows.Forms.TextBox();
            this.cmbPartnerType = new System.Windows.Forms.ComboBox();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.numericPartnerRating = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPartnerName
            // 
            this.txbPartnerName.Location = new System.Drawing.Point(41, 61);
            this.txbPartnerName.Name = "txbPartnerName";
            this.txbPartnerName.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerName.TabIndex = 0;
            // 
            // txbPartnerPhone
            // 
            this.txbPartnerPhone.Location = new System.Drawing.Point(41, 107);
            this.txbPartnerPhone.Name = "txbPartnerPhone";
            this.txbPartnerPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerPhone.TabIndex = 0;
            // 
            // txbPartnerDirector
            // 
            this.txbPartnerDirector.Location = new System.Drawing.Point(41, 151);
            this.txbPartnerDirector.Name = "txbPartnerDirector";
            this.txbPartnerDirector.Size = new System.Drawing.Size(100, 20);
            this.txbPartnerDirector.TabIndex = 0;
            // 
            // cmbPartnerType
            // 
            this.cmbPartnerType.FormattingEnabled = true;
            this.cmbPartnerType.Location = new System.Drawing.Point(41, 12);
            this.cmbPartnerType.Name = "cmbPartnerType";
            this.cmbPartnerType.Size = new System.Drawing.Size(121, 21);
            this.cmbPartnerType.TabIndex = 1;
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.Location = new System.Drawing.Point(86, 230);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(143, 44);
            this.btnEditPartner.TabIndex = 2;
            this.btnEditPartner.Text = "Редактировать";
            this.btnEditPartner.UseVisualStyleBackColor = true;
            this.btnEditPartner.Click += new System.EventHandler(this.btnEditPartner_Click);
            // 
            // numericPartnerRating
            // 
            this.numericPartnerRating.Location = new System.Drawing.Point(42, 192);
            this.numericPartnerRating.Name = "numericPartnerRating";
            this.numericPartnerRating.Size = new System.Drawing.Size(120, 20);
            this.numericPartnerRating.TabIndex = 3;
            // 
            // EditPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericPartnerRating);
            this.Controls.Add(this.btnEditPartner);
            this.Controls.Add(this.cmbPartnerType);
            this.Controls.Add(this.txbPartnerDirector);
            this.Controls.Add(this.txbPartnerPhone);
            this.Controls.Add(this.txbPartnerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPartner";
            this.Text = "EditPartner";
            this.Activated += new System.EventHandler(this.EditPartner_Activated);
            this.Load += new System.EventHandler(this.EditPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPartnerName;
        private System.Windows.Forms.TextBox txbPartnerPhone;
        private System.Windows.Forms.TextBox txbPartnerDirector;
        private System.Windows.Forms.ComboBox cmbPartnerType;
        private System.Windows.Forms.Button btnEditPartner;
        private System.Windows.Forms.NumericUpDown numericPartnerRating;
    }
}