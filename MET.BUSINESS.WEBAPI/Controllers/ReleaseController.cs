using MET.BUSINESS.WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MET.BUSINESS.WEBAPI.Controllers
{
    public class ReleaseController : ApiController
    {
        //// GET: api/Release
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Release/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Release
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Release/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Release/5
        //public void Delete(int id)
        //{
        //}


        [Route("api/GetNoOfRelTskByUserSeq/{seq}")]
        [HttpGet]
        public IEnumerable<ReleaseModel> Get(long seq)
        {
            var model = new ReleaseModel();

            return model.GetReleaseUserAccessListByUserSeq(seq);
        }

        [Route("api/GetReleaseDetailsBySeq/{seq}")]
        [HttpGet]
        public ReleaseModel GetReleaseDetails(long seq)
        {
            var model = new ReleaseModel();

            return model.GetReleaseDetailsBySeq(seq);
        }
    }
}
