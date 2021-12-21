using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PractikaDB
{
    public partial class Tables : Form
    {
        int left, top, height, width;
        NpgsqlConnection _connection;
        string activeTabel;

        public Tables(int X, int Y, int Height, int Width, NpgsqlConnection connection)
        {
            InitializeComponent();
            left = X;
            top = Y;
            height = Height;
            width = Width;
            _connection = connection;
        }

        #region Tables
        private void Tables_Load(object sender, EventArgs e)
        {
            this.Left = left + width / 2 - (this.Width / 2);
            this.Top = top + height / 2 - (this.Height / 2);

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
        }
                
        private void LoadData(string tabel)
        {
            activeTabel = tabel;
            var source = new DataTable();
            string command = $"SELECT * FROM {tabel}";
            new NpgsqlDataAdapter(command, _connection).Fill(source);

            dataGridView1.DataSource = source;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnAnkete_Click(object sender, EventArgs e)
        {
            LoadData("ankete");
        }
                
        private void btnPhisical_Click(object sender, EventArgs e)
        {
            LoadData("phisical");
        }

        private void btnPsyco_Click(object sender, EventArgs e)
        {
            LoadData("test");
        }

        private void btnCouple_Click(object sender, EventArgs e)
        {
            LoadData("couple");
        }

        #endregion Tables
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
