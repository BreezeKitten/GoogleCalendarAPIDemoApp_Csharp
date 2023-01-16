namespace GoogleCalenderDemoApp
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TargetCalendarID = new System.Windows.Forms.TextBox();
            this.tb_ServiceAccountCertPath = new System.Windows.Forms.TextBox();
            this.tb_ServiceAccountEmail = new System.Windows.Forms.TextBox();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服務帳戶Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "服務帳戶憑證路徑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "目標日曆ID";
            // 
            // tb_TargetCalendarID
            // 
            this.tb_TargetCalendarID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GoogleCalenderDemoApp.Properties.Settings.Default, "TargetCalendarID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_TargetCalendarID.Location = new System.Drawing.Point(15, 112);
            this.tb_TargetCalendarID.Name = "tb_TargetCalendarID";
            this.tb_TargetCalendarID.Size = new System.Drawing.Size(396, 22);
            this.tb_TargetCalendarID.TabIndex = 5;
            this.tb_TargetCalendarID.Text = global::GoogleCalenderDemoApp.Properties.Settings.Default.TargetCalendarID;
            // 
            // tb_ServiceAccountCertPath
            // 
            this.tb_ServiceAccountCertPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GoogleCalenderDemoApp.Properties.Settings.Default, "ServiceAccountCertPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_ServiceAccountCertPath.Location = new System.Drawing.Point(15, 72);
            this.tb_ServiceAccountCertPath.Name = "tb_ServiceAccountCertPath";
            this.tb_ServiceAccountCertPath.Size = new System.Drawing.Size(396, 22);
            this.tb_ServiceAccountCertPath.TabIndex = 4;
            this.tb_ServiceAccountCertPath.Text = global::GoogleCalenderDemoApp.Properties.Settings.Default.ServiceAccountCertPath;
            // 
            // tb_ServiceAccountEmail
            // 
            this.tb_ServiceAccountEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GoogleCalenderDemoApp.Properties.Settings.Default, "ServiceAccountEmail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_ServiceAccountEmail.Location = new System.Drawing.Point(15, 29);
            this.tb_ServiceAccountEmail.Name = "tb_ServiceAccountEmail";
            this.tb_ServiceAccountEmail.Size = new System.Drawing.Size(396, 22);
            this.tb_ServiceAccountEmail.TabIndex = 3;
            this.tb_ServiceAccountEmail.Text = global::GoogleCalenderDemoApp.Properties.Settings.Default.ServiceAccountEmail;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(336, 147);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 6;
            this.bt_Close.Text = "完成";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 182);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.tb_TargetCalendarID);
            this.Controls.Add(this.tb_ServiceAccountCertPath);
            this.Controls.Add(this.tb_ServiceAccountEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ServiceAccountEmail;
        private System.Windows.Forms.TextBox tb_ServiceAccountCertPath;
        private System.Windows.Forms.TextBox tb_TargetCalendarID;
        private System.Windows.Forms.Button bt_Close;
    }
}