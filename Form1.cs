using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PractikaDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Practice;";
            var connection = new NpgsqlConnection(connString);
            try
            {
                connection.Open();
                MessageBox.Show("БД подключена");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
