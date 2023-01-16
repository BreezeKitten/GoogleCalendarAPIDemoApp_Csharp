using System;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Google.Apis.Calendar.v3.Data;

namespace Discovery.ListAPIs
{
    /// <summary>
    /// This example uses the discovery API to list all APIs in the discovery repository.
    /// https://developers.google.com/discovery/v1/using.
    /// <summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string clientSecretJson = "C:\\Users\\BreezeCat\\Downloads\\client.json"; //add your json path here
            string userName = "103634898408632373958 "; // add your google account here
            string[] scopes = new string[3] { "https://www.googleapis.com/auth/calendar",  
                                                "https://www.googleapis.com/auth/calendar.events",
                                                "https://www.googleapis.com/auth/calendar.events.readonly" }; // replace n with the number of scopes you need and write them one by one
            CalendarService service = GetCalendarService(clientSecretJson, userName, scopes);

            Event newEvent = new Event()
            {
                Summary = "API Test Event",
                Description = "event description",
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(2023, 1, 16, 9, 0, 0),
                    TimeZone = "Asia/Taipei",
                },
                End = new EventDateTime()
                {
                    DateTime = new DateTime(2023, 1, 16, 12, 0, 0),
                    TimeZone = "Asia/Taipei",
                },
            }; //// more options here https://developers.google.com/calendar/api/v3/reference/events/insert#.net

            String calendarId = "2f608fbf267ca8958152cd93a97aaa70b551f4ec93cd6017f1e19f301fbcc924@group.calendar.google.com"; // choose a calendar in your google account - you might have multiple calendars
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
            Console.ReadKey();
        }


        public static CalendarService GetCalendarService(string clientSecretJson, string userName, string[] scopes)
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
                    var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets,
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