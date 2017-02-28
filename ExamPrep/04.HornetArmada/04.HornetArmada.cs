

namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            char[] split = { ' ', '=', '-', '>', ':' };
            int num = int.Parse(Console.ReadLine());
            List<Legion> legions = new List<Legion>();
            string currentSoldierType;

            List<string> legionNames = new List<string>();
            List<string> soldierTypes = new List<string>();
            Dictionary<string, int> nameAndActvity = new Dictionary<string, int>();

            for (int i = 0; i < num; i++)
            {
                var inputInfo = Console.ReadLine()
                    .Split(split, StringSplitOptions.RemoveEmptyEntries);
                Legion currentLegion = new Legion();
                currentLegion.LastActivity = int.Parse(inputInfo[0]);
                currentLegion.Name = inputInfo[1];
                currentSoldierType = inputInfo[2];
                //
                currentLegion.SoldierCoun = int.Parse(inputInfo[3]);
                if (nameAndActvity.ContainsKey(currentLegion.Name))
                {
                    if (nameAndActvity[currentLegion.Name] > currentLegion.LastActivity)
                    {
                        if (currentLegion.SoldierType.Contains(currentSoldierType))
                        {
                            nameAndActvity[currentLegion.Name] += currentLegion.LastActivity;
                        }
                        else
                        {
                            currentLegion.SoldierType.Add(currentSoldierType);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    nameAndActvity.Add(currentLegion.Name, currentLegion.LastActivity);
                }

            }



            //check if the name of the legion exist
            //if true, check if the new activity is greater
            //then update the info - if the soldier type doesnt exist - add it
            //if exist - add the count
            //update activity if new acticity is greater!


            //Legions.Add(currentLegion);
        }

    }
}

