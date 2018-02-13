using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace MMAWorkoutGenerator.Models
{
    public class Workout
    {
        public string workoutName { get; set; }
        //public LinkedList<Exercise> workout { get; set; }
        public byte workoutLength { get; set; }
        public string workoutSkill { get; set; }

        /*public LinkedList<Exercise> createWorkout()
        {
            LinkedList<Exercise> exerciseList = new LinkedList<Exercise>();
            //var con = ConfigurationManager.ConnectionStrings["Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daryan\Desktop\MMAWorkoutGenerator\MMAWorkoutGenerator\MMAWorkoutGenerator\App_Data\Exercises.mdf;Integrated Security=True"].ToString();
            using(SqlConnection myConnection = new SqlConnection(con))
            {

            }
            return exerciseList;
        }*/
    }
}