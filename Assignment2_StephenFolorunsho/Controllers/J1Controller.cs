using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_StephenFolorunsho.Controllers
{

  
    public class J1Controller : ApiController
    {   /// <summary>
        ///the goal is to determine how many cupcakes will be left over if each student gets one cupcake
        /// </summary>
        /// <param name="regular * 8"> input * 8 as a regular box holds 8 cupcakes </param>
        /// <param name="small * 3"> input * 3 as the small box holds 3 boxes</param>
        /// <returns> output the number of cupcakes that are left over </returns>
        ///<example>
        /// GET: api/J1/Cupcake/{2}/{5} -> 3
        /// GET: api/J1/Cupcake/{2}/{4} -> 0
        ///</example>
        [Route("api/J1/Cupcake/{regular}/{small}")]
        [HttpGet]

        public int Cupcake(int regular, int small)
        {
            int total = (regular * 8) + (small * 3);
            int remainder = total - 28;
            return remainder;

        }

    }
}
