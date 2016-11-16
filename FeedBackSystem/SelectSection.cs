﻿using System;
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
    public partial class SelectSection : Form
    {

        
        List<Section> _sections = new List<Section>();
        public List<Section> _sectionSelected = new List<Section>();

        public SelectSection()
        {
            int row = 1;

            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            _sections = sql.GetSectionsList();

            foreach (Section section in _sections)
            {
                SectionsTable.Controls.Add(new Label {Text = section.Title, AutoSize = true, Anchor = AnchorStyles.Left | AnchorStyles.Top},0,row);
                SectionsTable.Controls.Add(new Label {Text = section.Desc, AutoSize = true, Anchor = AnchorStyles.Left | AnchorStyles.Top},1,row);
                ComboBox Codes = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top
                    
                };

                foreach (string code in section.Codes)
                {
                    Codes.Items.Add(code);
                }

                SectionsTable.Controls.Add(Codes, 2, row);
                SectionsTable.Controls.Add(new CheckBox { Appearance = Appearance.Button, AutoSize = true, Anchor = AnchorStyles.Left 
                    | AnchorStyles.Right | AnchorStyles.Top, Text = "Select", TextAlign = ContentAlignment.MiddleCenter, Name = section.SectionId},3,row);
                

                row++;
            }

            sql.CloseConnection();


        }

        private void AddSection_Click(object sender, EventArgs e)
        {
            List<string> sectionSelected = new List<string>();
            
            _sectionSelected.Clear();

            foreach (Section s in _sections)
            {
                CheckBox check = (CheckBox) SectionsTable.Controls.Find(s.SectionId, true)[0];
                if (check.Checked)
                {
                    sectionSelected.Add(check.Name);
                }
            }

            foreach (string s in sectionSelected)
            {
                _sectionSelected.Add(_sections.Find(x => x.SectionId == s));
            }


            DialogResult = DialogResult.OK;
            
        }
    }
}
