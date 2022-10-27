using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_StephenFolorunsho.Controllers
{
    public class J3Controller : ApiController
    {/// <summary>
    /// Write a program for a snakes and ladder game that starts from 1 and add the user's input 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>

        [Route("api/J3/Snakes/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}/{input}")]
        [HttpGet]
        public dynamic Snakes(int input)
        {
            int spot = 1;
            string b = "You are now on square ";
            string a = "Enter sum of dice:";
            
            if(input !=  0)
            {
                
                if (spot + input <= 100)
                {
                    spot = spot + input;





                    if (spot == 9)
                    {
                        spot = 34;
                        return b + spot;
                    }
                    else if (spot == 40)
                    {
                        spot = 64;
                        return b + spot;
                    }
                    else if (spot == 67)
                    {
                        spot = 86;
                        return b + spot;
                    }
                    else if (spot == 99)
                    {
                        spot = 77;
                    }
                    else if (spot == 90)
                    {
                        spot = 48;
                        return b + spot;
                    }
                    else if (spot == 54)
                    {
                        spot = 19;
                        return b + spot;
                    }
                    else
                    {

                        return b + spot;
                    }
                }else if(spot == 100)
                {
                    return "You win";
                }
                else
                {
                    return "You Quit";
                }

            }
         
                return "You Quit";
            

            

        }
    }
}
