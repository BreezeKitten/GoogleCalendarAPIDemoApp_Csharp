using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoogleCalandarClientLib;

namespace GoogleCalenderDemoApp
{
    public partial class DemoApp : Form
    {
        GoogleCalandarClient client = new GoogleCalandarClient();

        public DemoApp()
        {
            InitializeComponent();
            UpdateInitialStatus();
        }

        private void UpdateInitialStatus()
        {
            if (client.m_Initialized == true)
            {
                lb_InitialStatus.Text = "初始化完成";
                lb_InitialStatus.ForeColor = Color.Green;
            }
            else
            {
                lb_InitialStatus.Text = "未初始化";
                lb_InitialStatus.ForeColor = Color.Red;
            }
        }

        private void InitialService()
        {
            client.Initial(Properties.Settings.Default.ServiceAccountEmail, Properties.Settings.Default.ServiceAccountCertPath);            
        }

        private void bt_InitalClient_Click(object sender, EventArgs e)
        {
            InitialService();
            UpdateInitialStatus();
        }

        private void bt_ShowAllEvent_Click(object sender, EventArgs e)
        {
            List<string> idList = client.GetList(Properties.Settings.Default.TargetCalendarID);
            foreach(string id in idList)
            {
                Console.WriteLine(id);
            }            
        }

        private void bt_DelEvent_Click(object sender, EventArgs e)
        {
            client.DelEvent(Properties.Settings.Default.TargetCalendarID,
                tb_EventID.Text);
        }

        private void tsb_Setting_Click(object sender, EventArgs e)
        {
            Form Setting = new SettingForm();
            Setting.Show();
        }
    }
}
