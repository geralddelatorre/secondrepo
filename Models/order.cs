using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newtask.Models
{
    public class order
    {
        internal static int orno;
        internal static object ordate;
        //internal static object id;
       // internal static object orderid { get; set; }
       // internal static object orderno { get; set; }
       // internal static object orderdate { get; set; }
       // internal static object customername { get; set; }
       // internal static object totalamount { get; set; }
        public static object id { get; internal set; }
         public string orderid { get; set; }
        public string orderno { get; set; }
        public string orderdate { get; set; }
         public string customername { get; set; }
         public string totalamount { get; set; }
        

    }
}
