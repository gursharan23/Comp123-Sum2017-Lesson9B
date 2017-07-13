using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Description: This is the SuperHero class that inherits from SuperHuman Class
 * and implements the IHasKarma Interface.
 * Version:0.1 Created the SuperHero Class
 */
namespace Comp123_Sum2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHero Class
    /// </summary>
    public class SuperHero : SuperHuman,IHasKarma
    {
        //Private Instance variables
        private int _Karma;
        //Public Properties
        public int Karma
        {
            get
            {
                return this._Karma;
            }
            set
            {
                this._Karma = value;
            }
        }
        //Constructors
        /// <summary>
        /// Thisi sthe constructor for SuperHero Class
        /// It takes one argument - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name)
            : base(name)
        {
        }

        //Private Methods

        //Public Methods
    }
}