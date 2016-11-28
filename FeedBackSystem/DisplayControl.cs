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
    public partial class DisplayControl : System.Windows.Forms.UserControl
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

            TitleLabel.Text = "List of " + ControlType + "s: ";
            AddBtn.Text = "Add " + ControlType;
            DeleteBtn.Text = "Delete" + ControlType;
            EditBtn.Text = "Edit " + ControlType;
            UpdateBtn.Text = "Update " + ControlType;
            
            setDgv();
        }

        private void setDgv()
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
                            "group_concat(headeritem.Title order by headeritem.HeaderItemID ASC SEPARATOR ' | ') as Items " +
                            "FROM header, headeritem, headercontains " +
                            "WHERE header.Archived = 0 and header.HeaderID = headercontains.HeaderID AND " +
                            "headeritem.HeaderItemID = headercontains.HeaderItemID " +
                            "GROUP BY header.HeaderID " +
                            "ORDER BY header.HeaderID");
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

            for (int a = 0; a < Dgv.ColumnCount - 2; a++)
            {
                Dgv.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            Dgv.Columns[Dgv.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (ControlType)
            {
                case "Header":
                    using (HeaderItemDisplay creator = new HeaderItemDisplay())
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
                case "Section":
                    using (SectionCreator creator = new SectionCreator())
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
                case "Template":
                    using (TemplateCreator creator = new TemplateCreator())
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.SelectedRows.Count > 1)
            {
                DeleteBtn.Text = "Delete " + ControlType + "s";
                EditBtn.Enabled = false;
                RowTitleText.Clear();
                RowDescText.Clear();
            }
            else
            {
                DeleteBtn.Text = "Delete " + ControlType;
                EditBtn.Enabled = true;
                RowTitleText.Text = Dgv.SelectedRows[0].Cells[1].Value.ToString();
                RowDescText.Text = Dgv.SelectedRows[0].Cells[2].Value.ToString();
            }
            UpdateBtn.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();

            MySql sql = new MySql();
            sql.OpenConnection();

            if (Dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv.SelectedRows)
                {
                    ids.Add(row.Cells[0].Value.ToString());
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete the "+ControlType.ToLower()+"s with following ids:\n" +
                                    string.Join(", ", ids), "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes) return;

                switch (ControlType)
                {
                    case "Header":
                        foreach (string id in ids)
                        {
                            sql.ArchiveHeader(id);
                        }
                        break;
                    case "Section":
                        foreach (string id in ids)
                        {
                            sql.ArchiveSection(id);
                        }
                        break;
                    case "Template":
                        foreach (string id in ids)
                        {
                            sql.ArchiveTemplate(id);
                        }
                        break;
                }

                MessageBox.Show("Successfully Deleted");

                setDgv();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string id = Dgv.SelectedRows[0].Cells[0].Value.ToString();
            switch (ControlType)
            {
                case "Header":
                    using (HeaderItemDisplay creator = new HeaderItemDisplay(id))
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
                case "Section":
                    using (SectionCreator creator = new SectionCreator(id))
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
                case "Template":
                    using (TemplateCreator creator = new TemplateCreator())
                    {
                        creator.ShowDialog();
                        if (creator.DialogResult == DialogResult.OK)
                        {
                            setDgv();
                        }
                    }
                    break;
            }
        }

        private void RowTitleText_TextChanged(object sender, EventArgs e)
        {
            if (RowTitleText.ContainsFocus)
            {
                UpdateBtn.Visible = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = Dgv.SelectedRows[0].Cells[0].Value.ToString();

            if (!String.IsNullOrEmpty(RowTitleText.Text))
            {
                MySql sql = new MySql();
                sql.OpenConnection();

                if (sql.EditComponent(ControlType, id, RowTitleText.Text, RowDescText.Text))
                {
                    MessageBox.Show("Successfully Updated!\n For advanced updates please click the Edit " + ControlType + " button. ");
                }
                else
                {
                    MessageBox.Show("No updates detected!\n For advanced updates please click the Edit " + ControlType + " button. ");
                }

                sql.CloseConnection();
            }
            else
            {
                MessageBox.Show(ControlType + " Title must not be empty!", "Missing attributes");
                return;
            }
            
            setDgv();
            RowTitleText.Clear();
            RowDescText.Clear();
            UpdateBtn.Visible = false;
        }

        private void RowDescText_TextChanged(object sender, EventArgs e)
        {
            if (RowDescText.ContainsFocus)
            {
                UpdateBtn.Visible = true;
            }
        }
    }
}
