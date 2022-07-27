
using System;
namespace ifelse
{
    class Program
    {
        public static void Main( string[] args)
        {
int time = DateTime.Now.Hour;
        

if(time>=6 && time <= 12)
{
    Console.WriteLine("iyi günler!");
}
else if (time>12 && time<=18)
{
    Console.WriteLine("iyi günler!");
}
else
{
    Console.WriteLine("iyi geceler!");
}
Console.WriteLine(time >= 6 && time <= 12 ? "iyi günler" : time > 12 && time <= 18 ? "iyi günler" : "iyi geceler");
        }
    }
 }