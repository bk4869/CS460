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
        /// <summary>
        /// DB and Application Connection String
        /// </summary>
        public ApartRequestFormContext() : base("name=RequestFormDB")
        {

        }

        /// <summary>
        /// Allow Action betweem App and DB
        /// </summary>
        public virtual DbSet<ApartRequestForm> ApartRequestForm { get; set; }

    }
}