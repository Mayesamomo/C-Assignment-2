using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total calories base on menu selection.
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns></returns>
        ///
        [HttpGet]
        [Route("api/J1/CalcTotalCalories/{burger}/{drink}/{side}/{dessert}")]
        public string CalcTotalCalories(int burger, int drink, int side, int dessert)
        {
            // Define the calorie values for each menu item,
            //the calories for each menu is stored in an array.

            /**
             * Here are the 3 burger choices:
               [0] 1 - Cheeseburger (461 Calories)
               [1] 2 - Fish Burger (431 Calories)
                [2]3 - Veggie Burger (420 Calories)
               [3] 4 - no burge
                Here are the three drink choices:
                [0]1 - Soft Drink (130 Calories)
                [1]2 - Orange Juice (160 Calories)
                [2]3 - Milk (118 Calories)
                [3]4 - no drink

             */
            // an array of  3 burger choices: menu calories
            int[] burgerCalories = { 0, 461, 431, 420 }; // 0 for no burger

            // an array of  three drink choices: menu calories
            int[] drinkCalories = { 0, 130, 160, 118 }; // 0 for no drink

            // an array of  3 side order choices: menu calories
            int[] sideCalories = { 0, 100, 57, 70 }; // 0 for no side

            // an array of  3  dessert choices:menu calories
            int[] dessertCalories = { 0, 167, 266, 75 }; // 0 for no dessert

            // Compute the total calories
            int totalCalories = burgerCalories[burger] + drinkCalories[drink] + sideCalories[side] + dessertCalories[dessert];

            // Return the result
            return $"Your total calorie count is {totalCalories}";
        }
    }
}
