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
        private int _row = 0;
        Template _currentTemplate = new Template();
        private bool isUpdate = false;

        public TemplateCreator()
        {
            InitializeComponent();
           // ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
        }

        public TemplateCreator(string id)
        {
            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            _currentTemplate = sql.GetTemplate(id);
            _currentTemplate.Id = id;

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

        //private void AddSectionBtn_Click(object sender, EventArgs e)
        //{
        //    SectionPanel.Controls.Clear();
        //    SectionPanel.Controls.Add(SectionTable);
        //    SectionTable.Controls.Clear();

        //    RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

        //    SectionTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
        //    //HeaderControls.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

        //    SectionTable.RowStyles.Add(style);


        //    using (SelectControl form = new SelectControl("Section"))
        //    {
        //        var result = form.ShowDialog();

        //        if (result == DialogResult.OK)
        //        {

        //            List<Section> section = new List<Section>();

        //            MySql sql = new MySql();
        //            sql.OpenConnection();

        //            form._ids.Reverse();

        //            foreach (string id  in form._ids)
        //            {
        //                section.Add(sql.GetSection(id));
        //            }

        //            sql.CloseConnection();

        //            foreach (Section s in section)
        //            {
        //                SectionTable.Controls.Add(new CheckBox { Anchor = AnchorStyles.Left, Name = "checker" + s.SectionId, AutoSize = true }, 0, _row);

        //                SectionTable.Controls.Add(
        //                    new Label
        //                    {
        //                        Text = s.Title,
        //                        Anchor = AnchorStyles.Left,
        //                        TextAlign = ContentAlignment.MiddleLeft
        //                    }, 1, _row);

        //                ComboBox codes = new ComboBox
        //                {
        //                    DropDownStyle = ComboBoxStyle.DropDownList,
        //                    Anchor = AnchorStyles.Right,
        //                    Name = "codes" + s.SectionId
        //                };

        //                foreach (string code in s.Codes)
        //                {
        //                    codes.Items.Add(code);
        //                }

        //                SectionTable.Controls.Add(codes, 2, _row);

        //                RichTextBox comment = new RichTextBox
        //                {
        //                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
        //                    Name = "comment" + s.SectionId
        //                };

        //                SectionTable.Controls.Add(comment, 1, _row + 1);
        //                SectionTable.SetColumnSpan(comment,2);

        //                _row++;
        //                _row++;
        //            }

        //            //ChangeSectionBtn.Text = "Change Section";
        //            ChangeSectionBtn.Enabled = true;

        //            _currentTemplate.Sections.Clear();
        //            _currentTemplate.Sections.AddRange(section);

        //        }
        //    }

        //}

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

            _currentTemplate.Sections = Sections.SelectedSections;

            if (_currentTemplate.Sections.Count <= 0)
            {
                MessageBox.Show("Please choose the sections to be included in the template.","Missing Sections");
                return;
            }

            //if (DescText.Text.Length <= 0)
            //{
            //    MessageBox.Show("Please insert the description","Missing Field");
            //    return;
            //}

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
