using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Version:0.6 Implemented SuperVillain Class
 */
 
namespace Comp123_Sum2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero supervillain = new SuperHero("SuperHero dude",20);
            supervillain.AddedPower("SpiderClimbing", 50);
            supervillain.AddedPower("Webcasting", 40);
            supervillain.AddedPower("Phasing", 30);
            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Karma: " +supervillain.Malice);
            
        }
    }
}
