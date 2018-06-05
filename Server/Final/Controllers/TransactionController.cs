using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final.Controllers
{
    public class TransactionController : ApiController
    {
        private mileageEntities repository = new mileageEntities();
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Transaction/5
        public IHttpActionResult Get(string id)
        {
            try
            {             //var result = repository.Masters.SingleOrDefault(b => b.Vehicle_No == id);
                id = "'" + id + "'";
                string q = " Select TOP(1) * from  mileage.dbo.[Transaction] where mileage.dbo.[Transaction].Vehicle_No =" + id + " ORDER BY End_Date DESC ";

                //List<Transaction> l = new List<Transaction>();
                var p =repository.Database.SqlQuery<Transaction>(q);
               

               /* List<Master> m = new List<Master>();
                foreach(var p in repository.Database.SqlQuery<Master>(q))
                {
                    m.Add(p);

                }*/

                /*List<Tuple<Master, Transaction>> f=new List<Tuple<Master, Transaction>>();
                for(int i=0;i<l.Count;i++)
                {
                    f.Add(Tuple.Create(m[i],l[i]));
                }*/




                return Ok(p);
            }
            catch(Exception ex)
            {
                return this.StatusCode(HttpStatusCode.BadRequest);
            }

        }

        public IHttpActionResult Get(string id, string type)
        {
            try
            {
                id = "'" + id + "'";
                type = "'" + type + "'";
                //select * from transaction where veh.num = "*****" and trip.type = "****" order by time
                string q = " Select TOP(1) * from  mileage.dbo.[Transaction] where mileage.dbo.[Transaction].Vehicle_No =" + id + "AND mileage.dbo.[Transaction].Ride_Type=" + type + " ORDER BY End_Date DESC ";
                var p = repository.Database.SqlQuery<Transaction>(q);
                return Ok(p);
            }
            catch(Exception ex)
            {
                return this.StatusCode(HttpStatusCode.BadRequest);

            }



        }


        // POST: api/Transaction
        public IHttpActionResult Post([FromBody]object value)
        {
            try
            {
                Transaction transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<Transaction>(value.ToString());
                repository.Transactions.Add(transaction);
                repository.SaveChanges();
                return this.StatusCode(HttpStatusCode.Accepted);
            }
            catch (Exception e)
            {
                return this.StatusCode(HttpStatusCode.InternalServerError);
            }

        }

        // PUT: api/Transaction/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Transaction/5
        public void Delete(int id)
        {
        }
    }
}
