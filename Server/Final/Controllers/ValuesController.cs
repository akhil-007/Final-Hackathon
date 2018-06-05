using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final.Controllers
{
    public class ValuesController : ApiController
    {
        private mileageEntities repository = new mileageEntities();
        // GET api/values
        public IHttpActionResult Get()
        {
            try
            {
                List<Master> m = new List<Master>();
                foreach (var o in repository.Masters)
                {
                    m.Add(o);
                }
                return Ok(m);
            }
            catch (Exception e)
            {
                return this.StatusCode(HttpStatusCode.InternalServerError);
            }
        }

        //return new string[] { "value1", "value2" };


        // GET api/values/5
        public IHttpActionResult Get(string id)
        {
            var result = repository.Masters.SingleOrDefault(b => b.Vehicle_No == id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return this.StatusCode(HttpStatusCode.BadRequest);
            }

        }

        

        // POST api/values
        public IHttpActionResult Post([FromBody]object value)
        {
            try
            {
                Master master = Newtonsoft.Json.JsonConvert.DeserializeObject<Master>(value.ToString());
                /*foreach(var m in repository.Masters)
                {
                    if(m.Vehicle_No==master.Vehicle_No)
                    {
                        return this.StatusCode(HttpStatusCode.BadRequest);
                    }
                }*/
                repository.Masters.Add(master);
                repository.SaveChanges();
                //updateES();
                return this.StatusCode(HttpStatusCode.Accepted);
            }
            catch (Exception ex)
            {
                return this.StatusCode(HttpStatusCode.InternalServerError);
            }
        }

        // PUT api/values/5
        public IHttpActionResult Put([FromBody]object value)
        {
            Master master = Newtonsoft.Json.JsonConvert.DeserializeObject<Master>(value.ToString());
            try
            {
                var result = repository.Masters.SingleOrDefault(b => b.Vehicle_No == master.Vehicle_No);
                if (result != null)
                {
                    result.Vehicle_Type = master.Vehicle_Type;
                    result.Wheel_Type = master.Wheel_Type;
                    result.Year = master.Year;
                    result.Model = master.Model;
                    result.Manufacturer = master.Manufacturer;
                    result.Fuel_Capacity = master.Fuel_Capacity;
                    repository.SaveChanges();
                    // updateES();
                    return this.StatusCode(HttpStatusCode.Accepted);
                }
                else
                {
                    return this.StatusCode(HttpStatusCode.BadRequest);
                }


            }
            catch (Exception ex)
            {
                return this.StatusCode(HttpStatusCode.InternalServerError);
            }
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(string id)
        {
            bool present = false;
            foreach (var a in repository.Masters)
            {
                if (a.Vehicle_No == id)
                {
                    repository.Masters.Remove(a);
                    present = true;
                }
                if (present == true)
                    break;

            }
            if (present == true)
            {
                repository.SaveChanges();
                //updateES();
                return this.StatusCode(HttpStatusCode.Accepted);
            }
            else
            {
                return this.StatusCode(HttpStatusCode.BadRequest);
            }

        }
    }

}
