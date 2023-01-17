# GoogleCalendarAPIDemoApp_Csharp
A Google Calendar API Demo Application implemented in C# using Google.Apis.Calendar.v3

# Description
This is a C# windows Form project to demo some google calendar api function.

# Main Environment
1. Microsoft Visual Studio Communtity 2017
2. .Net FrameWork 4.0
3. Google.Apis.Calendar.v3  version 1.57.0.2759 install with NuGet

# Advance Preparation
## Google API
### First, Need to Enable the Google Calendar API function in Google Cloud Platform (GCP)
1. Create a project in GCP ( https://console.cloud.google.com )
2. enable the calendar api ( https://console.cloud.google.com/apis/api/calendar-json.googleapis.com/ )
### Second, Create credential
There are two options to use the API:
1. OAuth 2.0 Client ID 
  this option would ask user to login their google account and authorized the application to modify their calendar.
2. Service Account ( this project now supprot )
  in this option, you would get a service account information( email and certential to login ).
  Share the target calendar with this service account, then the application can modify target calendar with this service account.
