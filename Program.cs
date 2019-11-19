using System;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist");
            Console.WriteLine();
            Heister teamMember; 

            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();

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
                CourageFactor = decimal.Parse(courageFactor)
            };
            Console.WriteLine($"name: {teamMember.Name}");
            Console.WriteLine($"skill level: {teamMember.SkillLevel}");
            Console.WriteLine($"courage factor: {teamMember.CourageFactor}");
        }
    }
}
