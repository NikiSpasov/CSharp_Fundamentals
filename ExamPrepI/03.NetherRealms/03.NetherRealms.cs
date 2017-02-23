using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Deamon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}
class Program
{
    static void Main()
    {
        //прочитаме имената:
        var deamonsNames = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int multiply = 0;
        int divide = 0;
        string deamonName = string.Empty;
        StringBuilder currentNum = new StringBuilder();
        List<Deamon> deamons = new List<Deamon>();

        foreach (var name in deamonsNames)
        {
            int deamonHealth = 0;
            double damage = 0.00;
            Deamon currentDeamon = new Deamon();
            currentDeamon.Name = name;
            //получаваме името в масив от чарове:
            char[] nameInChars = name.ToCharArray();

            //обхождаме името символ по символ:
            foreach (var charFromName in nameInChars)
            {
                //ако е буква:
                if ((charFromName > 64 && charFromName < 91) || (charFromName > 96 && charFromName < 123))
                { //намираме здравето, след като се извърти цикъла;
                    deamonHealth += charFromName;
                }
                else if (charFromName == '*')
                {
                    multiply += 2;
                }
                else if (charFromName == '/')
                {
                    divide += 2;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < nameInChars.Length; i++)
            {
                if (nameInChars[i] == '-' || char.IsDigit(nameInChars[i]) || nameInChars[i] == '.')
                {
                    while (nameInChars[i] == '-' || char.IsDigit(nameInChars[i]) || nameInChars[i] == '.')
                    {
                        currentNum.Append(nameInChars[i]);
                        i++;
                    }
                    var numToString = currentNum.ToString();
                    double num = double.Parse(numToString);
                    damage += num;
                    currentNum.Clear();
                }
            }
            double finalDamage = damage;
            if (multiply > 0)
            {
                finalDamage = finalDamage * multiply;
            }
            else if (divide > 0)
            {
                finalDamage = finalDamage / divide;
            }
            currentDeamon.Damage = finalDamage;
            currentDeamon.Health = deamonHealth;
            deamons.Add(currentDeamon);
        }
        foreach (Deamon deamon in deamons.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{deamon.Name} - {deamon.Health} health, {deamon.Damage:0.00} damage");
        }

    }
}

