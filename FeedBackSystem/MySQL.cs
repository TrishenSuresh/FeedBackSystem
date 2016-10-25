using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FeedBackSystem
{

    class MySql
    {

        private readonly MySqlConnection _connection;

        public MySql()
        {
            const string server = "localhost"; 
            const string database = "feedbacksystem";
            const string user = "root";
            const string password = "1234";

            const string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            _connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show(@"Cannot connect to server. Make sure MySQL is running.");
                        break;
                    case 1045:
                        MessageBox.Show(@"Invalid username/password.");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                _connection.Dispose();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }

        public List<Applicant> GetApplicants()
        {

            List<Applicant> listOfApp = new List<Applicant>();

            MySqlCommand cmd = new MySqlCommand("SELECT FirstName, LastName, Email, positionapplied.File FROM feedbacksystem.applicant, feedbacksystem.positionapplied where applicant.ApplicantID = positionapplied.ApplicantID", _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                
                byte[] pdf = (byte[])reader["File"];
                Applicant app = new Applicant(reader["FirstName"] + " " + reader["LastName"], reader["Email"] + "", pdf);
                listOfApp.Add(app);
                
            }
            return listOfApp;
        }

    }
}
