using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            int trialRuns;
            int bankDifficulty;
            List<Heister> Heisters = new List<Heister>();
            Console.WriteLine("Plan your heist");
            Console.WriteLine();
            Console.WriteLine("First of all, how hard is this bank gonna be??");
            string bankDifficultyString = Console.ReadLine();
            try
            {
                bankDifficulty = int.Parse(bankDifficultyString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{bankDifficultyString} is not a number, dum-dum.  You should rethink the bank robbing plan.  Bank difficulty will be 1 billion.");
                bankDifficulty = 1000000000;

            }
            while (true)
            {
                Heister teamMember;
                Console.WriteLine("What is the team member's name?");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("ok, how many times do we run this test??");
                    string trialRunsString = Console.ReadLine();
                    try
                    {
                        trialRuns = int.Parse(trialRunsString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{trialRunsString} is not a number, dum-dum.  You should rethink the bank robbing plan.  For now, you get one trial run.");
                        trialRuns = 1;

                    }
                    break;
                }
                else
                {

                    Console.WriteLine("What is the team member's skill level?");
                    string skillLevelString = Console.ReadLine();
                    int skillLevel;
                    //try catch statement for exceptions
                    try
                    {
                        skillLevel = int.Parse(skillLevelString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{skillLevelString} is not a valid number, now you get 5");
                        skillLevel = 5;

                    }

                    Console.WriteLine("What is the team member's courage factor?");
                    string courageFactorString = Console.ReadLine();
                    decimal courageFactor;

                    try
                    {
                        courageFactor = decimal.Parse(courageFactorString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"attention please.  {courageFactorString} will be set to 1");
                        courageFactor = 1.0M;
                    }

                    teamMember = new Heister()
                    {
                        Name = name,
                        SkillLevel = skillLevel,
                        CourageFactor = courageFactor
                    };
                    Console.WriteLine($"name: {teamMember.Name}");
                    Console.WriteLine($"skill level: {teamMember.SkillLevel}");
                    Console.WriteLine($"courage factor: {teamMember.CourageFactor}");
                    Heisters.Add(teamMember);
                }

            }
            int success = 0;
            int failure = 0;
            Console.WriteLine($"There are {Heisters.Count} people on your team");
            int teamSkill = 0;
            foreach (var item in Heisters)
            {
                Console.WriteLine($"Name:{item.Name} Skill Level: {item.SkillLevel} Courage Factor: {item.CourageFactor}");
                teamSkill += item.SkillLevel;
            }
            while (trialRuns > 0)
            {
                Random random = new Random();
                int luck = random.Next(-10, 10);

                bankDifficulty += luck;
                Console.WriteLine($"Your teams total skill is {teamSkill}");
                Console.WriteLine($"The bank difficultly when factoring in luck is: {bankDifficulty}");
                if (bankDifficulty > teamSkill)
                {
                    Console.WriteLine("so sorry, you no have success, enjoy spend life in jail.");
                    failure += 1;
                }
                else
                {
                    Console.WriteLine("Oooo very good, you can beat this bank with no jail time");
                    success += 1;
                }
                trialRuns -= 1;
            }

            Console.WriteLine($"In this test you had {success} successful bank robberies and {failure} failures");

        }
    }
}