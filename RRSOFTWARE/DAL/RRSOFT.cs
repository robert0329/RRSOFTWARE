using RRSOFTWARE.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSOFTWARE.DAL
{
    public class RRSOFT: DbContext
    {
        public RRSOFT() : base("name = ConStr")
        {

        }
        public virtual DbSet<User> User { get; set; }
    }
}
