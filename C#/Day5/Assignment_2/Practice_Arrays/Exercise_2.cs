using System.Text;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder list = new StringBuilder("");
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string i = Console.ReadLine();
                if (i[0] == '+')
                {
                    list.Append(i.Substring(1) + " ");
                }else if (i.Equals("--"))
                {
                    list.Clear();
                }  else if (i[0] == '-')
                {
                    list.Replace(i.Substring(1), "");
                } else {Console.WriteLine("Oops");}
                
                Console.WriteLine(list);
            }
        }
    } 
}
