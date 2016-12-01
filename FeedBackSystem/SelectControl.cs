using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SelectControl : Form
    {

        public string ControlType;
        public List<string> _ids = new List<string>();

        public SelectControl(string type)
        {
            InitializeComponent();
            ControlType = type;
            
            TitleLabel.Text = "List of " + ControlType + "s: ";
            SelectBtn.Text = "Select " + ControlType;
            this.Text = "Select " + ControlType;

            switch (ControlType)
            {
                case "Header":
                case "Template":
                    Dgv.MultiSelect = false;
                    break;
                case "Section":
                    Dgv.MultiSelect = true;
                    break;
            }

            SetDgv();
        }

        private void SetDgv()
        {
            MySql sql = new MySql();
            sql.OpenConnection();
            DataTable Dt = new DataTable();
            try
            {
                switch (ControlType)
                {
                    case "Header":
                        Dt = sql.GetDataSet("SELECT header.HeaderID, header.Name, header.Desc, " +
                                           "group_concat(headeritem.Title order by headercontains.PositionIndex ASC SEPARATOR \' | \') as Items " +
                                           "FROM header, headeritem, headercontains " +
                                           "WHERE header.Archived = 0 and header.HeaderID = headercontains.HeaderID AND headeritem.HeaderItemID = headercontains.HeaderItemID " +
                                           "GROUP BY header.HeaderID ORDER BY header.HeaderID");
                        Dt.Columns["HeaderId"].ColumnName = "Header ID";
                        Dt.Columns["Desc"].ColumnName = "Description";
                        break;
                    case "Section":
                        Dt = sql.GetDataSet("SELECT sections.SectionID, sections.Title, sections.Desc, " +
                            "group_concat(codes.Code order by codes.CodesID ASC SEPARATOR ' | ') as Codes " +
                            "FROM sections, section_code, codes " +
                            "WHERE sections.Archived = 0 and sections.SectionID = section_code.SectionID AND " +
                            "section_code.CodesID = codes.CodesID " +
                            "group by sections.SectionID " +
                            "order by sections.SectionID");
                        Dt.Columns["SectionID"].ColumnName = "Section ID";
                        Dt.Columns["Desc"].ColumnName = "Description";
                        break;
                    case "Template":
                        Dt = sql.GetDataSet("SELECT template.TemplateID AS 'Template ID', template.TemplateTitle AS 'Template Title', " +
                            "template.TemplateDesc AS 'Template Description', header.Name as 'Header Name', " +
                            "GROUP_CONCAT(sections.Title order by sections.SectionID SEPARATOR ' | ') as Sections , " +
                            "CONCAT(reviewer.FirstName,' ', reviewer.LastName) AS 'Author Name' " +
                            "FROM template, template_section, reviewer, header, sections " +
                            "WHERE template.Archived = 0 and template.TemplateID = template_section.TemplateID " +
                            "AND template_section.SectionID = sections.SectionID " +
                            "AND template.HeaderID = header.HeaderID " +
                            "AND template.TemplateAuthor = reviewer.ReviewerID " +
                            "GROUP BY template.TemplateID " +
                            "ORDER BY template.TemplateID; ");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Dgv.DataSource = Dt;
            sql.CloseConnection();

            for (int a = 0; a < Dgv.ColumnCount-2; a++)
            {
                Dgv.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            Dgv.Columns[Dgv.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (Dgv.SelectedRows.Count > 0)
            {

                _ids.Clear();

                foreach (DataGridViewRow row in Dgv.SelectedRows)
                {
                    _ids.Add(row.Cells[0].Value.ToString());
                }

                this.DialogResult = DialogResult.OK;
                
            }

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.SelectedRows.Count > 1)
            {
                SelectBtn.Text = "Select " + ControlType + "s";
            }
            else
            {
                SelectBtn.Text = "Select " + ControlType;
            }
        }
    }


}
