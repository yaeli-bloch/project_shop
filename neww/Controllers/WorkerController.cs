﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace neww.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IDataContext? _context;
        public WorkerController(IDataContext? context)
        {
            _context = context;
        }
        // GET: api/<WorkerController>
        [HttpGet]
        public List<Worker> Get()
        {
            return _context.listWorkers;
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public Worker Get(string id)
        {
            return _context.listWorkers.Find(work => work.Id == id);
        }
        [HttpGet("point/{id}")]
        public int Getp(string id)
        {
            return _context.listWorkers.Find(work => work.Id == id).NumCustomer;
        }

        // POST api/<WorkerController>
        [HttpPost]
        public void Post([FromBody] Worker worker)
        {
            _context.listWorkers.Add(worker);
        }

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
