using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoStudentData.Models;
using System.Data;

using System.Data.SqlClient;


namespace DemoStudentData.Controllers
{
    public class StudentController : Controller
    {
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=SchoolManagementSystem;Trusted_Connection=True;";
        // GET: Student
        public ActionResult Index()
        {
            List<User> users = new List<User>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SaveStudent", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user  = new User();
                user.Id = Convert.ToInt32(reader["Id"]);
                user.Name = reader["Name"].ToString();
                user.Malayalam = Convert.ToInt32(reader["Malayalam"]);
                user.English = Convert.ToInt32(reader["English"]);
                user.Maths = Convert.ToInt32(reader["Maths"]);
                users.Add(user);
            }

            return View(users);
        }
    }
}