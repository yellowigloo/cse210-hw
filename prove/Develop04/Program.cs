using System;

class Program
{
    static void Main(string[] args)
    {
        string breathingDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectionDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        // Activity act = new Activity();
        BreathingAct breath = new BreathingAct("Breathing Exersise", breathingDesc, 5, 4, 2);
        ListingAct listing = new ListingAct("Listing Exersise", listingDesc, 5, 4);
        ReflectionAct refl = new ReflectionAct("Reflection Exersise", reflectionDesc, 5, 2);
        // menu
        // starting message with act descript, ask for hideTimes, pause start
        // end message, pause end
        // animation during pause like the demo
        // refl breath enumer
        string answ = "";
        while (answ != "4"){
            Console.WriteLine($"Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
            answ =Console.ReadLine();
            if (answ == "1"){
                breath.Breathing();
            }
            else if (answ == "2"){
                listing.Listing();
            }
            else if (answ == "3"){
                refl.Reflecting();
            }

        }
    }
}