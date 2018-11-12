using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace hw6.Models.FrontViewModel
{
    public class FEViewModel
    {
        //Model from People 
        public People People { get; set; }

        //Model from Customer
        public Customers Customers { get; set; }

        //Model from InvoiceLines
        public List<InvoiceLines> InvoiceLines { get; set; }
    }
}