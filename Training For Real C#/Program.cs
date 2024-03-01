using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String LetStart;
            String LetMid;
            String LetEnd;
            Console.WriteLine("Welcome to my random Mini Book");
            Console.WriteLine("ALL OPTIONS ARE CASE-SENSITIVE! MUST BE LOWERCASE!");
            Console.WriteLine(" Would you like story A, B, or C ?");
            LetStart = Console.ReadLine();
            // Story 1
            if (LetStart == "a")
            {
                Console.WriteLine("You were transported to McDonalds...as an employee, making only 7.25 an hour and every other customer is rude");
                Console.WriteLine("And because for the sake of this mini project, I will let you know that a rude customer came your way, demanding to speak to the manager because the cook crew forgot pickles...");
                Console.WriteLine("While the Customer was screaming for at least 5 minutes straight and dribbles of spit is running down your face, ");
                Console.WriteLine("You have three choices");
                Console.WriteLine("Option a = You politely carry out the customer's request and grab the manager ");
                Console.WriteLine("Option b = You Quickly let the cooks know what happened and get their order right ");
                Console.WriteLine("Option c = Gamer moment ");
                    LetMid = Console.ReadLine();
                if (LetMid == "a")
                {
                    Console.WriteLine("you get the manager and they told the customer that they would get the food right and apologizes for the inconvienience... thats it stories over!");
                }
                else if (LetMid == "b")
                {
                
                    Console.WriteLine(" You ask the cooks to remake the food, But the manager comes out and goves you an earful because of unauthorized food remake, you get lectured about food cost and you are sent home early because fast food manager things");
                    Console.WriteLine(" You arrive home, next thing you do is lay in bed");
                    Console.WriteLine(" Choice A = do you sleep for the night? ");
                    Console.WriteLine(" Choice B = do you spend the remainder of your night on indeed?");
                    LetEnd = Console.ReadLine();
                    if (LetEnd == "a") 
                    {
                    Console.WriteLine("You sleep for the night, only to wake up and realize you work again...at a dead end job... yayyyyyyyyyyyy");
                        Console.WriteLine("THE END!!!!");

                    }
                    else if (LetEnd == "b") 
                    {
                        Console.WriteLine("You decided to kip up and realize you can do literally anything else instead of fast food, you start scrolling through indeed.");
                        Console.WriteLine("30 Applications later, and now you work from home taking calls for nearly triple of what you were making before.");
                        Console.WriteLine("Your attitude and outlook on life is good, congrats!");
                        Console.WriteLine("THE END!!!!");
                    }
                }
                else if (LetMid =="c")
                {
                    Console.WriteLine("You decide to go Ape$%&*, you Zoink out in Moutain Dew infused rage, you smell doritos on the customer, you turn into Ryu from streets.");
                    Console.WriteLine("You now only have 2 options left...");
                    Console.WriteLine("Choice A = Revert... no reason to spaz out.");
                    Console.WriteLine("Choice B = EAT THEM DORITOS!!!!!!!!!");

                    LetEnd = Console.ReadLine();
                    if (LetEnd == "a")
                    {
                        Console.WriteLine("you revert back to a normal but agitated state, you deeply apologized but returned home depressed and never returned to work the next day");
                        Console.WriteLine("THE....END?");
                    }
                    else if (LetEnd == "b") 
                    {
                        Console.WriteLine("you swipe the cool ranch dusted doritos, and swallowed them whole, you then morphed into a fighter jet.");
                        Console.WriteLine("You then ride up to destroy the asteroid that'll cause a potential zombie outbreak.");
                        Console.WriteLine("Then after you were praised by the president of the world, you then die peacefully, reborn again as a prometheus!");
                        Console.WriteLine("Good job! THE END!...");
                    }
                }
            }
            if (LetStart == "b")
            {
                Console.WriteLine("you awoke in a state of delrium, it was dark and you understand that you're in a middle of a forest.");
                Console.WriteLine("as you come to your senses, you noticed a few things of interest in your vicinity.");
                Console.WriteLine("There is a ray of light shining down from the sky to your left, a crashed plane just ahead, and an abandoned house to your right.");
                Console.WriteLine("a: Go Left, b: Go Straight, c: Go Right?");
                LetMid = Console.ReadLine();
                if (LetMid == "a") 
                {
                    Console.WriteLine("you walk towards the light, as you reached to your destination near it, you noticed a random object falling down within the light.");
                    Console.WriteLine("it appears to be a weapon of a sort, kind of resembles an oversized key, you hear a voice faint but distingushable.");
                    Console.WriteLine(" \" your heart is bright, you seem like someone who can wield this, you may walk away if you please... \" ");
                    Console.WriteLine("you stand there puzzled but you understand the options at hand");
                    Console.WriteLine(" Choice A: Grab the blade?  Choice B: Walk away? ");
                

                    LetEnd= Console.ReadLine();
                    if (LetEnd == "a") 
                    {
                        Console.WriteLine("You grab the weapon by the hilt, it suddenly disappears, you start to become sleepy again...");

                        Console.WriteLine("Press any key to wake yourself up");

                        Console.ReadLine();
                        Console.WriteLine(" you awake once again, this time you are in a strange area.. the platform you're standing on is pretty bright, as if it's made out of light itself ");
                        Console.WriteLine(" \" oh...so you're awake? good \"  its the voice again, but it's more profound than before. "); 
                        Console.ReadLine() ;
                        Console.WriteLine(" \" quick look ahead now!! \" You look ahead and notice 3 little dark creatures, obviously looking very menacing ");
                        Console.WriteLine("You steadily walk away from those creatures as they approach you with malice, unfortunately you're running out of room on the platform");
                        Console.WriteLine("you're overcome with fear and distraught...all hope is loss");
                        Console.ReadLine();
                        Console.WriteLine(" \" Don't falter, keep your light burning bright!! remember you have the power to fight back!!!  \" as the creatures jump at you, a bright light emits in front of you ");
                        Console.WriteLine(" The blade appears on your hand, releasing a shockwave that blows the creatures away, they start to tremble, You're now on the attack ");
                        Console.ReadLine();
                        Console.WriteLine("You quickly take care of those demons, you catch your breath and notice a long snake like pathway appeared...you embark on a vast journey deep into your heart!");
                        Console.ReadLine();
                        Console.WriteLine("The End...For now");
                
                    }
                    if (LetEnd == "b") 
                    {

                        Console.WriteLine("You decide to turn away from that, as you turned away, you find yourself back at your residence");
                        Console.WriteLine("you go inside your bedroom, and get proper sleep");
                        Console.ReadLine();
                        Console.WriteLine("THE END!");
                    }
                
                }
                if (LetMid == "b") 
                {

                    Console.WriteLine(" ");
                
                
                }
              



            }



        
        }   
    }
}
