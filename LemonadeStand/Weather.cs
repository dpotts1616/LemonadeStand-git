using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        public string condition;
        public int temperature;
        List<string> weatherConditions;
        public string predictedForecast;
        public int predictedMin;
        public int predictedMax;


        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Cloudy", "Raining" };
            condition = GetCondition(weatherConditions);
            temperature = GetTemperature(condition);
            predictedForecast = GetPrediction(condition);
            predictedMin = temperature - 10;
            predictedMax = temperature + 10;
        }


        //methods
        public string GetCondition(List<string> conditions)
        {
            int rand = Program.GetRandomNumber(0, 4);
            return conditions[rand];
        }

        public int GetTemperature(string condition)
        {
            switch (condition)
            {
                case "Sunny":
                    return Program.GetRandomNumber(75, 100);
                case "Overcast":
                    return Program.GetRandomNumber(60, 80);
                case "Cloudy":
                    return Program.GetRandomNumber(50, 70);
                case "Raining":
                    return Program.GetRandomNumber(45, 60);
            }
            return 0;
        }

        public string GetPrediction(string condition)
        {
            int rand = Program.GetRandomNumber(0, 100);
            if (rand > 50)
            {
                return condition;
            }
            else
            {
                return GetCondition(weatherConditions);
            }
        }

    }
}
