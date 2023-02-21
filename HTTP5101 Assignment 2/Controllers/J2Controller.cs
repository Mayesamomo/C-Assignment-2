using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        ///Calculates the number of ways to get a sum of 10 with two dice.
        /// </summary>
        /// <param name="m">The number of sides on the first die.</param>
        /// <param name="n">The number of sides on the second die.</param>
        /// <returns>A string message stating the number of ways to get a sum of 10.</returns>
        /// api/J2/DiceGame/{5}/{5} -> There is 1 way to get the sum

        [HttpGet]
        [Route ("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
           
            int count = 0;
            //One dice has m sides labelled 1, 2, 3 ..., m
            for (int i = 1; i <=m; i++)
            {
                //The other dice has n sides labelled 1, 2, 3, ..., n, inner loop
                for(int j = 1; j <=n; j++)
                {
                    if(i +j == 10)
                    {
                        count++;
                    }
                }
            }

            if(count ==0)
            {
                return "There are 0 ways to get the sum of 10";
            }
            else if(count == 1)
            {
                return "There is 1 way to get the sum";
            }
            else
            {
                return "There are " + count + " total ways to get the sum 10";
            }
        }
    }
}
