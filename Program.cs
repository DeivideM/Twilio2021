using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account; //dotnet add package Twilio

namespace Twilio2021
{
    class Program
    {
        static void Main(string[] args)
        {

            string accountSid = "SeuAccountID";//Configurando separadamente do código Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            string authToken = "SeuAuthToken";//Configurando separadamente do código Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            TwilioClient.Init(accountSid, authToken);

            //body: mensagem que deseja enviar
            //Twilio.Types.PhoneNumber: número que você precisa configurar no twilio
            //to: pra quem você deseja enviar a mensagem
            var message = MessageResource.Create(
                body: "Testando envio de mensagem com o Twilio.",
                from: new Twilio.Types.PhoneNumber("+SeuNumeroTwilio"),
                statusCallback: new Uri("http://postb.in/1234abcd"),
                to: new Twilio.Types.PhoneNumber("+NumeroQueDesejaEnviarMensagem")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
