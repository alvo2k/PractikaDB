using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace PractikaDB
{
    public partial class Form_ankete : Form
    {
        NpgsqlConnection connection;
        string photo;
        public Form_ankete()
        {
            InitializeComponent();
        }

        #region Methods
        private void SaveAnkete()
        {
            var command = $"INSERT INTO ankete " +
                $"(Name, Surname, Middlename, Bday, Phone, Email, Photo, Workplace, Position, Compensation) " +
                $"VALUES (@name, @surname, @middlename, @bday, @phone, @email, @photo, @workplace, @position, @compensation)";

            var cmd = new NpgsqlCommand(command, connection);
            cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = tbxName.Text;
            cmd.Parameters.Add("@surname", NpgsqlDbType.Varchar).Value = tbxSurname.Text;
            cmd.Parameters.Add("@middlename", NpgsqlDbType.Varchar).Value = tbxMiddleName.Text;
            cmd.Parameters.Add("@bday", NpgsqlDbType.Date).Value = dateBday.Value;
            cmd.Parameters.Add("@phone", NpgsqlDbType.Bigint).Value = Convert.ToInt64(tbxPhone.Text);
            cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = tbxEmail.Text;
            cmd.Parameters.Add("@photo", NpgsqlDbType.Varchar).Value = photo;
            cmd.Parameters.Add("@workplace", NpgsqlDbType.Varchar).Value = tbxWorkplace.Text;
            cmd.Parameters.Add("@position", NpgsqlDbType.Varchar).Value = tbxPosition.Text;
            cmd.Parameters.Add("@compensation", NpgsqlDbType.Integer).Value = Convert.ToInt32(tbxCompensation.Text);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены", "Успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void SavePhisics()
        {

        }

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

        private void OnlyInt(KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (System.Text.RegularExpressions.Regex.Match(Symbol, @"[а-яА-Я]||[a-zA-Z]").Success)
                e.Handled = true;

            if (Symbol == "\b" || Symbol == "\u0001")
                e.Handled = false;
            if (System.Text.RegularExpressions.Regex.Match(Symbol, @"[0-9]").Success)
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
            if (!isEmailLegit(tbxEmail.Text) && tbxEmail.Text != "" && tbxEmail.Text != null)
            {
                MessageBox.Show("Проверьте корестность ввода почты!", "Неверный формат email'а");
                return;
            }
            if (photo == null || photo == "")
            {
                MessageBox.Show("Добавте ссылку на фото!", "Требуется ссылка на фото");
                return;
            }

            SaveAnkete();
            SavePhisics();
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
            string userID = Microsoft.VisualBasic.Interaction.InputBox("Введить ID анкеты пользователя", "ID проходящего");
            int user;
            try
            {
                user = Convert.ToInt32(userID);
            }
            catch
            {
                return;
            }

            var form = new FormPsyco(this.Left, this.Top, this.Height, this.Width, connection, user);
            form.ShowDialog();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            var photo1 = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите URL фото", "Ссылка на фото");
            if (photo1 != "" && photo1 != null)
            {
                photo = photo1;
                imageLoaded.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxSurname.Text = "";
            tbxMiddleName.Text = "";
            tbxPhone.Text = "";
            tbxEmail.Text = "";
            tbxWorkplace.Text = "";
            tbxPosition.Text = "";
            tbxCompensation.Text = "";
            comboBoxHairColor.SelectedIndex = 0;
            tbxWeight.Text = "";
            tbxHeight.Text = "";
            checkBoxDisease.Checked = false;
        }

        private void tbxCompensation_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyInt(e);
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyInt(e);
        }


        #endregion Event

        
    }
}
