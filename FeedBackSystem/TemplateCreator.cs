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

        public TemplateCreator()
        {
            InitializeComponent();
           // ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            SectionPanel.Controls.Clear();
            SectionPanel.Controls.Add(SectionTable);
            SectionTable.Controls.Clear();

            RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

            SectionTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            //HeaderControls.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            SectionTable.RowStyles.Add(style);


            using (SelectControl form = new SelectControl("Section"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {

                    List<Section> section = new List<Section>();

                    MySql sql = new MySql();
                    sql.OpenConnection();

                    form._ids.Reverse();

                    foreach (string id  in form._ids)
                    {
                        section.Add(sql.GetSection(id));
                    }

                    sql.CloseConnection();

                    foreach (Section s in section)
                    {
                        SectionTable.Controls.Add(new CheckBox { Anchor = AnchorStyles.Left, Name = "checker" + s.SectionId, AutoSize = true }, 0, _row);

                        SectionTable.Controls.Add(
                            new Label
                            {
                                Text = s.Title,
                                Anchor = AnchorStyles.Left,
                                TextAlign = ContentAlignment.MiddleLeft
                            }, 1, _row);

                        ComboBox codes = new ComboBox
                        {
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            Anchor = AnchorStyles.Right,
                            Name = "codes" + s.SectionId
                        };

                        foreach (string code in s.Codes)
                        {
                            codes.Items.Add(code);
                        }

                        SectionTable.Controls.Add(codes, 2, _row);

                        RichTextBox comment = new RichTextBox
                        {
                            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                            Name = "comment" + s.SectionId
                        };

                        SectionTable.Controls.Add(comment, 1, _row + 1);
                        SectionTable.SetColumnSpan(comment,2);

                        _row++;
                        _row++;
                    }

                    //ChangeSectionBtn.Text = "Change Section";
                    ChangeSectionBtn.Visible = true;

                    _currentTemplate.Sections.Clear();
                    _currentTemplate.Sections.AddRange(section);

                }
            }

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

                    ChangeHeader.Visible = true;
                    HorizontalLine.Visible = true;
                    TextLabel.Visible = true;

                    _currentTemplate.Header = selectedHeader;
                }
            }
        }

        private void SaveTemplateBtn_Click(object sender, EventArgs e)
        {
            MySql sql = new MySql();

            if (TitleText.Text.Length <= 0)
            {
                MessageBox.Show("Please insert the title","Missing Field");
                return;
            }

            //if (DescText.Text.Length <= 0)
            //{
            //    MessageBox.Show("Please insert the description","Missing Field");
            //    return;
            //}

            sql.OpenConnection();

            if (sql.SaveTemplate(_currentTemplate.Header, _currentTemplate.Sections, TitleText.Text, DescText.Text))
            {
                MessageBox.Show("Template successfully saved");
                
                this.DialogResult = DialogResult.OK;
                Close();
            }
            sql.CloseConnection();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
