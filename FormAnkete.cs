using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PractikaDB
{
    public partial class Form_ankete : Form
    {
        NpgsqlConnection connection;
        public Form_ankete()
        {
            InitializeComponent();
        }

        #region Methods

        #endregion Methods

        #region Checks

        private void OnlyEnglish(KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (System.Text.RegularExpressions.Regex.Match(Symbol, @"[а-яА-Я]").Success)
                e.Handled = true;

            if (Symbol == "\b" || Symbol == "\u0001")
                e.Handled = false;
        }

        private bool isEmailLegit(string email)
        {
            try
            {
                var ma = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                MessageBox.Show("Invalid email");
                return false;
            }
        }

        #endregion Checks

        #region Event
        private void Form_ankete_Load(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Practice;";
            connection = new NpgsqlConnection(connString);
            try
            {
                connection.Open();
                MessageBox.Show("БД подключена");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEmailLegit(tbxEmail.Text)) return;
        }

        private void comboBoxHairColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // предотвращает не enum ввод
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyEnglish(e);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль администратора", "Войти как администратор");

            if (pass == "admin")
            {
                var tbl = new Tables(this.Left, this.Top, this.Height, this.Width, connection);
                tbl.Show();
            }
            else MessageBox.Show("Неверный пароль!");
        }

        private void btnPsyco_Click(object sender, EventArgs e)
        {

        }

        #endregion Event


    }
}
