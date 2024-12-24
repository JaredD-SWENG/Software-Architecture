using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Proxy_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Class designed to extend the behavior of TV by allowing the user to now order Brand name TVs.
/// </summary>
namespace Lab08
{
    public class Proxy_TV:TV, TV_IF
    {
        protected TV regularTV;

        public override TV replenishTV(int budget)
        {
            // TV: 200, SMartTV: 300, ULTRAHD TV: 400, VizioTV: 250, VizioSmartTV: 350, Vizio UltraHD: 450, Sony: 280, SonySmart: 380, Sony UltraHD 480
            //Read from file TV_Types.txt
            //eachline consists of: ObjectName price
            //Read line, split using whitespace into a string and a int.
            //Fill dicitonary with values.
            //compare int values to budget, return closest number that is not greater than budget.
            //Use object name string to dynamically create object.
            //return object.

            Dictionary<string, int> tvTypes = new Dictionary<string, int>();

            StreamReader sr = File.OpenText("..\\..\\..\\..\\Lab08//TV_Types.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] temp = line.Split(" ");
                tvTypes.Add(temp[0], Convert.ToInt32(temp[1]));
                line = sr.ReadLine();
            }

            string budgetTV = " ";
            int minDifference = budget;
            foreach(KeyValuePair<string, int> kvp in tvTypes)
            {
                int difference = budget - kvp.Value;
                if(difference >= 0)
                {
                    if(difference <= minDifference)
                    {
                        minDifference = difference;
                        budgetTV = kvp.Key;
                    }
                }
            }



            string target = "Lab08." + budgetTV;
            TV tv;
            if (budgetTV == " ")
            {
                Console.WriteLine("There are no TVs that fit in the provided budget.");
                tv = null;
            }
            else if(budgetTV == "TV" || budgetTV == "Smart_TV" || budgetTV == "UltraHD_TV")
            {
                Type t = Type.GetType(target);
                tv = (TV)Activator.CreateInstance(t);
                tv.setPrice(tvTypes[budgetTV]);
            }
            else
            {
                Type t = Type.GetType(target);
                tv = (TV)Activator.CreateInstance(t);
                tv.setPrice(tvTypes[budgetTV]);
            }
                
            return tv;
        }

        public override void getInfo()
        {
            base.getInfo();
            if  (regularTV != null) Console.WriteLine("Power Usage: " + ((Smart_TV)regularTV).getPowerUsage());
        }
    }
}
