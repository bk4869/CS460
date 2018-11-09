using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace hw6.Models.FrontViewModel
{
    public class FEViewModel
    {

        public People People { get; set; }

        public Customers Customers { get; set; }

        public List<InvoiceLines> InvoiceLines { get; set; }
    }
}