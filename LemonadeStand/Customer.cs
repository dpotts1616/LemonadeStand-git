using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        double priceTolerance;
        double weatherTolerance;
        double lemonTolerance;
        double sugarTolerance;

        //constructor
        public Customer()
        {
            priceTolerance = GenerateTolerance();
            weatherTolerance = GenerateTolerance();
            lemonTolerance = GenerateTolerance();
            sugarTolerance = GenerateTolerance();
        }

        //methods
        public int GenerateTolerance()
        {
            return Program.GetRandomNumber(0, 20);
        }
        //make decision
        //bring in weather, recipe
        public void MakeDecision(Weather weather, Recipe recipe)
        {
            //price tolernce vs price
            //weather tolerance vs weather
            //lemon vs lemons
            //sugar vs sugarcubes
        }
    }
}
