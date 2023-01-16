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

        private void UpdateEventIDList()
        {
            List<string> idList = client.GetList(Properties.Settings.Default.TargetCalendarID);
            cb_EventID.Items.Clear();
            foreach (string id in idList)
            {
                cb_EventID.Items.Add(id);
            }
            if (cb_EventID.Items.Count > 0)
            {
                cb_EventID.SelectedIndex = 0;
            }
            else
            {
                cb_EventID.Text = "";
            }
        }

        private void UpdateReadEvent(string id)
        {
            SelfDefineEvent ReadResult;
            if( client.GetEvent(Properties.Settings.Default.TargetCalendarID, id, out ReadResult) == true)
            {
                tb_ReadID.Text = id;
                tb_EventSummary.Text = ReadResult.Summary;
                rtb_EventDescription.Text = ReadResult.Description;
                //dtp_EventStartTime.Value = ReadResult.Start;
                //dtp_EventEndTime.Value = ReadResult.End;
            }
        }

        private void bt_InitalClient_Click(object sender, EventArgs e)
        {
            InitialService();
            UpdateInitialStatus();
        }

        private void bt_ShowAllEvent_Click(object sender, EventArgs e)
        {
            UpdateEventIDList();
        }

        private void bt_DelEvent_Click(object sender, EventArgs e)
        {
            client.DelEvent(Properties.Settings.Default.TargetCalendarID, cb_EventID.Text);
            UpdateEventIDList();
        }

        private void tsb_Setting_Click(object sender, EventArgs e)
        {
            Form Setting = new SettingForm();
            Setting.Show();
        }

        private void cb_EventID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cb_EventID.Text != "")
            {
                UpdateReadEvent(cb_EventID.Text);
            }
        }
    }
}
