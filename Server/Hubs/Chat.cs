using Microsoft.AspNetCore.SignalR;
using SignalRRR.Shared;

namespace SignalRRR.Server.Hubs
{
    public class Chat : Hub
    {
        public void Test(Poruka p)
        {
            p.Vreme = DateTime.Now; 
            Console.WriteLine($"{p.Vreme.TimeOfDay} -- {p.Ime}: {p.Tekst}");
            Clients.All.SendAsync("dodaj", p);
        }
    }
}
