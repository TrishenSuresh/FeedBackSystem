﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System;
using System.Security.Cryptography;
using System.Text;

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

            const string connectionString =
                "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password +
                ";";

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
                    default:
                        MessageBox.Show(e.Message);
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

            MySqlCommand cmd =
                new MySqlCommand(
                    "SELECT applicant.ApplicantID,FirstName, LastName, Email, positionapplied.File FROM feedbacksystem.applicant, feedbacksystem.positionapplied where applicant.ApplicantID = positionapplied.ApplicantID",
                    _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                byte[] pdf = (byte[]) reader["File"];
                Applicant app = new Applicant(reader["ApplicantID"].ToString(),reader["FirstName"] + " " + reader["LastName"], reader["Email"] + "", pdf);
                listOfApp.Add(app);

            }
            reader.Close();
            return listOfApp;
        }

        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();

            MySqlCommand cmd =
                new MySqlCommand(
                    "SELECT * FROM feedbacksystem.positions",
                    _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                positions.Add(new Position(reader["PositionID"].ToString(),reader["Name"].ToString(),reader["Desc"].ToString(),reader["Department"].ToString(),reader["MinQualification"].ToString()));

            }
            reader.Close();

            return positions;
        }

        // Get the data set generated by the sqlStatement
        public DataTable GetDataSet(string sqlStatement)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
            }
            catch (Exception genExp)
            {
                MessageBox.Show(genExp.Message);
            }

            //return the dataTable
            return dataTable;
        }

        //Get datatable from cmd ( use if want to avoid sql injection )
        public DataTable GetDataSetCmd(MySqlCommand cmd)
        {
            DataTable dataTable = new DataTable();
            cmd.Connection = _connection;
            try
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
            }
            catch (Exception genExp)
            {
                MessageBox.Show(genExp.Message);
            }

            //return the dataTable
            return dataTable;
        }

        //Get header item list
        public List<string> GetHeaderList(string headerItemId)
        {
            List<string> list = new List<string>();
            DataTable dataTable = new DataTable();
            string sqlStatement =
                "SELECT headeritemlist.List FROM feedbacksystem.headeritemlist,feedbacksystem.headeritem " +
                "where headeritemlist.HeaderItemID = headeritem.HeaderItemID and headeritem.HeaderItemID = @HeaderItemID";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection);
                cmd.Parameters.AddWithValue("@HeaderItemID", headerItemId);


                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    list.Add(row["List"].ToString());
                }
            }
            catch (Exception genExp)
            {
                MessageBox.Show(genExp.Message);
            }

            //return the list
            return list;
        }

        public List<Section> GetSectionsList()
        {
            List<Section> sectionList = new List<Section>();
            DataTable dataTable = new DataTable();

            string sqlStatement = "SELECT * FROM feedbacksystem.sections";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }

                    foreach (DataRow row in dataTable.Rows)
                    {
                        sectionList.Add(new Section(row["SectionID"].ToString(),row["Title"].ToString(),row["Desc"].ToString()));
                    }
                }

                foreach (Section section in sectionList)
                {
                    List<String> codes = getSectionCodes(section.SectionId);
                    section.Codes = codes;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return sectionList;
        }

        public List<string> getSectionCodes(string sectionId)
        {
            List<string> codes = new List<string>();

            MySqlCommand cmd =
                new MySqlCommand(
                    "SELECT codes.Code FROM sections,section_code,codes where sections.SectionID = section_code.SectionID and section_code.CodesID = codes.CodesID and sections.SectionID = @SectionID",
                    _connection);

            cmd.Parameters.AddWithValue("@SectionID", sectionId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                codes.Add(reader["Code"].ToString());
            }
            reader.Close();

            return codes;
        }

        public Header GetHeader(string id)
        {
            string sqlStatement = "SELECT * FROM feedbacksystem.header where HeaderID = @HeaderID";
            Header header = new Header();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection);
                cmd.Parameters.AddWithValue("@HeaderID", id);


                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                header.Title = reader["Name"].ToString();
                header.HeaderId = reader["HeaderID"].ToString();
                header.Desc = reader["Desc"].ToString();
                reader.Close();

            }
            catch (Exception genExp)
            {
                MessageBox.Show(genExp.Message);
            }

            return header;
        }

        public List<HeaderItem> GetHeaderItems(string headerId)
        {
            DataTable dataTable = new DataTable();
            List<HeaderItem> headerItem = new List<HeaderItem>();
            string sqlStatement =
                "SELECT Header.HeaderID,headeritem.HeaderItemID,Title,InputType FROM feedbacksystem.headeritem,feedbacksystem.headercontains," +
                "feedbacksystem.header where headeritem.HeaderItemID = headercontains.HeaderItemID and " +
                "headercontains.HeaderID = header.HeaderID and header.HeaderID = @HeaderID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection);
                cmd.Parameters.AddWithValue("@HeaderID", headerId);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                //each header item
                foreach (DataRow row in dataTable.Rows)
                {
                    List<string> list = GetHeaderList(row["HeaderItemID"].ToString());

                    if (list.Count > 1)
                    {
                        headerItem.Add(new HeaderItem(row["Title"].ToString(), row["InputType"].ToString(), list));
                    }
                    else
                    {
                        headerItem.Add(new HeaderItem(row["Title"].ToString(), row["InputType"].ToString(), list[0]));
                    }
                }
            }
            catch (Exception genExp)
            {
                MessageBox.Show(genExp.Message);
            }

            //return the HeaderItemList
            return headerItem;
        }

        public bool SaveHeader(Header header)
        {
            string headTitle = header.Title;
            string headDesc = header.Desc;
            List<HeaderItem> itemValues = header.HeaderItems;
            bool success = true;

            using (MySqlTransaction trans = _connection.BeginTransaction())
            {
                try
                {
                    string sqlStatement;
                    List<int> itemsId = new List<int>();
                    int headId;
                    string duplicateMsg = "These items are duplicated: ";
                    bool extraDuplicateItem = false;

                    MySqlDataReader reader;

                    sqlStatement =
                        "INSERT INTO header(`Name`,`Desc`) VALUES (@headTitle,@headDesc); SELECT last_insert_id() as id;";
                    using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                    {
                        cmd.Parameters.AddWithValue("@headTitle", headTitle);
                        cmd.Parameters.AddWithValue("@headDesc", headDesc);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        headId = Convert.ToInt16(reader["id"]);
                        reader.Close();
                        cmd.Parameters.Clear();
                    }

                    foreach (HeaderItem item in itemValues)
                    {
                        int currentItemId = -1;
                        var duplicateItem = false;

                        //check whether there is same header item (by name and type)
                        sqlStatement =
                            "SELECT HeaderItemID as id FROM headeritem WHERE Title = @itemTitle AND InputType = @itemInputType";
                        using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                        {
                            cmd.Parameters.AddWithValue("@itemTitle", item.Title);
                            cmd.Parameters.AddWithValue("@itemInputType", item.InputType);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                currentItemId = Convert.ToInt16(reader["id"]);
                                itemsId.Add(currentItemId);
                                duplicateItem = true;
                            }
                            reader.Close();
                            cmd.Parameters.Clear();
                        }

                        if (!duplicateItem)
                        {
                            sqlStatement =
                                "INSERT INTO headeritem(Title, InputType) VALUES (@itemTitle,@itemInputType); SELECT last_insert_id() as id;";
                            using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                            {
                                cmd.Parameters.AddWithValue("@itemTitle", item.Title);
                                cmd.Parameters.AddWithValue("@itemInputType", item.InputType);
                                reader = cmd.ExecuteReader();
                                //int id = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                                reader.Read();
                                currentItemId = Convert.ToInt16(reader["id"]);
                                itemsId.Add(currentItemId);
                                reader.Close();
                                cmd.Parameters.Clear();
                            }

                            if (item.InputType.Equals("Query"))
                            {
                                sqlStatement =
                                    "INSERT INTO headeritemlist(HeaderItemId, List) VALUES (@currentItemID,@itemQueryStat);";
                                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                                {
                                    cmd.Parameters.AddWithValue("@currentItemID", currentItemId);
                                    cmd.Parameters.AddWithValue("@itemQueryStat", item.QueryStat);
                                    reader = cmd.ExecuteReader();
                                    reader.Close();
                                    cmd.Parameters.Clear();
                                }
                            }
                            else
                            {
                                foreach (string value in item.ValueItem)
                                {
                                    sqlStatement =
                                        "INSERT INTO headeritemlist(HeaderItemId, List) VALUES (@currentItemID,@value); ";
                                    using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@currentItemID", currentItemId);
                                        cmd.Parameters.AddWithValue("@value", value);
                                        reader = cmd.ExecuteReader();
                                        reader.Close();
                                        cmd.Parameters.Clear();
                                    }
                                }
                            }
                        } //end if no duplicate 
                        else
                        {
                            if (!item.Title.Equals("Applicant:") && !item.Title.Equals("Job applied:") &&
                                !item.Title.Equals("Reviewer:") && !item.Title.Equals("Type:"))
                            {
                                duplicateMsg += "\n" + item.Title;
                                extraDuplicateItem = true;
                            }
                        }
                    } //end for each items

                    foreach (int itemids in itemsId)
                    {
                        sqlStatement = "INSERT INTO headercontains(HeaderID,HeaderItemID) VALUES (@headID,@itemID);";
                        using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                        {
                            cmd.Parameters.AddWithValue("@headID", headId);
                            cmd.Parameters.AddWithValue("@itemID", itemids);
                            reader = cmd.ExecuteReader();
                            reader.Close();
                            cmd.Parameters.Clear();
                        }
                    } //end for each header to item

                    if (extraDuplicateItem)
                    {
                        var confirmResult = MessageBox.Show(duplicateMsg +
                                                            "\nClick Yes to save another copy, No to edit",
                            "Are you sure?",
                            MessageBoxButtons.YesNo);

                        if (confirmResult != DialogResult.Yes)
                        {
                            return false;
                        }
                    }

                    trans.Commit();
                }
                catch (Exception genExp)
                {
                    trans.Rollback();
                    MessageBox.Show(genExp.Message);
                    success = false;
                }
            } //end transaction

            return success;
        }

        public Boolean VerifyPassword(string username, string password)
        {
            SHA256 sha256 = SHA256.Create();

            string sqlStatement =
                "SELECT concat(TRIM(FirstName),\".\",TRIM(LastName)) as username, reviewer.Password, Salt, ReviewerID FROM feedbacksystem.reviewer where concat(TRIM(FirstName),\".\",TRIM(LastName)) like @Username";

            using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password + reader["Salt"]);
                    byte[] hash = sha256.ComputeHash(bytes);
                    string convertedHash = Convert.ToBase64String(hash);

                    if (convertedHash.Equals(reader["Password"]))
                    {
                        Reviewer.Id = Convert.ToInt32(reader["ReviewerID"]);
                        Reviewer.Name = reader["username"].ToString().Replace(".", " ");
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                }
                else
                {
                    reader.Close();
                    return false;
                }

            }

        }

        public bool SaveSection(Section section)
        {
            int codeId = 0;
            

            using (MySqlTransaction trans = _connection.BeginTransaction())
            {
                try
                {
                    //Insert the section
                     string sqlStatement = "INSERT INTO sections(`Title`, `Desc`) VALUES (@Title,@Desc); SELECT last_insert_id() as id;";
                    MySqlDataReader reader;

                    int sectionId;
                    using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                    {
                        cmd.Parameters.AddWithValue("@Title", section.Title);
                        cmd.Parameters.AddWithValue("@Desc", section.Desc);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        sectionId = Convert.ToInt16(reader["id"]);
                        reader.Close();
                        cmd.Parameters.Clear();
                    }

                    

                    //loop codes
                    foreach (var code in section.Codes)
                    {
                        bool duplicate = false;
                        //check codes duplication
                        sqlStatement = "SELECT codes.CodesID as id FROM feedbacksystem.codes where codes.Code = @code;";
                        using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                        {
                            cmd.Parameters.AddWithValue("@code", code);
                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                codeId = Convert.ToInt16(reader["id"]);
                                duplicate = true;
                            }
                            reader.Close();
                            cmd.Parameters.Clear();
                        }

                        //create a new entry if not duplication
                        if (!duplicate)
                        {
                            sqlStatement = "INSERT INTO codes(`Code`) VALUES (@Code); SELECT last_insert_id() as id;";
                            using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                            {
                                cmd.Parameters.AddWithValue("@Code", code);
                                reader = cmd.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    codeId = Convert.ToInt16(reader["id"]);
                                }
                                reader.Close();
                                cmd.Parameters.Clear();
                            }
                        }

                        //Link section with codes
                        sqlStatement = "INSERT INTO section_code VALUES(@CodeID, @SectionID);";
                        using (MySqlCommand cmd = new MySqlCommand(sqlStatement, _connection, trans))
                        {
                            cmd.Parameters.AddWithValue("@CodeID", codeId);
                            cmd.Parameters.AddWithValue("@SectionID", sectionId);
                            reader = cmd.ExecuteReader();
                            reader.Close();
                            cmd.Parameters.Clear();
                        }

                    }//end loop codes
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                    return false;
                }
                    
            }
            return true;
        }

        public List<Applicant> GetAppByPosition(String posId)
        {
            List<Applicant> listOfApp = new List<Applicant>();

            MySqlCommand cmd =
                new MySqlCommand(
                    "SELECT applicant.ApplicantID,FirstName, LastName, Email, positionapplied.File FROM feedbacksystem.applicant, feedbacksystem.positionapplied,feedbacksystem.positions " +
                    "where applicant.ApplicantID = positionapplied.ApplicantID and positionapplied.PositionID = positions.PositionID and positions.PositionID = @PositionID",
                    _connection);

            cmd.Parameters.AddWithValue("@PositionID", posId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                byte[] pdf = (byte[])reader["File"];
                Applicant app = new Applicant(reader["ApplicantID"].ToString(), reader["FirstName"] + " " + reader["LastName"], reader["Email"] + "", pdf);
                listOfApp.Add(app);

            }
            reader.Close();
            return listOfApp;




        }
    }
}
