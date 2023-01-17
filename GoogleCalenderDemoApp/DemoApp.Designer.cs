namespace GoogleCalenderDemoApp
{
    partial class DemoApp
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoApp));
            this.lb_InitialStatus = new System.Windows.Forms.Label();
            this.bt_InitalClient = new System.Windows.Forms.Button();
            this.bt_ShowAllEvent = new System.Windows.Forms.Button();
            this.bt_DelEvent = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Setting = new System.Windows.Forms.ToolStripButton();
            this.cb_EventID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_AddEvent = new System.Windows.Forms.Button();
            this.dtp_EventEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_EventStartTime = new System.Windows.Forms.DateTimePicker();
            this.tb_ReadID = new System.Windows.Forms.TextBox();
            this.rtb_EventDescription = new System.Windows.Forms.RichTextBox();
            this.tb_EventSummary = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_InitialStatus
            // 
            this.lb_InitialStatus.AutoSize = true;
            this.lb_InitialStatus.Location = new System.Drawing.Point(12, 33);
            this.lb_InitialStatus.Name = "lb_InitialStatus";
            this.lb_InitialStatus.Size = new System.Drawing.Size(53, 12);
            this.lb_InitialStatus.TabIndex = 0;
            this.lb_InitialStatus.Text = "未初始化";
            // 
            // bt_InitalClient
            // 
            this.bt_InitalClient.Location = new System.Drawing.Point(71, 28);
            this.bt_InitalClient.Name = "bt_InitalClient";
            this.bt_InitalClient.Size = new System.Drawing.Size(75, 23);
            this.bt_InitalClient.TabIndex = 1;
            this.bt_InitalClient.Text = "初始化";
            this.bt_InitalClient.UseVisualStyleBackColor = true;
            this.bt_InitalClient.Click += new System.EventHandler(this.bt_InitalClient_Click);
            // 
            // bt_ShowAllEvent
            // 
            this.bt_ShowAllEvent.Location = new System.Drawing.Point(183, 58);
            this.bt_ShowAllEvent.Name = "bt_ShowAllEvent";
            this.bt_ShowAllEvent.Size = new System.Drawing.Size(75, 23);
            this.bt_ShowAllEvent.TabIndex = 2;
            this.bt_ShowAllEvent.Text = "事件ID";
            this.bt_ShowAllEvent.UseVisualStyleBackColor = true;
            this.bt_ShowAllEvent.Click += new System.EventHandler(this.bt_ShowAllEvent_Click);
            // 
            // bt_DelEvent
            // 
            this.bt_DelEvent.Location = new System.Drawing.Point(14, 86);
            this.bt_DelEvent.Name = "bt_DelEvent";
            this.bt_DelEvent.Size = new System.Drawing.Size(75, 23);
            this.bt_DelEvent.TabIndex = 4;
            this.bt_DelEvent.Text = "刪除";
            this.bt_DelEvent.UseVisualStyleBackColor = true;
            this.bt_DelEvent.Click += new System.EventHandler(this.bt_DelEvent_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Setting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(280, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Setting
            // 
            this.tsb_Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Setting.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Setting.Image")));
            this.tsb_Setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Setting.Name = "tsb_Setting";
            this.tsb_Setting.Size = new System.Drawing.Size(35, 22);
            this.tsb_Setting.Text = "設定";
            this.tsb_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsb_Setting.Click += new System.EventHandler(this.tsb_Setting_Click);
            // 
            // cb_EventID
            // 
            this.cb_EventID.FormattingEnabled = true;
            this.cb_EventID.Location = new System.Drawing.Point(12, 60);
            this.cb_EventID.Name = "cb_EventID";
            this.cb_EventID.Size = new System.Drawing.Size(165, 20);
            this.cb_EventID.TabIndex = 6;
            this.cb_EventID.SelectedIndexChanged += new System.EventHandler(this.cb_EventID_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_AddEvent);
            this.groupBox1.Controls.Add(this.dtp_EventEndTime);
            this.groupBox1.Controls.Add(this.dtp_EventStartTime);
            this.groupBox1.Controls.Add(this.tb_ReadID);
            this.groupBox1.Controls.Add(this.rtb_EventDescription);
            this.groupBox1.Controls.Add(this.tb_EventSummary);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事件內容";
            // 
            // bt_AddEvent
            // 
            this.bt_AddEvent.Location = new System.Drawing.Point(165, 236);
            this.bt_AddEvent.Name = "bt_AddEvent";
            this.bt_AddEvent.Size = new System.Drawing.Size(75, 23);
            this.bt_AddEvent.TabIndex = 5;
            this.bt_AddEvent.Text = "新增";
            this.bt_AddEvent.UseVisualStyleBackColor = true;
            this.bt_AddEvent.Click += new System.EventHandler(this.bt_AddEvent_Click);
            // 
            // dtp_EventEndTime
            // 
            this.dtp_EventEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_EventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EventEndTime.Location = new System.Drawing.Point(81, 208);
            this.dtp_EventEndTime.Name = "dtp_EventEndTime";
            this.dtp_EventEndTime.Size = new System.Drawing.Size(159, 22);
            this.dtp_EventEndTime.TabIndex = 4;
            // 
            // dtp_EventStartTime
            // 
            this.dtp_EventStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_EventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EventStartTime.Location = new System.Drawing.Point(81, 180);
            this.dtp_EventStartTime.Name = "dtp_EventStartTime";
            this.dtp_EventStartTime.Size = new System.Drawing.Size(159, 22);
            this.dtp_EventStartTime.TabIndex = 3;
            // 
            // tb_ReadID
            // 
            this.tb_ReadID.Location = new System.Drawing.Point(81, 26);
            this.tb_ReadID.Name = "tb_ReadID";
            this.tb_ReadID.ReadOnly = true;
            this.tb_ReadID.Size = new System.Drawing.Size(159, 22);
            this.tb_ReadID.TabIndex = 2;
            // 
            // rtb_EventDescription
            // 
            this.rtb_EventDescription.Location = new System.Drawing.Point(81, 82);
            this.rtb_EventDescription.Name = "rtb_EventDescription";
            this.rtb_EventDescription.Size = new System.Drawing.Size(159, 92);
            this.rtb_EventDescription.TabIndex = 1;
            this.rtb_EventDescription.Text = "";
            // 
            // tb_EventSummary
            // 
            this.tb_EventSummary.Location = new System.Drawing.Point(81, 54);
            this.tb_EventSummary.Name = "tb_EventSummary";
            this.tb_EventSummary.Size = new System.Drawing.Size(159, 22);
            this.tb_EventSummary.TabIndex = 0;
            // 
            // DemoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_EventID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bt_DelEvent);
            this.Controls.Add(this.bt_ShowAllEvent);
            this.Controls.Add(this.bt_InitalClient);
            this.Controls.Add(this.lb_InitialStatus);
            this.Name = "DemoApp";
            this.Text = "DemoApp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_InitialStatus;
        private System.Windows.Forms.Button bt_InitalClient;
        private System.Windows.Forms.Button bt_ShowAllEvent;
        private System.Windows.Forms.Button bt_DelEvent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Setting;
        private System.Windows.Forms.ComboBox cb_EventID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ReadID;
        private System.Windows.Forms.RichTextBox rtb_EventDescription;
        private System.Windows.Forms.TextBox tb_EventSummary;
        private System.Windows.Forms.DateTimePicker dtp_EventStartTime;
        private System.Windows.Forms.DateTimePicker dtp_EventEndTime;
        private System.Windows.Forms.Button bt_AddEvent;
    }
}

