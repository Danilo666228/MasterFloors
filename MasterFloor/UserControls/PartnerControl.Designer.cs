namespace MasterFloor.UserControlls
{
    partial class PartnerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPartnetType = new System.Windows.Forms.Label();
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.lblPartnerDiscount = new System.Windows.Forms.Label();
            this.lblPartnerDirector = new System.Windows.Forms.Label();
            this.lblPartnerPhone = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHistorySales = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPartnetType
            // 
            this.lblPartnetType.AutoSize = true;
            this.lblPartnetType.Location = new System.Drawing.Point(31, 28);
            this.lblPartnetType.Name = "lblPartnetType";
            this.lblPartnetType.Size = new System.Drawing.Size(43, 17);
            this.lblPartnetType.TabIndex = 0;
            this.lblPartnetType.Text = "label1";
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Location = new System.Drawing.Point(136, 28);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(43, 17);
            this.lblPartnerName.TabIndex = 0;
            this.lblPartnerName.Text = "label1";
            // 
            // lblPartnerDiscount
            // 
            this.lblPartnerDiscount.AutoSize = true;
            this.lblPartnerDiscount.Location = new System.Drawing.Point(495, 13);
            this.lblPartnerDiscount.Name = "lblPartnerDiscount";
            this.lblPartnerDiscount.Size = new System.Drawing.Size(43, 17);
            this.lblPartnerDiscount.TabIndex = 0;
            this.lblPartnerDiscount.Text = "label1";
            // 
            // lblPartnerDirector
            // 
            this.lblPartnerDirector.AutoSize = true;
            this.lblPartnerDirector.Location = new System.Drawing.Point(31, 68);
            this.lblPartnerDirector.Name = "lblPartnerDirector";
            this.lblPartnerDirector.Size = new System.Drawing.Size(43, 17);
            this.lblPartnerDirector.TabIndex = 0;
            this.lblPartnerDirector.Text = "label1";
            // 
            // lblPartnerPhone
            // 
            this.lblPartnerPhone.AutoSize = true;
            this.lblPartnerPhone.Location = new System.Drawing.Point(31, 129);
            this.lblPartnerPhone.Name = "lblPartnerPhone";
            this.lblPartnerPhone.Size = new System.Drawing.Size(43, 17);
            this.lblPartnerPhone.TabIndex = 0;
            this.lblPartnerPhone.Text = "label1";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(31, 193);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(43, 17);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "|";
            // 
            // btnHistorySales
            // 
            this.btnHistorySales.BackColor = System.Drawing.Color.LightGreen;
            this.btnHistorySales.Location = new System.Drawing.Point(449, 193);
            this.btnHistorySales.Name = "btnHistorySales";
            this.btnHistorySales.Size = new System.Drawing.Size(89, 32);
            this.btnHistorySales.TabIndex = 1;
            this.btnHistorySales.Text = "История";
            this.btnHistorySales.UseVisualStyleBackColor = false;
            this.btnHistorySales.Click += new System.EventHandler(this.btnHistorySales_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnHistorySales);
            this.panelControl.Controls.Add(this.lblRating);
            this.panelControl.Controls.Add(this.lblPartnerDiscount);
            this.panelControl.Controls.Add(this.lblPartnerPhone);
            this.panelControl.Controls.Add(this.lblPartnerDirector);
            this.panelControl.Controls.Add(this.lblPartnerName);
            this.panelControl.Controls.Add(this.lblPartnetType);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(555, 238);
            this.panelControl.TabIndex = 2;
            this.panelControl.Click += new System.EventHandler(this.panelControl_Click);
            // 
            // PartnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartnerControl";
            this.Size = new System.Drawing.Size(555, 238);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPartnetType;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.Label lblPartnerDiscount;
        private System.Windows.Forms.Label lblPartnerDirector;
        private System.Windows.Forms.Label lblPartnerPhone;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHistorySales;
        private System.Windows.Forms.Panel panelControl;
    }
}
