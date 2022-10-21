using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_StephenFolorunsho.Controllers
{
    public class JtwoController : ApiController
    {
		/// <summary>
		/// Write aprogram that will take a short form of a word and output the translation
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		/// <example>
		/// GET: api/Jtwo/speak/{CU} -> see you
		/// GET: api/Jtwo/speak/{CUZ} -> because
		/// </example>
		[Route("api/Jtwo/speak/{input}")]
		[HttpGet]

		public string speak(string input)
        {
			
			while (true)
			{

				if (input == "CU")
				{
					return "see you";
				}
				else if (input == ":-)")
				{
					return "I'm happy";
				}
				else if (input == ":-(")
				{
					return "I'm unhappy";
				}
				else if (input == ";-)")
				{
					return "wink";
				}
				else if (input == ":-P")
				{
					return "stick out my tongue";
				}
				else if (input == "(~.~)")
				{
					return "sleepy";
				}
				else if (input == "TA")
				{

					return "totally awesome";
				}
				else if (input == "CCC")
				{
					return "Canadian Computing Competition";
				}
				else if (input == "CUZ")
				{
					return "because";
				}
				else if (input == "TY")
				{
					return "thank-you";
				}
				else if (input == "YW")
				{
					return "you're welcome";
				}
				else if (input == "TTYL")
				{
					return "talk to you later";
					
				}
				else
				{
					return input;
				}
				
				
			}
			
		}
    }
}
