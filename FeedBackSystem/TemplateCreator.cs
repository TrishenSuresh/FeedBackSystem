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
    public partial class TemplateCreator : Form
    {
        Template _currentTemplate = new Template();
        private bool isUpdate = false;

        //default constructor
        public TemplateCreator()
        {
            InitializeComponent();
        }

        //constructor used to initialise the template with the passed in id
        public TemplateCreator(string id)
        {
            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            _currentTemplate = sql.GetTemplate(id);

            TitleText.Text = _currentTemplate.Title;
            DescText.Text = _currentTemplate.Desc;

            //place in the header
            HeaderPlacement place = new HeaderPlacement();
            HeaderPanel.Controls.Clear();
            foreach (HeaderItem item in _currentTemplate.Header.HeaderItems)
            {
                place.AddItem(item);
            }

            HeaderPanel.Controls.Add(place);

            ChangeHeader.Enabled = true;
            HorizontalLine.Visible = true;
            TextLabel.Visible = true;
            
            Sections.UpdateSelectedSections(_currentTemplate.Sections);
                
            sql.CloseConnection();

            SaveTemplate.Text = "Update Template";
            isUpdate = true;
        }
        
        private void AddHeaderBtn_Click(object sender, EventArgs e)
        {
            using (SelectControl form = new SelectControl("Header"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MySql sql = new MySql();
                    sql.OpenConnection();
                    Header selectedHeader = sql.GetHeader(form._ids[0]);

                    selectedHeader.HeaderItems.Clear();
                    foreach (HeaderItem i in sql.GetHeaderItems(selectedHeader.HeaderId))
                    {
                        selectedHeader.addHeaderItem(i);
                    }

                    sql.CloseConnection();

                    HeaderPlacement place = new HeaderPlacement();

                    HeaderPanel.Controls.Clear();

                    foreach (HeaderItem item in selectedHeader.HeaderItems)
                    {
                        place.AddItem(item);
                    }

                    HeaderPanel.Controls.Add(place);

                    ChangeHeader.Enabled = true;
                    HorizontalLine.Visible = true;
                    TextLabel.Visible = true;

                    _currentTemplate.Header = selectedHeader;
                }
            }
        }

        private void SaveTemplateBtn_Click(object sender, EventArgs e)
        {
            if (TitleText.Text.Length <= 0)
            {
                MessageBox.Show("Please insert the title","Missing Field");
                return;
            }

            if(object.ReferenceEquals(_currentTemplate.Header, null))
            {
                MessageBox.Show("Please choose the header to be included in the template.", "Missing Header");
                return;
            }

            _currentTemplate.Sections = Sections.SelectedSections;

            if (_currentTemplate.Sections.Count <= 0)
            {
                MessageBox.Show("Please choose the sections to be included in the template.","Missing Sections");
                return;
            }
            //end of field checkers
            
            MySql sql = new MySql();
            sql.OpenConnection();

            try
            {
                if (!isUpdate)
                {
                    if (sql.SaveTemplate(_currentTemplate.Header, _currentTemplate.Sections, TitleText.Text, DescText.Text))
                    {
                        MessageBox.Show("Template successfully saved!");
                    }
                } else
                {
                    if(sql.UpdateTemplate(_currentTemplate.Header, _currentTemplate.Sections, TitleText.Text, DescText.Text, _currentTemplate.Id))
                    {
                        MessageBox.Show("Template successfully updated!");
                    }
                }


                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Ops! Error occured!");
            }
            finally
            {
                sql.CloseConnection();
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
