using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            weather = new Weather();
            customers = GenerateCustomers(weather);
        }

        //methods
        public List<Customer> GenerateCustomers(Weather weather)
        {
            int conditionWeighting = GetConditionWeighting(weather.condition);
            int temperatureWeighting = weather.temperature - (weather.temperature/conditionWeighting);
            return GenerateList(temperatureWeighting);
        }

        public int GetConditionWeighting(string input)
        {
            switch (input)
            {
                case "Sunny":
                    return Program.GetRandomNumber(8,10);
                case "Cloudy":
                    return Program.GetRandomNumber(6, 10);
                case "Overcast":
                    return Program.GetRandomNumber(3, 9);
                case "Raining":
                    return Program.GetRandomNumber(0, 5);
            }
            return 0;
        }

        public List<Customer> GenerateList(int totalCustomers)
        {
            customers = new List<Customer>();
            for (int i = 0; i < totalCustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
            return customers;
        }
    }
}
