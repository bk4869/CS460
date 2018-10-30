using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using hw5.Models;

namespace hw5.DAL
{
    public class ApartRequestFormContext : DbContext
    {
        public ApartRequestFormContext() : base("name=RequestFormDB")
        {

        }

        public virtual DbSet<ApartRequestForm> ApartRequestForm { get; set; }

    }
}