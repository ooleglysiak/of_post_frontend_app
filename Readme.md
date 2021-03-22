#  Of Post
 
Of Post - this is an application that will simplify the use and management of your social networks

![](https://img.shields.io/teamcity/codebetter/bt428.svg) [![License:MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/ooleglysiak/of_post_frontend_app/blob/master/LICENSE)

## Supported Platforms: iOS and Android

The app is available for two platforms:

- iOS
- Android

# Setup

Download or clone the repository.

Rebuild the solution to get all neccesary NuGet packages.

### Update your connectionStrings
Configure a connection string for SQL Server in the Web.config
```
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Data 
    Source=YOURTDATABASE; 
    Initial Catalog=YOURNAMEDB; Persist Security     
    Info=True;User ID=YOURUSER;Password=YOURPASSWORD”"
    providerName="System.Data.SqlClient" />
  </connectionStrings>-->
```
- [Connection String Syntax](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/connection-string-syntax)
- [Learn more about connection strings](https://www.connectionstrings.com)

### Configure validation logic for passwords
By default, if you don't customise anything, Identity configures a default set of validation rules for new passwords. If you want to change these values, you can change the file called [App_Start/IdentityConfig.cs](https://github.com/jorgemht/Hospital-HIS/blob/master/Screenshots/API/PasswordValidator.png)

```
    manager.PasswordValidator = new PasswordValidator
    {
        RequiredLength = 6, // Passwords must be at least 6 characters
        RequireNonLetterOrDigit = false, // Passwords must have at least one digit ('0'-'9')
        RequireDigit = false, // Passwords must have at least one non alphanumeric character
        RequireLowercase = false, // // Passwords must have at least one lowercase ('a'-'z')
        RequireUppercase = false, // Passwords must have at least one uppercase ('A'-'Z')
    };
```
[PasswordValidator Class](https://msdn.microsoft.com/en-us/library/microsoft.aspnet.identity.passwordvalidator(v=vs.108).aspx)

### Set the color in the project 
In our PCL, the file App.xaml you can change the color
```
    <Color x:Key="MainColor">#273646</Color>
    <Color x:Key="FontColor">#2d8dd6</Color>
    <Color x:Key="AccentColor1">#2371aa</Color>
    <Color x:Key="AccentColor2">#e44235</Color>
    <Color x:Key="BackgroundColor">#e9eeef</Color>
```
[Resource Dictionaries](https://developer.xamarin.com/guides/xamarin-forms/xaml/resource-dictionaries/)

### Set your API
In our PCL, the file Services/HttpService.cs you must put the url of your api and prefix
```
   private const string UrlApi = "YOURAPI";
   private const string tokenType = "bearer";
   protected const string FirstVersion = "/api";
```
- [Rest api tutorial - Microsoft](https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design)
- [Rest api tutorial - hackernoon](https://hackernoon.com/restful-api-designing-guidelines-the-best-practices-60e1d954e7c9)
- [Rest api tutorial - code-maze](https://code-maze.com/top-rest-api-best-practices/)
- [Rest api tutorial - solidgeargroup](https://solidgeargroup.com/best-practices-rest-api)

# Security
OAuth 2.0 protocol and Microsoft Owin Library will help us. Owin is basically creating own pipeline between iis and application to manage requests.

In the file Startup.Auth.cs an OWIN Authorization server is configured to accept login (token) HTTP requests at /Token endpoint and external login requests at /api/Account/ExternalLogin

- [OAuthAuthorizationServerOptions Class](https://msdn.microsoft.com/en-us/library/microsoft.owin.security.oauth.oauthauthorizationserveroptions(v=vs.113).aspx)
- [Oauth](https://oauth.net/)
- [OAuthAuthorizationServerOptions Token](https://github.com/jorgemht/Hospital-HIS/blob/master/Screenshots/API/Token.png)

# Requirements
 * [Visual Studio 2021](https://www.visualstudio.com/vs/)

Adobe](https://color.adobe.com/Flat-UI-color-theme-2469224/) - To create color schemes for my designs. For this project I have choosen 

# Licenses

This project uses some third-party assets with a license that requires attribution:

- [Settings](https://github.com/jamesmontemagno/SettingsPlugin) : by James Montemagno
- [Sharpnado.Tabs 2.0](https://github.com/roubachof/Sharpnado.Tabs) : by roubachof 
- [EntityFramework](https://www.nuget.org/packages/EntityFramework/): by Microsoft's
- [Microcharts](https://www.nuget.org/packages/Microcharts/): by eman1986
- [Xamarin.Plugin.Calendar](https://www.nuget.org/packages/Xamarin.Plugin.Calendar/): by lilcodelab

# Recommended links
[Getting Started with Xamarin.Forms](https://docs.microsoft.com/uk-ua/xamarin/get-started/)

# Copyright and license
The MIT License (MIT) see [License file](https://github.com/ooleglysiak/of_post_frontend_app/blob/master/LICENSE) 

