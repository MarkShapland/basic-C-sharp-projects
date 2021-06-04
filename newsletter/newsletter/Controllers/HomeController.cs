using newsletter.Models;
using newsletter.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newsletter.Controllers
    {
        public class HomeController : Controller
        {
        private  readonly string connectionString = @"Data Source=LAPTOP-7OAJ4C6N\SQLEXPRESS;Initial Catalog=Newsletter2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
            {
                return View();
            }
            [HttpPost] //whenever you are doing a post method you will need to put this tag/ mark as post 
            public ActionResult SignUP(string firstName, string lastName, string emailAddress) //Have to match a name attribute of input form
            {
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
                {
                    return View("~/Views/Shared/Error.cshtml"); //return view to error.cshtml in the shared folder
                }
                else
                {
                    
                    string querySting = @"INSERT INTO SignUPS (FirstName, LastName, EmailAddress) Values( @FirstName, @LastName, @EmailAddress)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(querySting, connection);//adding parameters
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                        command.Parameters.Add("@LastName", SqlDbType.VarChar);
                        command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                        command.Parameters["@FirstName"].Value = firstName; //adding parameters
                        command.Parameters["@LastName"].Value = lastName;
                        command.Parameters["@EmailAddress"].Value = emailAddress;


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    return View("Success"); //return  to success view page that was created
                }
            }
            
            public ActionResult Admin()
        {
            string querystring = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps"; //select porperties from the signup tables.  
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>(); //iniitalize as an empty list

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querystring, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.Id = Convert.ToInt32(reader["id"]);  // assigning the properties/ values coming from the database.
                    signup.FirstName = reader["FirstName"].ToString(); //objects coming from the database are a different datatype and need to be defined
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                    
                    signups.Add(signup); // add this newsletter signup list 
                }
            }
            var signupVMs = new List<SignUpVM>();
            foreach (var signup in signups)
            {
                var signupVM = new SignUpVM();
                signupVM.FirstName = signup.FirstName;
                signupVM.LastName = signup.LastName;
                signupVM.EmailAddress = signup.EmailAddress;

                signupVMs.Add(signupVM);

            }

            return View(signupVMs); //passes this list to the view
             }
            
        }
    }