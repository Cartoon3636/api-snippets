// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Notify.V1.Service;

public class Example
{
    public static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // To set up environmental variables, see http://twil.io/secure
        const string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        const string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
        const string serviceSid = Environment.GetEnvironmentVariable("TWILIO_SERVICE_SID");

        TwilioClient.Init(accountSid, authToken);

        var notification = NotificationResource.Create(
            serviceSid,
            toBinding: new List<string> { "{\"binding_type\":\"sms\",\"address\":\"+15555555555\"}",
            "{\"binding_type\":\"facebook-messenger\",\"address\":\"123456789123\"}" },
            body: "Hello Bob");

        Console.WriteLine(notification.Sid);
    }
}
