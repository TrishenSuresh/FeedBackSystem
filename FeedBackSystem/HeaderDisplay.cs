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
    public partial class HeaderDisplay : UserControl
    {
        public HeaderDisplay()
        {
            InitializeComponent();
            setHeaderDgv();
        }

        private void addHeaderBtn_Click(object sender, EventArgs e)
        {
            using (HeaderCreator creator = new HeaderCreator())
            {
                creator.ShowDialog();
                if (creator.DialogResult == DialogResult.OK)
                {
                    setHeaderDgv();
                }
            }
        }

        private void setHeaderDgv()
        {
            MySql sql = new MySql();
            sql.OpenConnection();
            DataTable headerDt = sql.GetDataSet("SELECT header.HeaderID, header.Name, header.Desc, " + 
                "group_concat(headeritem.Title order by headeritem.HeaderItemID ASC SEPARATOR ' | ') as Items " + 
                "FROM header, headeritem, headercontains " + 
                "WHERE header.HeaderID = headercontains.HeaderID AND " +
                "headeritem.HeaderItemID = headercontains.HeaderItemID " + 
                "GROUP BY header.HeaderID " +
                "ORDER BY header.HeaderID");
            headerDt.Columns["HeaderId"].ColumnName = "Header ID";
            headerDt.Columns["Desc"].ColumnName = "Description";

            headerDgv.DataSource = headerDt;
            sql.CloseConnection();
        }
    }
}
