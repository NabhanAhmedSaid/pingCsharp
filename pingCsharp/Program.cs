// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Welcome to Ping App");
Console.WriteLine("Please write the url of website for example: google.com");
string hostName = Console.ReadLine();
Console.WriteLine("Please wait....");
var pingClient = new Ping();
PingReply answer = pingClient.Send(hostName);
if(answer.Status == IPStatus.Success)
{
    Console.WriteLine($"the ping is successful");
    Console.WriteLine($"the ip is {answer.Address}");
    Console.WriteLine($"the Roundtrip time  is {answer.RoundtripTime} ms");
    Console.WriteLine($"the Time to live   is {answer.Options.Ttl}");
    Console.WriteLine($"Don't Fragment {answer.Options.DontFragment}");
}
else
{
    Console.WriteLine($" the ping is not  successful");
    Console.WriteLine($" Error message : {answer.Status.ToString()}");
}