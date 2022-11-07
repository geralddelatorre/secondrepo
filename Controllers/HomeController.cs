using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newtask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace newtask.Controllers
{
    public class HomeController : Controller
    {
        //public string constring = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2019;Initial Catalog = geralddb; Integrated Security = True";
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        public List<order> orders = new List<order>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           con.ConnectionString = newtask.Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {

            FetchData();
            return View(orders);

           





        }
        private void FetchData()
        {
            if (orders.Count > 0)
            {
                orders.Clear();
                
                 
            }

            try
            {

                con.Open();
                com.Connection = con;
                com.CommandText = " SELECT * FROM tbl_order";
                //com.CommandText = "SELECT TOP (1000) [id] ,[order_no] ,[order_date] ,[customer_name] ,[total_amount] FROM [geralddb].[dbo].[tbl_order]";
                
                //string qe = "SELECT * FROM tbl_order";
                //SqlConnection con = new SqlConnection(constring);
                //SqlCommand cmd = new SqlCommand(qe, con);
                //cmd.ExecuteNonQuery();
                //SqlConnection con = new SqlConnection(constring);
               
                //SqlCommand command = new SqlCommand("SELECT * FROM tbl_order", con);
                //SqlDataReader dr = command.ExecuteReader();
               dr = com.ExecuteReader();



                while (dr.Read())
                {

                    orders.Add(new order() {  
                     orderno = dr["order_no"].ToString()
                    ,orderdate = dr["order_date"].ToString()
                     ,customername = dr["customer_name"].ToString()
                     ,totalamount = dr["total_amount"].ToString()
                     });


                    // order orders = new order();
                    //order.id = ""+ dr.GetInt32(0);
                    //order.orno = dr.GetInt32(1);
                    //order.ordate = 
                    


                }
                
        con.Close();

            }
            catch (Exception x)
            {
                throw x;

            }
            
        }

        //------SEE DETAILS HERE!!--------

        private void seedetails()
        {
            String id = Request.Query["id"];
            if (orders.Count > 0)
            {
                orders.Clear();


            }

            try
            {
               
                con.Open();
                com.Connection = con;
                //com.CommandText = " SELECT * FROM tbl_order WHERE order_no =  '" +  + "'";
                //com.CommandText = "SELECT TOP (1000) [id] ,[order_no] ,[order_date] ,[customer_name] ,[total_amount] FROM [geralddb].[dbo].[tbl_order]";
                com.CommandText = " SELECT * FROM tbl_order WHERE order_no = '"+id+"'";
                //string qe = "SELECT * FROM tbl_order";
                //SqlConnection con = new SqlConnection(constring);
                //SqlCommand cmd = new SqlCommand(qe, con);
                //cmd.ExecuteNonQuery();
                //SqlConnection con = new SqlConnection(constring);

                //SqlCommand command = new SqlCommand("SELECT * FROM tbl_order", con);
                //SqlDataReader dr = command.ExecuteReader();
                dr = com.ExecuteReader();



                while (dr.Read())
                {

                    orders.Add(new order()
                    {
                        orderno = dr["order_no"].ToString()
                    ,
                        orderdate = dr["order_date"].ToString()
                     ,
                        customername = dr["customer_name"].ToString()
                     ,
                        totalamount = dr["total_amount"].ToString()
                    });

                    // order orders = new order();
                    //order.id = ""+ dr.GetInt32(0);
                    //order.orno = dr.GetInt32(1);
                    //order.ordate = 



                }
                con.Close();

            }
            catch (Exception x)
            {
                throw x;

            }
        }
        public IActionResult Privacy()
        {
            
            seedetails();
            return View(orders);

        }

        


        public class info
        {
            public String id;
            
            public String ordate;
            public String cusname;
            public String totamount;

        }
        public void OnGet()
        {
            String id = Request.Query["id"];
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
