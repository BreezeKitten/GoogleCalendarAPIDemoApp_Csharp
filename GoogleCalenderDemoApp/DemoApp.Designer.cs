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
            this.tb_EventID = new System.Windows.Forms.TextBox();
            this.bt_DelEvent = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Setting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
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
            this.bt_ShowAllEvent.Location = new System.Drawing.Point(183, 86);
            this.bt_ShowAllEvent.Name = "bt_ShowAllEvent";
            this.bt_ShowAllEvent.Size = new System.Drawing.Size(75, 23);
            this.bt_ShowAllEvent.TabIndex = 2;
            this.bt_ShowAllEvent.Text = "事件ID";
            this.bt_ShowAllEvent.UseVisualStyleBackColor = true;
            this.bt_ShowAllEvent.Click += new System.EventHandler(this.bt_ShowAllEvent_Click);
            // 
            // tb_EventID
            // 
            this.tb_EventID.Location = new System.Drawing.Point(12, 57);
            this.tb_EventID.Name = "tb_EventID";
            this.tb_EventID.Size = new System.Drawing.Size(165, 22);
            this.tb_EventID.TabIndex = 3;
            // 
            // bt_DelEvent
            // 
            this.bt_DelEvent.Location = new System.Drawing.Point(183, 57);
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // DemoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bt_DelEvent);
            this.Controls.Add(this.tb_EventID);
            this.Controls.Add(this.bt_ShowAllEvent);
            this.Controls.Add(this.bt_InitalClient);
            this.Controls.Add(this.lb_InitialStatus);
            this.Name = "DemoApp";
            this.Text = "DemoApp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_InitialStatus;
        private System.Windows.Forms.Button bt_InitalClient;
        private System.Windows.Forms.Button bt_ShowAllEvent;
        private System.Windows.Forms.TextBox tb_EventID;
        private System.Windows.Forms.Button bt_DelEvent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Setting;
    }
}

