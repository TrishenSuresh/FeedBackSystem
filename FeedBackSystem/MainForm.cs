using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FeedBackSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            var result = new Login().ShowDialog();

            if (result == DialogResult.OK)
            {
                MainPanel.Controls.Add(new Home());

                var adobePath = Registry.GetValue(@"HKEY_CLASSES_ROOT\Software\Adobe\Acrobat\Exe", string.Empty, string.Empty);

                if (adobePath == null)
                {
                    MessageBox.Show("Please install adobe reader to fully utilize the system's functionality","Adobe Reader Not Found",MessageBoxButtons.OK);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            GenerateFeedback usercontroller = new GenerateFeedback {Dock = DockStyle.Fill};
            MainPanel.Controls.Add(usercontroller);
        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (HeaderCreator creator = new HeaderCreator())
            {
                creator.ShowDialog();
                if (creator.DialogResult == DialogResult.OK)
                {
                    MainPanel.Controls.Clear();

                    MySql sql = new MySql();
                    sql.OpenConnection();
                    DataTable headerDt = sql.GetDataSet("SELECT * FROM feedbacksystem.header");
                    headerDt.Columns["HeaderId"].ColumnName = "Header ID";
                    headerDt.Columns["Desc"].ColumnName = "Description";

                    DataGridView headerDgv = new DataGridView {Dock = DockStyle.Fill};
                    headerDgv.DataSource = headerDt;
                    headerDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    MainPanel.Controls.Add(headerDgv);

                    sql.CloseConnection();
                }
            } //end using header creator
        } //end header tool strip

        private void headerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Header") {Dock = DockStyle.Fill};
            MainPanel.Controls.Add(display);
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new SectionCreator().ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void sectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Section") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
        }
    }
}
