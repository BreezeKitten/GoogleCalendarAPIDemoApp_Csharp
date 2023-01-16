using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Google.Apis.Calendar.v3.Data;

namespace GoogleCalandarClientLib
{
    public enum LoginAccountType
    {
        ServiceAccount,
        UserAccount,
    }

    public class SelfDefineEvent
    {
        public string Summary = "";
        public string Description = "";
        public DateTime Start;
        public DateTime End;
    }

    public class GoogleCalandarClient
    {
        CalendarService MainService;
        LoginAccountType m_AccountType = LoginAccountType.ServiceAccount;
        string[] m_Scope = new string[3] { "https://www.googleapis.com/auth/calendar",
                                                "https://www.googleapis.com/auth/calendar.events",
                                                "https://www.googleapis.com/auth/calendar.events.readonly" };
        bool m_Initialized = false;

        public GoogleCalandarClient(LoginAccountType type = LoginAccountType.ServiceAccount)
        {
            m_AccountType = LoginAccountType.ServiceAccount;
        }

        public bool Initial(string name, string file)
        {
            bool initial_result = false;
            switch (m_AccountType)
            {
                case LoginAccountType.ServiceAccount:
                    initial_result =  Initial_WithServiceAccount(name, file);
                    break;

                case LoginAccountType.UserAccount:
                    initial_result = Initial_WithServiceAccount(name, file);
                    break;

                default:
                    initial_result = false;
                    break;
            }
            m_Initialized = initial_result;
            return initial_result;
        }

        public void CreateEvent(string TargetcalendarID, SelfDefineEvent newevent)
        {
            if( m_Initialized == false)
            {
                Console.WriteLine("Not Initialized");
                return;
            }

            Event newEvent = new Event()
            {
                Summary = newevent.Summary,
                Description = newevent.Description,
                Start = new EventDateTime()
                {
                    DateTime = newevent.Start,
                    TimeZone = "Asia/Taipei",
                },
                End = new EventDateTime()
                {
                    DateTime = newevent.End,
                    TimeZone = "Asia/Taipei",
                },
            };

            String calendarId = TargetcalendarID;
            EventsResource.InsertRequest request = MainService.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
        }

        private bool Initial_WithServiceAccount(string accountmail, string jsonfile)
        {
            try
            {
                MainService = AuthenticateServiceAccount(accountmail, jsonfile, m_Scope);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Initial ServiceAccount Ex - " + ex.Message);
                return false;
            }
           
        }

        private bool Initial_WithUserAccount(string username, string clientSecretJson)
        {
            return false;
        }

        private static CalendarService AuthenticateServiceAccount(string serviceAccountEmail, string serviceAccountCredentialFilePath, string[] scopes)
        {
            try
            {
                if (string.IsNullOrEmpty(serviceAccountCredentialFilePath))
                    throw new Exception("Path to the service account credentials file is required.");
                if (!File.Exists(serviceAccountCredentialFilePath))
                    throw new Exception("The service account credentials file does not exist at: " + serviceAccountCredentialFilePath);
                if (string.IsNullOrEmpty(serviceAccountEmail))
                    throw new Exception("ServiceAccountEmail is required.");

                // For Json file
                if (Path.GetExtension(serviceAccountCredentialFilePath).ToLower() == ".json")
                {
                    GoogleCredential credential;
                    using (var stream = new FileStream(serviceAccountCredentialFilePath, FileMode.Open, FileAccess.Read))
                    {
                        credential = GoogleCredential.FromStream(stream)
                             .CreateScoped(scopes);
                    }

                    // Create the  Analytics service.
                    return new CalendarService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Calendar Service account Authentication Sample",
                    });
                }
                /*else if (Path.GetExtension(serviceAccountCredentialFilePath).ToLower() == ".p12")
                {   // If its a P12 file

                    var certificate = new X509Certificate2(serviceAccountCredentialFilePath, "notasecret", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable);
                    var credential = new ServiceAccountCredential(new ServiceAccountCredential.Initializer(serviceAccountEmail)
                    {
                        Scopes = scopes
                    }.FromCertificate(certificate));

                    // Create the  Calendar service.
                    return new CalendarService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Calendar Authentication Sample",
                    });
                }*/
                else
                {
                    throw new Exception("Unsupported Service accounts credentials.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("CreateServiceAccountCalendarFailed", ex);
            }
        }
    }

}

