using System;
using System.Collections.Generic;

namespace myFirstCsharpApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------PLANETS --------------------
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is totalllyyy " + DateTime.Now);
            Console.WriteLine("                                  ");
            Console.WriteLine("__________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||PLANETS||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("                                  ");

            // Planets
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine("---------------ORIGINAL PLANETS------------");
            planetList.ForEach(Print);

            // 1. Add() Jupiter and Saturn at the end of the list.
            planetList.AddRange(new string[] { "Jupiter", "Saturn" });
            Console.WriteLine("---------------ADD JUPITER AND SATURN------------");
            planetList.ForEach(Print);

            // 2. Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            // 3. Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);
            Console.WriteLine("---------------ADD URANUS AND NEPTUNE------------");
            planetList.ForEach(Print);

            // 4. Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            Console.WriteLine("---------------INSERT VENUS AND EARTH------------");
            planetList.ForEach(Print);

            // 5. Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            Console.WriteLine("---------------ADD PLUTO------------");
            planetList.ForEach(Print);


            // Display the contents of the list using the Print method.
            // Console.WriteLine("---------------PRINT METHOD------------");
            // planetList.ForEach(Print);
            // The following demonstrates the anonymous method feature of C#
            // to display the contents of the list to the console.
            // Console.WriteLine("---------------FOREACH-----------------");
            // planetList.ForEach(delegate (String name)
            // {
            //     Console.WriteLine(name + " from ForEach");
            // });

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("---------------ROCKY PLANETS------------");
            rockyPlanets.ForEach(Print);

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");
            Console.WriteLine("---------------PLUTO REMOVED------------");
            planetList.ForEach(Print);




            // ----------RANDOM NUMBERS --------------------
            Console.WriteLine("                                    ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||RANDOM NUMBERS||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("                                    ");

            Random random = new Random();
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                randomNumbers.Add(random.Next(6));
            }
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (randomNumbers.Contains(i))
                {
                    Console.WriteLine("numbers list contains " + i);
                }
                else
                {
                    Console.WriteLine("numbers list does not contain " + i);
                }
            }

            // ----------WORDS AND DEFINITIONS --------------------
            Console.WriteLine("                                    ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||WORDS AND DEFINITIONS|||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("                                    ");

            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Pikachu", "A member of a small yellow mouse-like Pokémon species that has red cheeks and a tail shaped like a lightning bolt, and is able to control electricity.");
            wordsAndDefinitions.Add("Dr Pepper", "A carbonated soft drink. It was created in the 1880s by pharmacist Charles Alderton in Waco, Texas and first served around 1885");


            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
                
            */
            Console.WriteLine("---------------SQUARE BRACKETS------------");
            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["Pikachu"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            Console.WriteLine("---------------FOREACH CONCAT------------");
            foreach (KeyValuePair<string, string> entry in wordsAndDefinitions)
            {
                Console.WriteLine("The definition of " + entry.Key + " is --- " + entry.Value);
                Console.WriteLine("                                                     ");
            }

            // ----------LIST OF DICTIONARIES ABOUT WORDS --------------------
            Console.WriteLine("                                    ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||List of Dictionaries about Words||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("                                    ");


            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> jumpWord = new Dictionary<string, string>();
            jumpWord.Add("word", "jump");
            jumpWord.Add("definition", "push oneself off a surface and into the air by using the muscles in one's legs and feet.");
            jumpWord.Add("part of speech", "verb");
            jumpWord.Add("example sentence", "I like to jump.");
            dictionaryOfWords.Add(jumpWord);


            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries

            dictionaryOfWords.ForEach(word =>
            {
                Console.WriteLine("                               ");
                foreach (KeyValuePair<string, string> entry in word)
                {
                    Console.WriteLine(entry.Key + ": " + entry.Value);
                    // do something with entry.Value or entry.Key
                }
            });


            // ----------ENGLISH IDIOMS --------------------
            Console.WriteLine("                                    ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||ENGLISH IDIOMS|||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("                                    ");

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                Console.WriteLine(idiom.Key + ": " + String.Join(" ", idiom.Value));
            }


            // ----------HEIST --------------------
            Console.WriteLine("                                    ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||HEIST||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("                                    ");

            // 1.Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("                                  ");
            Console.WriteLine("------  𝗗 𝗜 𝗙 𝗙 𝗜 𝗖 𝗨 𝗟 𝗧 𝗬  -----");
            Console.WriteLine("Enter the Bank's difficulty:      ");
            var difficultyInputValue = Console.ReadLine();
            int initialBankDifficulty;
            while (!(int.TryParse(difficultyInputValue, out initialBankDifficulty) && Convert.ToInt32(difficultyInputValue) >= 0))
            {
                Console.WriteLine("Bank difficulty must be a positive number!");
                difficultyInputValue = Console.ReadLine();
            }
            Console.WriteLine("                                    ");
            Console.WriteLine("---- 𝗔 𝗦 𝗦 𝗘 𝗠 𝗕 𝗟 𝗘   𝗧 𝗘 𝗔 𝗠 ----");
            // 2.Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
            List<HeistTeamMember> heistTeamMembers = new List<HeistTeamMember>();
            bool teamIsCreated = false;
            while (!teamIsCreated)
            {
                // 3. Prompt the user to enter a team member's name and save that name.
                Console.WriteLine("Enter your team member's name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    teamIsCreated = true;
                }
                else
                {
                    // 4. Prompt the user to enter a team member's skill level and save that skill level with the name.
                    Console.WriteLine("Enter your team member's skill level: ");
                    var skillInputValue = Console.ReadLine();
                    int skillLevel;
                    while (!(int.TryParse(skillInputValue, out skillLevel) && Convert.ToInt32(skillInputValue) >= 0))
                    {
                        Console.WriteLine("This is not a valid skill level!");
                        skillInputValue = Console.ReadLine();
                    }

                    // 5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                    Console.WriteLine("Enter your team member's courage factor: ");
                    // double courageFactor = Convert.ToDouble(Console.ReadLine());
                    var courageInputValue = Console.ReadLine();
                    double courageFactor;
                    while (!(Double.TryParse(courageInputValue, out courageFactor) && Convert.ToDouble(courageInputValue) >= 0 && Convert.ToDouble(courageInputValue) <= 2))
                    {
                        Console.WriteLine("Courage level must be a number between 0 and 2!");
                        courageInputValue = Console.ReadLine();
                    }
                    heistTeamMembers.Add(new HeistTeamMember(name, skillLevel, courageFactor));
                    Console.WriteLine("                                        ");
                    Console.WriteLine("   ♪  ♪ ♪  .                 ♪  ♪ ♪ ♪   ");
                    Console.WriteLine("♪ ♪ ♪  Add another team member!  ♪♪  ♪♪ ");
                    Console.WriteLine("  ♪ ♪.♪                       ♪ ♪ ♪     ");
                    Console.WriteLine("                                        ");
                }
            }
            Console.WriteLine("                                 ");
            Console.WriteLine("-------  𝗔 𝗧 𝗧 𝗘 𝗠 𝗣 𝗧 𝗦  ------");
            Console.WriteLine("How many attempts will you make? ");
            var attemptsInputValue = Console.ReadLine();
            int numberOfAttempts;
            while (!(int.TryParse(attemptsInputValue, out numberOfAttempts) && Convert.ToInt32(attemptsInputValue) >= 1 && Convert.ToInt32(attemptsInputValue) <= 100))
            {
                Console.WriteLine("Attempts must be between 1 and 100!");
                attemptsInputValue = Console.ReadLine();
            }

            Console.WriteLine("                                   ");
            Console.WriteLine("----------  𝗧 𝗘 𝗔 𝗠  ----------    ");

            Console.WriteLine("You have " + heistTeamMembers.Count + " members in your Team:");

            int combinedSkillLevel = 0;
            for (int i = 0; i < heistTeamMembers.Count; i++)
            {
                heistTeamMembers[i].PrintTeamMember();
                combinedSkillLevel += heistTeamMembers[i].SkillLevel;
            }
            Console.WriteLine("                                    ");
            Console.WriteLine("----------  𝗛 𝗘 𝗜 𝗦 𝗧 !  ----------    ");
            Console.WriteLine("Your combined skill level is " + combinedSkillLevel);
            Console.WriteLine("                                                  ");

            int numberOfWins = 0;
            for (int i = 0; i < numberOfAttempts; i++)
            {
                int luckValue = random.Next(-10, 10);
                int bankDifficulty = initialBankDifficulty + luckValue;
                Console.WriteLine((i + 1) + "). The Bank's difficulty is " + bankDifficulty);
                if (bankDifficulty > combinedSkillLevel)
                {
                    Console.WriteLine("YOU LOST");
                }
                else
                {
                    Console.WriteLine("✰✰✰ YOU WON ✰✰✰");
                    numberOfWins++;
                }
                Console.WriteLine("           ");
            }
            Console.WriteLine("----------  𝗥 𝗘 𝗦 𝗨 𝗟 𝗧 𝗦  ----------    ");
            Console.WriteLine("WINS: " + numberOfWins);
            Console.WriteLine("LOSSES: " + ((numberOfAttempts) - numberOfWins));
        }
        // print 
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public class HeistTeamMember
        {
            public HeistTeamMember(string name, int skill, double courage)
            {
                TeamMemberName = name;
                SkillLevel = skill;
                CourageFactor = courage;
            }
            public string TeamMemberName { get; set; }
            public int SkillLevel { get; set; }
            public double CourageFactor { get; set; }
            public void PrintTeamMember()
            {
                Console.WriteLine("           ");
                Console.WriteLine("Name: " + TeamMemberName);
                Console.WriteLine("Skill Level: " + SkillLevel);
                Console.WriteLine("Courage Factor: " + CourageFactor);
                Console.WriteLine("           ");
            }
        }
    }
}
