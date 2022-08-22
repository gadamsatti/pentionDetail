using Microsoft.AspNetCore.Mvc;
using PentionDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PentionDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PentionDetailsController : ControllerBase
    {

        public PentionDetailDb db { get; set; }

        public PentionDetailsController(PentionDetailDb _db)
        {
            db = _db;

        }


        // GET: api/<ValuesController>
        [HttpGet("details")]
        public ActionResult GetDetails()
        {
             var details = db.PentionDetails.ToList();
             return Ok(details);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult GetDetailByAadhar(string id)
        {
            var detail = db.PentionDetails.Where(i => i.Aadhar == id).FirstOrDefault();
            return Ok(detail);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult AddDetails([FromBody]PentionDetailModel details)
        {
            db.PentionDetails.Add(details);
            db.SaveChanges();
            return Ok(details.Aadhar);


        }
    }
}
