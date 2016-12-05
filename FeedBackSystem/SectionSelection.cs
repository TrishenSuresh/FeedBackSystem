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
    public partial class SectionSelection : UserControl
    {
        public List<Section> AvailableSections;
        public List<Section> SelectedSections = new List<Section>();

        public SectionSelection()
        {
            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            AvailableSections = sql.GetSectionsList();

            AvailableSectionDGV.DataSource = AvailableSections;

            for (int a = 0; a < AvailableSectionDGV.ColumnCount - 2; a++)
            {
                AvailableSectionDGV.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                SelectedSectionDGV.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }

            AvailableSectionDGV.Columns[AvailableSectionDGV.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SelectedSectionDGV.Columns[AvailableSectionDGV.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            sql.CloseConnection();
        }

        //To be used when editing template, give it the sections that is already contain in the template
        public SectionSelection(List<Section> sections)
        {
            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            AvailableSections = sql.GetSectionsList();

            AvailableSectionDGV.DataSource = AvailableSections;

            SelectedSections.AddRange(sections);

            foreach (Section s in sections)
            {
                AvailableSections.RemoveAll(x => x.SectionId.Equals(s.SectionId));
            }

            SelectedSectionDGV.DataSource = SelectedSections;

            sql.CloseConnection();
        }

        public void UpdateSelectedSections(List<Section> sections)
        {
            SelectedSections.AddRange(sections);

            foreach (Section s in sections)
            {
                AvailableSections.RemoveAll(x => x.SectionId.Equals(s.SectionId));
            }

            SelectedSectionDGV.DataSource = SelectedSections;
        }

        private void AvailableSectionDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int row = 0;
            
            foreach (Section s in AvailableSections)
            {
                string codes = "";

                codes = s.Codes.Aggregate(codes, (current, code) => current + code + " | ");

                AvailableSectionDGV.Rows[row].Cells[2].Value = codes;

                row++;
            }
        }

        private void AvailableSectionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveBtn.Enabled = false;
            AddBtn.Enabled = true;
        }

        private void SelectedSectionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveBtn.Enabled = true;
            AddBtn.Enabled = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AvailableSectionDGV.CurrentRow == null) return;

            Section selectedSection = (Section)AvailableSectionDGV.CurrentRow.DataBoundItem;

            AvailableSections.RemoveAll(x => x.SectionId.Equals(selectedSection.SectionId));

            SelectedSections.Add(selectedSection);

            RefreshGrids();
        }

        private void RefreshGrids()
        {
            AvailableSectionDGV.DataSource = null;
            SelectedSectionDGV.DataSource = null;
            
            AvailableSectionDGV.Rows.Clear();
            SelectedSectionDGV.Rows.Clear();

            AvailableSectionDGV.DataSource = AvailableSections;
            SelectedSectionDGV.DataSource = SelectedSections;
        }

        private void SelectedSectionDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int row = 0;

            foreach (Section s in SelectedSections)
            {
                string codes = "";

                codes = s.Codes.Aggregate(codes, (current, code) => current + code + " | ");

                SelectedSectionDGV.Rows[row].Cells[2].Value = codes;

                row++;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (SelectedSectionDGV.CurrentRow == null) return;

            Section selectedSection = (Section)SelectedSectionDGV.CurrentRow.DataBoundItem;

            SelectedSections.RemoveAll(x => x.SectionId.Equals(selectedSection.SectionId));

            AvailableSections.Add(selectedSection);

            RefreshGrids();
        }
    }
}
