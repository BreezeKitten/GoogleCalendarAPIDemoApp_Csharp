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
        public bool m_Initialized { get; private set; } = false;

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

        public List<string> GetList(string TargetcalendarID)
        {
            List<string> EventIDList = new List<string>();
            if (m_Initialized == false)
            {
                Console.WriteLine("Not Initialized");
                return EventIDList;
            }

            EventsResource.ListRequest request = MainService.Events.List(TargetcalendarID);
            Events AllEvents = request.Execute();
            
            foreach( var item in AllEvents.Items)
            {
                EventIDList.Add(item.Id);
            }
            return EventIDList;
        }

        public void DelEvent(string TargetcalendarID, string EventID)
        {
            if (m_Initialized == false)
            {
                Console.WriteLine("Not Initialized");
                return;
            }

            EventsResource.DeleteRequest request = MainService.Events.Delete(TargetcalendarID, EventID);
            request.Execute();
        }

        public bool GetEvent(string TargetcalendarID, string EventID, out SelfDefineEvent getResult)
        {
            getResult = new SelfDefineEvent();
            if (m_Initialized == false)
            {
                Console.WriteLine("Not Initialized");
                return false;
            }

            EventsResource.GetRequest request = MainService.Events.Get(TargetcalendarID, EventID);
            Event getevent = request.Execute();
            try
            {
                getResult.Summary = getevent.Summary;
                getResult.Description = getevent.Description;
                //getResult.Start = getevent.Start.DateTime.Value;
                //getResult.End = getevent.End.DateTime.Value;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
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
            try
            {
                MainService = GetCalendarService(username, clientSecretJson, m_Scope);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Initial ServiceAccount Ex - " + ex.Message);
                return false;
            }
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

        private static CalendarService GetCalendarService(string userName, string clientSecretJson, string[] scopes)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");
                if (string.IsNullOrEmpty(clientSecretJson))
                    throw new ArgumentNullException("clientSecretJson");
                if (!File.Exists(clientSecretJson))
                    throw new Exception("clientSecretJson file does not exist.");

                var cred = GetUserCredential(clientSecretJson, userName, scopes);
                return GetService(cred);

            }
            catch (Exception ex)
            {
                throw new Exception("Get Calendar service failed.", ex);
            }
        }

        private static UserCredential GetUserCredential(string clientSecretJson, string userName, string[] scopes)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("userName");
                if (string.IsNullOrEmpty(clientSecretJson))
                    throw new ArgumentNullException("clientSecretJson");
                if (!File.Exists(clientSecretJson))
                    throw new Exception("clientSecretJson file does not exist.");

                // These are the scopes of permissions you need. It is best to request only what you need and not all of them               
                using (var stream = new FileStream(clientSecretJson, FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials\\", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);

                    // Requesting Authentication or loading previously stored authentication for userName
                    var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                                                                             scopes,
                                                                             userName,
                                                                             CancellationToken.None,
                                                                             new FileDataStore(credPath, true)).Result;

                    credential.GetAccessTokenForRequestAsync();
                    return credential;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Get user credentials failed.", ex);
            }
        }

        private static CalendarService GetService(UserCredential credential)
        {
            try
            {
                if (credential == null)
                    throw new ArgumentNullException("credential");

                // Create Calendar API service.
                return new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Calendar Oauth2 Authentication Sample"
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Get Calendar service failed.", ex);
            }
        }
    }

}

