using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.css;
using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml.parser;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.pipeline.html;
using MySql.Data.MySqlClient;
using Image = iTextSharp.text.Image;

namespace FeedBackSystem
{
    public partial class PDF_Generation : Form
    {
        //THIS CLASS IS JUST TO VIEW THE PDF GENERATED FOR TESTING PURPOSE, WILL BE DELETED ONCE COMPLETED

        private int _counter = 0;
        private int _limit = 0;
        List<byte[]> byteses = new List<byte[]>();

        public PDF_Generation()
        {

            Directory.CreateDirectory(Path.GetTempPath() + @"FeedBackSystem\");

            InitializeComponent();
 
            var sql = new MySql();

            sql.OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT PDF FROM feedbacksystem.feedback", sql.GetConnection());

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                byteses.Add((byte[])reader["PDF"]);
            }

            _limit = byteses.Count;
            string tempPdf = TempFileHandler.MakeTempFile(byteses[_counter]);
            web.Navigate(tempPdf);
            
            sql.CloseConnection();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

            _counter++;

            if (_counter >= _limit)
                _counter = 0;

            string tempPdf = TempFileHandler.MakeTempFile(byteses[_counter]);
            web.Navigate(tempPdf);

        }

    }

    

}

