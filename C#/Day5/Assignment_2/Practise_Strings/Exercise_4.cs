using System.Text;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string urls = Console.ReadLine();
            // string urls = "https://www.apple.com/iphone";
            StringBuilder url = new StringBuilder(urls);
            StringBuilder protocol = new StringBuilder(""), server = new StringBuilder(""), resource = new StringBuilder("");
            if (url.ToString().Contains(":"))
            {
                protocol = new StringBuilder(url.ToString().Split(':')[0]);
                url.Replace(protocol + "://", "");
            }

            if (url.ToString().Contains('/'))
            {
                server = new StringBuilder(url.ToString().Split('/')[0]);
                resource = url.Replace(server + "/", "");
            }
            Console.WriteLine($"{url}\n [protocol] = \"{protocol}\" \n [server] = \"{server}\" \n [resource] = \"{resource}\"");
   
        }
    }
}
