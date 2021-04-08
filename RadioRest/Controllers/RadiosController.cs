﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadioRest.Models;
using RadioRest.Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadioRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadiosController : ControllerBase
    {
        private RadioManager _manager = new RadioManager(); 
        // GET: api/<RadiosController>
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<RadiosController>/5
        [HttpGet("{id}")]
        public MusicRecord Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<RadiosController>
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            _manager.Add(value);
        }

        // PUT api/<RadiosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MusicRecord value)
        {
            
        }

        // DELETE api/<RadiosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}