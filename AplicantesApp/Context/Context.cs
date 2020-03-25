using Microsoft.EntityFrameworkCore;
using AplicantesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicantesApp.Context
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<AplicantesApp.Entities.Aplicante> Applicants { get; set; }
    }
}
