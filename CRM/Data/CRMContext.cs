using Microsoft.EntityFrameworkCore;
using CRM.Models;
using System.Collections.Generic;

namespace CRM.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}