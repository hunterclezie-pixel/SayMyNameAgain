/* 
Hunter Clezie 
Spring 2026
RCET2265
SayMyNameAgain
github url: https://github.com/hunterclezie-pixel/SayMyNameAgain.git
*/
namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what is your name?");
            string userinput = "Insert name";
            userinput = Console.ReadLine();
            switch (userinput)
            {
            case "Emily":
                Console.WriteLine($"Hey {userinput}! How's your day been?");
                break;
            case "Joe":
                Console.WriteLine($"Hehehehe wassup {userinput}");
                break;
            case "Hunter":
                Console.WriteLine($"Yooooo *Robotically daps you up* my main man {userinput}");
                break;
            case "Tim":
                Console.WriteLine($"TIMMMMM!!! Omg it's the Tim himself! I could literally scream right now! *Screams in beeps*");
                Console.Beep(550,3000);
                break;
            default:
                Console.WriteLine($"It's nice to meet you!");
                break;
            }
                //pause
                Console.Read();
        }
    }
}
