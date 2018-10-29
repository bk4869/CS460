using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using hw5.Models;

namespace hw5.DAL
{
    public class FormContext : DbContext
    {
        public FormContext() : base("name=ApartDB")
        {

        }

        public virtual DbSet<ApartRequestForm> ApartRequestForm { get; set; }

    }
}