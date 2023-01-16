using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleCalandarClientLib;

namespace DllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleCalandarClient client = new GoogleCalandarClient();
            client.Initial("calendarapitest@window10-259107.iam.gserviceaccount.com", "C:\\Users\\BreezeCat\\Downloads\\window10-259107-3a5e3dd1d610.json");
            SelfDefineEvent newevent = new SelfDefineEvent();
            newevent.Summary = "Client Pub";
            newevent.Description = "From Client";
            newevent.Start = DateTime.Now;
            newevent.End = DateTime.Now.AddHours(1);
            client.CreateEvent("2f608fbf267ca8958152cd93a97aaa70b551f4ec93cd6017f1e19f301fbcc924@group.calendar.google.com", newevent);
            Console.ReadKey();
            client.GetList("2f608fbf267ca8958152cd93a97aaa70b551f4ec93cd6017f1e19f301fbcc924@group.calendar.google.com");

        }
    }
}
