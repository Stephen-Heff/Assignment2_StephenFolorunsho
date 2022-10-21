using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_StephenFolorunsho.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/Fball/{NumOfPlayers}/{P1NumOfPoints}/{P1NumOfFouls}/{P2NumOfPoints}/{P2NumOfFouls}{P3NumOfPoints}/{P3NumOfFouls}")]
        [HttpGet]

        public int Fball(int NumOfPlayers, int P1NumOfPoints, int P1NumOfFouls, int P2NumOfPoints, int P2NumOfFouls, int P3NumOfPoints, int P3NumOfFouls)
        {
            int P1Total = (P1NumOfPoints * 5) - (P1NumOfFouls * 3);
            int P2Total = (P2NumOfPoints * 5) - (P2NumOfFouls * 3);
            int P3Total = (P3NumOfPoints * 5) - (P3NumOfFouls * 3);
            int sum = P1Total + P2Total + P3Total;
            
            
            if ( sum > 120)
            {
                return
            }

        }

    }


    }
}
