﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab9
{

    class Program
    {

        struct student
        {

            public string name;
            public List<string> infoName;
            public List<string> infoBody;
           
        }

        static student[] CreateRoster()
        {

            student[] classList = new student[20];

            classList[0].name = "William Twomey";
            classList[0].infoName[0] = "nickname";
            classList[0].infoBody[0] = "Ash, similar to Ash from Pokemon, however he was actually named after Ash Williams from the Evil Dead trilogy so now Terrell can stop with the Pokemon talk. He probably won't though.";
            classList[0].infoName.Add("favorite meme");
            classList[0].infoBody.Add("Take a closer look at that snout! Just a clip from a nature documentary that is very versatile in uses. Also elephant shrews are just kinda goofy lookin', ya feel me?");

            classList[1].name = "Dr. K";
            classList[1].infoName[0] = "hometown";
            classList[1].infoBody[0] = "Detroit. Hey, that's where we are!";
            classList[1].infoName.Add("favorite food");
            classList[1].infoBody.Add("Burgers.");

            classList[2].name = "Jacob Snover";
            classList[2].infoName[0] = "hometown";
            classList[2].infoBody[0] = "Merrillville. That's near Gary. Geary? I think it's in Indiana...";
            classList[2].infoName.Add("favorite food");
            classList[2].infoBody.Add("Pizza.");

            classList[3].name = "Kristen Rieske";
            classList[3].infoName[0] = "favorite cod";
            classList[3].infoBody[0] = "Black Ops 2. Me personally, I think BO3 was pretty good but I'm just a filthy zombies player so what do I know.";
            classList[3].infoName.Add("college studies");
            classList[3].infoBody.Add("Physics.");

            classList[4].name = "Student 5";
            classList[4].infoName[0] = "something cool";
            classList[4].infoBody[0] = "cool it worked";
            classList[4].infoName.Add("something amazing");
            classList[4].infoBody.Add("*Lifts car*");

            classList[5].name = "Lucifer S. Aeytan";
            classList[5].infoName[0] = "favorite number";
            classList[5].infoBody[0] = "66666666666666666... Likes lots of sixes...";
            classList[5].infoName.Add("favorite hobby");
            classList[5].infoBody.Add("Messing with the lives of mortals.");

            classList[6].name = "RNGesus";
            classList[6].infoName[0] = "7";
            classList[6].infoBody[0] = "...out of 20 is a pretty bad roll, the dragon roasts you alive.";
            classList[6].infoName.Add("roll for dex");
            classList[6].infoBody.Add("You roll a 1. You drop your bow and it somehow fires into your face. You died.");

            classList[7].name = "Arima Kousei";
            classList[7].infoName[0] = "favorite food";
            classList[7].infoBody[0] = "Egg salad sandwiches. This guy can go on and on about them...";
            classList[7].infoName.Add("colorblindness");
            classList[7].infoBody.Add("He no longer sees the world in monochrome but that wasn't a cheap upgrade.");

            classList[8].name = "Fictional Person 445";
            classList[8].infoName[0] = "favorite mode of transportation";
            classList[8].infoBody[0] = "Yeetasaurus-Rex. This dude memes on the haters.";
            classList[8].infoName.Add("why im like this");
            classList[8].infoBody.Add("I really don't know.");

            classList[9].name = "Death Metal Kitten";
            classList[9].infoName[0] = "favorite champion";
            classList[9].infoBody[0] = "Nidalee, she turns in to a cat.";
            classList[9].infoName.Add("favorite game");
            classList[9].infoBody.Add("League of Please-Stop-playing-this-Broken-Game");

            classList[10].name = "Kamina";
            classList[10].infoName[0] = "fighting style";
            classList[10].infoBody[0] = "All in, never look back, pure anime fighting spirit!";
            classList[10].infoName.Add("lifestyle");
            classList[10].infoBody.Add("Depending on where you are in the show: no.");

            classList[11].name = "Lex";
            classList[11].infoName[0] = "forehead size";
            classList[11].infoBody[0] = "Bigger than a school bus.";
            classList[11].infoName.Add("favorite movie");
            classList[11].infoBody.Add("ANYTHING without those little yellow minions in it.");

            classList[12].name = "Ali-A";
            classList[12].infoName[0] = "intro";
            classList[12].infoBody[0] = "*Loud bass-boosted music plays*";
            classList[12].infoName.Add("favorite game");
            classList[12].infoBody.Add("\"Fortnite\"");

            classList[13].name = "Ajit Pai";
            classList[13].infoName[0] = "favorite hobby";
            classList[13].infoBody[0] = "Returning humanity to the Dark Ages";
            classList[13].infoName.Add("favorite food");
            classList[13].infoBody.Add("Hopes and dreams of a true free market.");

            classList[14].name = "Mark Zuckerberg";
            classList[14].infoName[0] = "species";
            classList[14].infoBody[0] = "Some sort of reptile, I think. Like an Argonian from Skyrim.";
            classList[14].infoName.Add("data");
            classList[14].infoBody.Add("Error: OverflowException\nWay too much data on EVERYONE\nThe CIA should hire this dude.");

            classList[15].name = "Elon Musk";
            classList[15].infoName[0] = "overwatch rank";
            classList[15].infoBody[0] = "If this dude finds Overwatch soothing, there's no way he's anywhere above gold.";
            classList[15].infoName.Add("fun machines");
            classList[15].infoBody.Add("Elon's collection includes: Flamethrowers, Rockets, Electric cars (in space), probably his own personal super computer.");

            classList[16].name = "Bill Gates";
            classList[16].infoName[0] = "net worth";
            classList[16].infoBody[0] = "93.3 Billion USD. \nyikes";
            classList[16].infoName.Add("fun");
            classList[16].infoBody.Add("Probably pretends to be one of the little kids who pretends to be more powerful than he really is on Xbox Live. It's fun because Bill could do anything he wants to anyone in his lobby.");

            classList[17].name = "Bricky";
            classList[17].infoName[0] = "favorite operator";
            classList[17].infoBody[0] = "Brazilian Spook Factory (Caveira)";
            classList[17].infoName.Add("intelligence");
            classList[17].infoBody.Add("INT: 1");

            classList[18].name = "David Hasselhoff";
            classList[18].infoName[0] = "things he wants to love";
            classList[18].infoBody[0] = "You: all night long, with his song.";
            classList[18].infoName.Add("survivor status");
            classList[18].infoBody.Add("True");

            classList[19].name = "Final Boss";
            classList[19].infoName[0] = "roll";
            classList[19].infoBody[0] = "You dodged his attack but you rolled off the edge and suffered an environmental death.";
            classList[19].infoName.Add("attack");
            classList[19].infoBody.Add("You swing your sword but are killed midway through your attack. git gud.");

            //List<student> roster = classList.OfType<student>().ToList();
            //return roster;

            return classList;

        }

        static bool KeepLearning()
        {

            bool whileBreak = false;
            string cont = "";

            Console.WriteLine("Would you like to learn more? (Y/N)");

            do
            {

                try
                {

                    cont = Console.ReadLine();

                    if (cont.ToLower() == "yes" || cont.ToLower() == "y")
                    {

                        return true;

                    }
                    else if (cont.ToLower() == "no" || cont.ToLower() == "n")
                    {

                        return false;

                    }
                    else
                    {

                        Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too large.");
                    Console.WriteLine("Try using a sinlge letter like I asked for.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                    Console.WriteLine("A for effort though...");

                }

                Console.WriteLine("Please enter Y or N: ");

            } while (!whileBreak);

            return false;

        }

        static void FunFact(student subject, int selection)
        {

            if (selection >= 0 || selection < subject.infoBody.Count)
            {

                Console.WriteLine(subject.infoBody[selection]);

            }
            else
            {

                Console.WriteLine("Here's a catch all statement because some unexpected error occured.");

            }

        }

        static int SelectStudent(int length)
        {

            int output = 0;

            do
            {

                Console.WriteLine($"Please enter a number 1 through {length} (inlusive): ");

                try
                {

                    output = int.Parse(Console.ReadLine()) - 1;

                    if (output <= 20 || output >= 1)
                    {

                        //Console.WriteLine($"You have selected {roster[output]}!");
                        return output;

                    }
                    else
                    {

                        //Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too WAY large.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("You know very well what you did and were trying to do, shame on you!");

                }

            } while (true);

        }

        static int FactSelector(student subject)
        {

            string selection = "";
            Console.Write($"Would you like to learn about {subject.name}'s "); //{subject.infoName1} or {subject.infoName2}?");

            for (int i = 0; i < subject.infoName.Count - 2; i++)
            {

                Console.Write($"{subject.infoName[i]}, ");

            }

            Console.Write($"or {subject.infoName[subject.infoName.Count - 1]}.\n");

            do
            {

                try
                {

                    int ind = -1;
                    int counter = 0;

                    selection = Console.ReadLine();

                    foreach(string name in subject.infoName)
                    {

                        if (name == selection)
                        {

                            return counter;

                        }

                        counter++;

                    }

                    if (ind == -1)
                    {

                        Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too large.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("Ha ha, very funny. Stop trying this though. I'm copy and pasting these exception handlers everywhere.");

                }

                Console.Write("Please enter: ");

                for (int i = 0; i < subject.infoName.Count - 2; i++)
                {

                    Console.Write($"{subject.infoName[i]}, ");

                }

                Console.Write($"or {subject.infoName[subject.infoName.Count - 1]}.\n");

            } while (true);

        }

        static void Main(string[] args)
        {

            student[] roster = CreateRoster();
            List<student> classList = roster.OfType<student>().ToList();

            Console.WriteLine("Welcome to the Made-Up-Info-About-This-Class Wiki!");
            int stuSel = 0;
            int inSel = 0;

            do
            {

                stuSel = SelectStudent(classList.Count);
                inSel = FactSelector(classList[stuSel]);
                FunFact(classList[stuSel], inSel);

            } while (KeepLearning());

            Console.WriteLine("See ya next time...");

        }

    }

}