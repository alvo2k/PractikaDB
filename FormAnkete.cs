using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PractikaDB
{
    public partial class Form_ankete : Form
    {
        public Form_ankete()
        {
            InitializeComponent();
        }

        private void Form_ankete_Load(object sender, EventArgs e)
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

        private void comboBoxHairColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
