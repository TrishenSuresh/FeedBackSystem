using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class DisplayControl : UserControl
    {
        string ControlType;
        public DisplayControl()
        {
            InitializeComponent();
        }

        public DisplayControl(string type)
        {
            InitializeComponent();
            ControlType = type;
            switch (ControlType)
            {
                case "Header":
                    TitleLabel.Text = "List of Headers: ";
                    AddBtn.Text = "Add Header";
                    break;
                case "Section":
                    TitleLabel.Text = "List of Sections: ";
                    AddBtn.Text = "Add Section";
                    break;
                case "Template: ":
                    TitleLabel.Text = "List of Templates:";
                    AddBtn.Text = "Add Template";
                    break;
            }
            setDgv();
        }

        private void setDgv()
        {
            MySql sql = new MySql();
            sql.OpenConnection();
            DataTable Dt = new DataTable();

            switch (ControlType)
            {
                case "Header":
                    Dt = sql.GetDataSet("SELECT header.HeaderID, header.Name, header.Desc, " +
                        "group_concat(headeritem.Title order by headeritem.HeaderItemID ASC SEPARATOR ' | ') as Items " +
                        "FROM header, headeritem, headercontains " +
                        "WHERE header.HeaderID = headercontains.HeaderID AND " +
                        "headeritem.HeaderItemID = headercontains.HeaderItemID " +
                        "GROUP BY header.HeaderID " +
                        "ORDER BY header.HeaderID");
                    Dt.Columns["HeaderId"].ColumnName = "Header ID";
                    Dt.Columns["Desc"].ColumnName = "Description";
                    break;
                case "Section":
                    break;
                case "Template":
                    break;
            }
            
            Dgv.DataSource = Dt;
            sql.CloseConnection();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (ControlType)
            {
                case "Header":
                    using (HeaderCreator creator = new HeaderCreator())
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
                case "Section":
                    break;
                case "Template":
                    break;
            }
        }
    }
}
