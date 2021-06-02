using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=LAPTOP-7OAJ4C6N\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] //marks method as post
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml"); // ~ tilda is a relative sign meaning the root
                                                            // if any of results returned are null or void return error message
            }
            else 
            {
               
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES 
                    (@FirstName, @LastName, @EmailAddress) ";
                using (SqlConnection connection =new SqlConnection(connectionString ))
                {       //inserts into form
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName; //assigning values
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success"); //server validation
            }
        }
        public ActionResult Admin()
        {
            using (NewsletterEntities db = new NewsletterEntities()) //instatitated the entity object. we now have access to the database here.
            {
                var signups = db.SignUps; //property in signups represents all the records in out database.
                var signupVMS = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignupVM(); // mapping properties
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupVMS.Add(signupVM);
                }

                return View(signupVMS); //passing list to the view
            }
                
                
                //populated a list of newsletter signups
                //    string querystring =@"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";

                //    List<NewsletterSignUp> signups = new List<NewsletterSignUp>(); // initialize as empty list

                //using (SqlConnection connection = new SqlConnection(connectionString)) //open a connection and wrap it a using statement 
                //{
                //    SqlCommand command = new SqlCommand(querystring, connection); //generate a command

                //    connection.Open(); //open connection

                //    SqlDataReader reader = command.ExecuteReader(); //create a datareader
                //    while (reader.Read()) 
                //    {       //ADO.net logic
                //        var signup = new NewsletterSignUp(); // declaring a new data type
                //        signup.Id = Convert.ToInt32(reader["Id"]); //assign properties values coming from database
                //        signup.FirstName = reader["FirstName"].ToString(); //things that come from database are a different datatype  
                //        signup.LastName = reader["LastName"].ToString();
                //        signup.EmailAddress = reader["EmailAddress"].ToString();
                //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                //        signups.Add(signup);  //adding the list


                //    }
                // }
           
        }
    }
}