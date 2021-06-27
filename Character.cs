using System;
using static System.Console;
namespace warmup
{
    public class Character
    {

        /*SPECIES INSTANCES!!!!
         * have to be instantiated in this class
         * in order to be called / referenced! it's less
         * confusing that way
         */
        public static Species Human = new Species("Human", 165, false);
        public static Species Andorian = new Species("Andorian", 170, false);
        public static Species Tellerite = new Species("Tellerite", 160, false);
        public static Species Vulcan = new Species("Vulcan", 170, true);
        public static Species Romulan = new Species("Vulcan", 160, true);
        public static Species Trill = new Species("Trill", 140, false);
        public static Species Klingon = new Species("Klingon", 180, false);
        public static Species Cardassian = new Species("Cardassian", 170, false);
        public static Species Bajoran = new Species("Bajoran", 165, false);
        public static Species Betazoid = new Species("Betazoid", 165, true);
        public static Species Ferengi = new Species("Ferengi", 155, false);
        public static Species Denobulian = new Species("Denobulian", 165, false);
        public static Species Benzite = new Species("Benzite", 170, true);
        public static Species Kelpien = new Species("Kelpien", 200, true);

        //OCCUPATION INSTANCES!!
        // i had to do this for the if/else statement later rip
        public static Occupation Starfleet = new Occupation("Starfleet officer");
        public static Occupation Smuggler = new Occupation("a smuggler");
        public static Occupation Bounty = new Occupation("a bounty hunter");
        public static Occupation Botany = new Occupation("a botanist");
        public static Occupation Doctor = new Occupation("a doctor");
        public static Occupation Merchant = new Occupation("a merchant");
        public static Occupation Pilot = new Occupation("a pilot");
        public static Occupation Engineer = new Occupation("an engineer");
        public static Occupation Explore = new Occupation("an explorer");
        public static Occupation Spy = new Occupation("a spy");


        /* setting aside a space for something you
        * havent set a value yet so it at least
        * exists in the class!
        * 
        * in this case, it's all the elements
        * that are going to be randomized!
        */
        public Species randoSpec;
        public string randoLoc;
        public string randoBG;
        public string fate;
        public string fate2;
        public string randoDiv;
        public string event1;
        public string event2;
        public int randAge;
        public int randoHeight;
        public Occupation randoJob;


        /*
         * managed to put the instantiated objects
         * into an array, ready for randomization!
         */
        Species[] specArray =
        {
            Human, Andorian,
            Tellerite, Vulcan,
            Trill, Klingon,
            Cardassian, Bajoran,
            Betazoid, Ferengi,
            Denobulian, Benzite,
            Kelpien
        };


        //envrionment array
        string[] Loc =
        {
            "their homeworld",
            "a busy colony",
            "an isolated colony",
            "a frontier colony",
            "a starship",
            "a starbase",
            "another species' world"
        };

        //background array
        string[] BG =
        {
            "Starfleet",
            "agriculture",
            "science and tech",
            "creative fields",
            "diplomacy and politics"
        };

        //fate
        string[] Rebel =
        {
            "accepted",
            "rejected"
        };

        //jobs
        //which btw this one killed me kinda
        Occupation[] jobArray =
        {
            Starfleet, Smuggler,
            Bounty, Botany,
            Doctor, Merchant,
            Pilot, Engineer,
            Explore, Spy,
        };

        //starfleet divison
        string[] divisions =
        {
            "engineering", "security", "tactical",
            "medical", "science",
            "command" 
        };

        //career events
        string[] Career =
        {
            "a ship they were on was destoryed", "they witnessed a death of a friend",
            "they were lauded by another culture", "they negotiated a treaty",
            "they were forced to take command", "they had an encounter with a truly alien being",
            "they had a serious injury", "they engaged in a conflict with a hostile culture",
            "they had a mentor", "they got into a transporter accident",
            "they dealt with a plague or viral outbreak", "they betrayed their ideals for" +
                " a superior",
            "they called out a superior", "they came up with a new battle strategy",
            "they learned a unique language", "they discovered an artefact",
            "they received a special commendation", "they solved an engineering crisis",
            "they made a breakthrough, or created a new invention,", "they made first contact"
        };


        public void GenerateRandom()
        {
            /*
             * judge me for this all you want except
             * i think this worked out pretty well for
             * myself! sobs TT_TT
             */

            Random random = new Random();
            int index = random.Next(0, specArray.Length);
            randoSpec = specArray[index];

            int locdex = random.Next(0, Loc.Length);
            randoLoc = Loc[locdex];

            int bgdex = random.Next(0, BG.Length);
            randoBG = BG[bgdex];

            int rDex = random.Next(0, Rebel.Length);
            int rDex2 = random.Next(0, Rebel.Length);
            fate = Rebel[rDex];
            fate2 = Rebel[rDex2];

            int occDex = random.Next(0, jobArray.Length);
            randoJob = jobArray[occDex];

            int divDex = random.Next(0, divisions.Length);
            randoDiv = divisions[divDex];

            int eventDex = random.Next(0, Career.Length);
            int eventDex2 = random.Next(0, Career.Length);
            event1 = Career[eventDex];
            event2 = Career[eventDex2];

            int age = random.Next(20, 69);
            randAge = age;

            int height = random.Next(-30, 30);
            randoHeight = height;

        }

        public Character()
        {

        }


        public void describe()
        {
            // automatically runs the generate method!!
            // and also thank you Kevin for telling me to put it
            // here instead of where it was previously lol
            GenerateRandom();

            WriteLine($"Your character is {randoSpec.speciesName}, standing at " +
                (randoSpec.avgHeight - randoHeight) + "cm. They have " +
                randAge + " years under their belt.");
            WriteLine("Press any key to generate backstory");
            ReadKey();

            WriteLine($"Your character grew up in {randoLoc}, with a background in {randoBG}." +
                $"\nThey {fate} their upbringing.");
            ReadKey();

            //here's the code for the career bc i couldn't figure out how to Fucking do this
            //without making it an instantiated class LOL

            if (randoJob == Starfleet)
            {
                WriteLine($"Your character is {randoJob.Title}, in {randoDiv}.");
            }
            else
            {
                WriteLine($"Your character is {randoJob.Title}.");
            };

            WriteLine($"Your character has {fate2} their current occupation.");
            WriteLine("Press any key to generate life events");
            ReadKey();

            WriteLine($"During your characters life, {event1}" +
                $" and {event2}");
            ReadKey();
        }
    }
}
