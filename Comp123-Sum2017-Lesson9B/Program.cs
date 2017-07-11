using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Version:0.4 Added another power to super human class 
 - Also displayed all  the powers in the powers list*/
 
namespace Comp123_Sum2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("superdude");
            superhuman.AddedPower("SpiderClimbing", 50);
            superhuman.AddedPower("Webcasting", 40);
            superhuman.DiplayPower();
            
        }
    }
}
