using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Heister> Heisters = new List<Heister>();
            Console.WriteLine("Plan your heist");
            Console.WriteLine();
            while (true)
            {
                Heister teamMember;
                Console.WriteLine("What is the team member's name?");
                string name = Console.ReadLine();
                if (name == "")
                {
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

            Console.WriteLine($"There are {Heisters.Count} people on your team");
            foreach (var item in Heisters)
            {
                Console.WriteLine($"Name:{item.Name} Skill Level: {item.SkillLevel} Courage Factor: {item.CourageFactor}");
            }

        }
    }
}