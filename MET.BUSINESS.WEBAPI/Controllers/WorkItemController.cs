using MET.BUSINESS.DAL.Repository;
using MET.BUSINESS.WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MET.BUSINESS.WEBAPI.Controllers
{
    public class WorkItemController : ApiController
    {
        // GET: api/WorkItem
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/WorkItem
        //public IEnumerable<WorkItemModel> Get()
        //{
        //    var model = new WorkItemModel();

        //    return model.MyWorkItems();

        //    //return model.MyWorkItemNumbers();
        //}


        // GET: api/GetAllWorkItems
        [Route("api/GetAllWorkItems")]
        [HttpGet]
        public IEnumerable<WorkItemModel> GetAllWorkItems()
        {
            var model = new WorkItemModel();

            return model.MyWorkItems();
        }

        //// GET: api/WorkItem/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/WorkItem
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/WorkItem/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/WorkItem/5
        //public void Delete(int id)
        //{
        //}
    }
}
