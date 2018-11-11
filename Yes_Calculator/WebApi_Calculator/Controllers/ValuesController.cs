using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Calculator.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
            //return "hello Orly";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /*
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        */


        [Route("api/values/{num1}/{num2}/")]
        //public HttpResponseMessage Put(double num1, double num2, [FromBody]string sign)
        public double Put(double num1, double num2, [FromBody]string sign)
        {
            switch (sign)
            {
                case "+":
                    {//return Request.CreateResponse(HttpStatusCode.OK, num1 + num2);
                        return num1 + num2; 
                    }
                case "-":
                    // return Request.CreateResponse(HttpStatusCode.OK, num1 - num2);
                    return num1 - num2;
                case "*":
                    {
                       // return Request.CreateResponse(HttpStatusCode.OK, num1 * num2);
                       return num1 * num2;
                    }
                case "/":
                    {
                        if (num2 == 0)
                            //return Request.CreateResponse(HttpStatusCode.NotAcceptable, "error! : divition 0 unsupported!.");  
                            return -111;
                        else
                            return num1 / num2;//Request.CreateResponse(HttpStatusCode.OK, num1 / num2);
                    }
            }
            return -111;
            //return Request.CreateResponse(HttpStatusCode.NotAcceptable, "error! : the opparation not supportred!.");
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
