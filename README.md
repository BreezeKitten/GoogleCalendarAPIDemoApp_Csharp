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
  - This option would ask user to login their google account and authorized the application to modify their calendar.
  
2. Service Account ( this project now supprot )
  - In this option, you would get a service account information( email and certential to login ).
    Share the target calendar with this service account, then the application can modify target calendar( using a calendar id ) with this service account.
    
For Detail, you can refer to https://ithelp.ithome.com.tw/articles/10279272

# Use
## Setting ( click the upper left button )
![圖片](https://user-images.githubusercontent.com/48701080/212818164-dd7191be-202f-4100-b8fa-43bda16b40d3.png)
Type the information 
1. Service Account Email
2. the path of Service Account Credential Json file.( Download from GCP )
3. Calendar ID

## Using
![圖片](https://user-images.githubusercontent.com/48701080/212818560-446ba520-b0db-45d3-896d-109757139316.png)
1. Initialization
- Click the button "初始化" to initialize client.
- If the service account information ( email and credential json file ) is correct, the initialize would be done and the left status lable would be "初始化完成"

2. List All Event ID
- Click the button "事件ID" to request list all event in target calendar
- The request result would list in the comboBox.

3. Read specific Eevnt
- Choose Event ID with ComboBox.
- The Event Content would be shown in below groupbox.

4. Delete specific Event
- Choose Event ID with ComboBox.
- Click the button "刪除"

5. Add Event
- Type information( summary, description, start time, and end time )
- Click the button "新增"

## TODO
1. Update Event Function.
2. OAuth 2.0 Client operation interface.
