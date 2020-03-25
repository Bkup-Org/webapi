using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicantesApp.Controllers
{
    
    [Route("api/[controller]")]

    public class AplicanteController : Controller
    {
        private readonly AplicantesApp.Context.Context context;

        public AplicanteController(AplicantesApp.Context.Context context)
        {
            this.context = context;
        }
        // GET: api/Aplicante
        [HttpGet]
        public IEnumerable<AplicantesApp.Entities.Aplicante> Get()
        {
            return context.Applicants.ToList();
        }

        // GET: api/Aplicante/5
        [HttpGet("{id}", Name = "Get")]
        public AplicantesApp.Entities.Aplicante Get(int id)
        {
            var aplicante = context.Applicants.FirstOrDefault(p => p.codigo == id);
            return aplicante;
        }

        // POST: api/Aplicante
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Aplicante/5
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
