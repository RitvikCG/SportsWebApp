using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsWebApplication1.Models;
using SportsWebApplication1.RequestModel;

namespace SportsWebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private readonly SportsContext _Sportscontext;
        public SportsController(SportsContext a)
        {
            _Sportscontext = a;   //dependency injection
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var getSports = _Sportscontext.SportsTable.ToList();
            return Ok(getSports);
        }

        // GET: api/Sports/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        } */
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            var result = _Sportscontext.SportsTable.First(obj => obj.Id == id);

            return Ok(result);

        }

        [HttpGet("Sports/{value}")]
        public IActionResult Get(string value)
        {

            var result = _Sportscontext.SportsTable.Where(obj => obj.SportsType.Contains(value));
            return Ok(result);
        }

        // POST: api/Sports
        [HttpPost]
        public void Post([FromBody] Class data)
        {
           SportsTable obj = new SportsTable();
            obj.SportsName = data.SportsName;
            obj.SportsType = data.SportsType;
            obj.MaxMembers = data.MaxMembers;
            _Sportscontext.SportsTable.Add(obj);
            _Sportscontext.SaveChanges();
        }

        // PUT: api/Sports/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
