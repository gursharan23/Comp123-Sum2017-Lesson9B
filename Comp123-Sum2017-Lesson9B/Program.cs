using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Version:0.2 Added object of typer superhuman
 */
namespace Comp123_Sum2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("superdude");
            superhuman.Powers.Add(new Power("Spider climbing",50));
        }
    }
}
