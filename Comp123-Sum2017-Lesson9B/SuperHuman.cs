using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Description: This is the super human class extends the human abstract class
 * Version:0.1 Created the super human class
 * Version:0.2 Added _initializer method;
 */
namespace Comp123_Sum2017_Lesson9B
{
    /// <summary>
    /// This is the super human class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variables
      /// <summary>
      /// This is the main constructor
      /// </summary>
        private List<Power> _powers;
        //Public properties
        //Constructors
        public SuperHuman(string name):base(name)
        {
            this._initializer();
        }
        //Private methods
        private void _initializer()
        {
            this._powers = new List<Power>();//creates an empty list
        }
        //Public methods
    }
}