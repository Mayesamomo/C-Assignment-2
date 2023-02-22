using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{availability}")]
        public string SpecialEvent(string availability)
        {

            // Split the input string into an array of individual strings for each person's availability
            string[] availabilityList = availability.Split('-');

            // Define an array to keep track of the number of people who can attend each day
            int[] daysCount = new int[5];

            // Loop through each person's availability and count how many people can attend each day
            for (int i = 0; i < availabilityList.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (availabilityList[i][j] == 'Y')
                    {
                        daysCount[j]++;
                    }
                }
            }

            // Find the maximum number of people who can attend any single day
            int maxCount = 0;
            foreach (int count in daysCount)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            // Build a string containing the day(s) on which the maximum number of people can attend
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                if (daysCount[i] == maxCount)
                {
                    // If there are multiple days with the maximum attendance, append them to the result string
                    if (result == "")
                    {
                        result += (i + 1).ToString();
                    }
                    else
                    {
                        result += "," + (i + 1).ToString();
                    }
                }
            }

            // If no one can attend, output "0" instead of an empty string
            if (result == "")
            {
                result = "0";
            }

            // Return the result string
            return result;
        }
            
    }
}
