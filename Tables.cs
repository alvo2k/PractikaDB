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
using NpgsqlTypes;

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

        #region TablesLoad
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

        #endregion TablesLoad
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (_connection.State != ConnectionState.Open) _connection.Open();

                switch (activeTabel)
                {
                    case "ankete":
                    {
                            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                            {
                                var row = dataGridView1.SelectedRows[i].Cells;
                                var command = 
                                    $"INSERT INTO ankete (name, surname, middlename, bday, phone, email, photo, workplace, position, compensation, isincouple, idphisical, idtest) " +
                                    $"VALUES (@name, @surname, @middlename, @bday, @phone, @email, @photo, @workplace, @position, @compensation, @isincouple, @idphisical, @idtest)";

                                var cmd = new NpgsqlCommand(command, _connection);
                                cmd.Parameters.Add("@name", NpgsqlDbType.Varchar).Value = row["name"].Value;
                                cmd.Parameters.Add("@surname", NpgsqlDbType.Varchar).Value = row["surname"].Value;
                                cmd.Parameters.Add("@middlename", NpgsqlDbType.Varchar).Value = row["middlename"].Value;
                                cmd.Parameters.Add("@bday", NpgsqlDbType.Date).Value = row["bday"].Value;
                                cmd.Parameters.Add("@phone", NpgsqlDbType.Bigint).Value = row["phone"].Value;
                                cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = row["email"].Value;
                                cmd.Parameters.Add("@photo", NpgsqlDbType.Varchar).Value = row["photo"].Value;
                                cmd.Parameters.Add("@workplace", NpgsqlDbType.Varchar).Value = row["workplace"].Value;
                                cmd.Parameters.Add("@position", NpgsqlDbType.Varchar).Value = row["position"].Value;
                                cmd.Parameters.Add("@compensation", NpgsqlDbType.Integer).Value = row["compensation"].Value;
                                cmd.Parameters.Add("@isincouple", NpgsqlDbType.Boolean).Value = row["isincouple"].Value;
                                cmd.Parameters.Add("@idphisical", NpgsqlDbType.Integer).Value = row["idphisical"].Value;
                                cmd.Parameters.Add("@idtest", NpgsqlDbType.Integer).Value = row["idtest"].Value;
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    return;
                                }                                
                            }

                            MessageBox.Show("Строкы успешно добавлены!", "Успешно");
                            LoadData(activeTabel);

                            return;
                    }
                    case "phisical":
                    {
                            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                            {
                                var row = dataGridView1.SelectedRows[i].Cells;
                                var command =
                                    $"INSERT INTO phisical (Idankete, Haircolor, Weight, Height, IMT, Disease) " +
                                    $"VALUES (@Idankete, @Haircolor, @Weight, @Height, @IMT, @Disease)";

                                var cmd = new NpgsqlCommand(command, _connection);
                                cmd.Parameters.Add("@Idankete", NpgsqlDbType.Integer).Value = row["Idankete"].Value;
                                cmd.Parameters.Add("@Haircolor", NpgsqlDbType.Unknown).Value = row["Haircolor"].Value;
                                cmd.Parameters.Add("@Weight", NpgsqlDbType.Integer).Value = row["Weight"].Value;
                                cmd.Parameters.Add("@Height", NpgsqlDbType.Integer).Value = row["Height"].Value;
                                cmd.Parameters.Add("@IMT", NpgsqlDbType.Numeric).Value = Convert.ToInt32(row["Weight"].Value) / (Convert.ToInt32(row["Height"].Value) * Convert.ToInt32(row["Height"].Value));
                                cmd.Parameters.Add("@Disease", NpgsqlDbType.Boolean).Value = row["Disease"].Value;

                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    return;
                                }
                            }

                            MessageBox.Show("Строкы успешно добавлены!", "Успешно");
                            LoadData(activeTabel);

                            return;
                        }
                    case "test":
                        {
                            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                            {
                                var row = dataGridView1.SelectedRows[i].Cells;
                                var command =
                                    $"INSERT INTO test (Idankete, Score, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16) " +
                                    $"VALUES (@Idankete, @Score, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16)";

                                var cmd = new NpgsqlCommand(command, _connection);
                                cmd.Parameters.Add("@Idankete", NpgsqlDbType.Integer).Value = row["Idankete"].Value;
                                cmd.Parameters.Add("@Score", NpgsqlDbType.Integer).Value = row["Score"].Value;
                                cmd.Parameters.Add("@q1", NpgsqlDbType.Boolean).Value = row["q1"].Value;
                                cmd.Parameters.Add("@q2", NpgsqlDbType.Boolean).Value = row["q2"].Value;
                                cmd.Parameters.Add("@q3", NpgsqlDbType.Boolean).Value = row["q3"].Value;
                                cmd.Parameters.Add("@q4", NpgsqlDbType.Boolean).Value = row["q4"].Value;
                                cmd.Parameters.Add("@q5", NpgsqlDbType.Boolean).Value = row["q5"].Value;
                                cmd.Parameters.Add("@q6", NpgsqlDbType.Boolean).Value = row["q6"].Value;
                                cmd.Parameters.Add("@q7", NpgsqlDbType.Boolean).Value = row["q7"].Value;
                                cmd.Parameters.Add("@q8", NpgsqlDbType.Boolean).Value = row["q8"].Value;
                                cmd.Parameters.Add("@q9", NpgsqlDbType.Boolean).Value = row["q9"].Value;
                                cmd.Parameters.Add("@q10", NpgsqlDbType.Boolean).Value = row["q10"].Value;
                                cmd.Parameters.Add("@q11", NpgsqlDbType.Boolean).Value = row["q11"].Value;
                                cmd.Parameters.Add("@q12", NpgsqlDbType.Boolean).Value = row["q12"].Value;
                                cmd.Parameters.Add("@q13", NpgsqlDbType.Boolean).Value = row["q13"].Value;
                                cmd.Parameters.Add("@q14", NpgsqlDbType.Boolean).Value = row["q14"].Value;
                                cmd.Parameters.Add("@q15", NpgsqlDbType.Boolean).Value = row["q15"].Value;
                                cmd.Parameters.Add("@q16", NpgsqlDbType.Boolean).Value = row["q16"].Value;

                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    return;
                                }
                            }

                            MessageBox.Show("Строкы успешно добавлены!", "Успешно");
                            LoadData(activeTabel);

                            return;
                        }
                    case "couple":
                        {
                            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                            {
                                var row = dataGridView1.SelectedRows[i].Cells;
                                var command =
                                    $"INSERT INTO couple (idhusband, idwife, wedding) " +
                                    $"VALUES (@idhusband, @idwife, @wedding)";

                                var cmd = new NpgsqlCommand(command, _connection);
                                cmd.Parameters.Add("@idhusband", NpgsqlDbType.Integer).Value = row["idhusband"].Value;
                                cmd.Parameters.Add("@idwife", NpgsqlDbType.Integer).Value = row["idwife"].Value;
                                cmd.Parameters.Add("@wedding", NpgsqlDbType.Date).Value = row["wedding"].Value;

                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    return;
                                }
                            }

                            MessageBox.Show("Строкы успешно добавлены!", "Успешно");
                            LoadData(activeTabel);

                            return;
                        }
                    default: return;
                }
            }
            else
            {
                MessageBox.Show("Выберите строки для добавления!", "Строки не выбраны");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (_connection.State != ConnectionState.Open) _connection.Open();

                string id;
                switch (activeTabel)
                {
                    case "ankete":
                        {
                            id = "Idankete";
                            break;
                        }
                    case "phisical":
                        {
                            id = "Idphisical";
                            break;
                        }
                    case "test":
                        {
                            id = "Idtest";
                            break;
                        }
                    case "couple":
                        {
                            id = "Idcouple";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Ошибка в активной таблице!");
                            id = "";
                            return;
                        }
                }

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    var command = $"DELETE FROM {activeTabel} WHERE {id} = {dataGridView1.SelectedRows[i].Cells[id].Value}";
                    var cmd = new NpgsqlCommand(command, _connection);
                    try
                    { 
                        cmd.ExecuteNonQuery();
                    }                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }

                MessageBox.Show("Строки успешно удалены!", "Успешно");
                LoadData(activeTabel);
                return;
            }

            else
            {
                MessageBox.Show("Выберите строки для удаления!", "Строки не выбраны");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (_connection.State != ConnectionState.Open) _connection.Open();

                string id = "";
                switch (activeTabel)
                {
                    case "ankete":
                        {
                            id = "Idankete";
                            break;
                        }
                    case "phisical":
                        {
                            id = "Idphisical";
                            break;
                        }
                    case "test":
                        {
                            id = "Idtest";
                            break;
                        }
                    case "couple":
                        {
                            id = "Idcouple";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Ошибка в активной таблице!");
                            return;
                        }
                }

                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                {
                    var cell = dataGridView1.SelectedCells[i];
                    var column = cell.OwningColumn.HeaderText;
                    var command = $"UPDATE {activeTabel} SET {column} = @a WHERE {id} = '{cell.OwningRow.Cells[id].Value}'";
                    var cmd = new NpgsqlCommand(command, _connection);

                    switch (column)
                    {
                        case "name":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "surname":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "middlename":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "email":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "photo":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "workplace":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "position":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Varchar).Value = cell.Value;
                                break;
                            }
                        case "bday":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Date).Value = cell.Value;
                                break;
                            }
                        case "phone":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Bigint).Value = cell.Value;
                                break;
                            }
                        case "compensation":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "idankete":
                            {
                                if (activeTabel == "ankete") return;
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "haircolor":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "weight":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "imt":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Numeric).Value = cell.Value;
                                break;
                            }
                        case "height":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "score":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "idhusband":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "idwife":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "wedding":
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Date).Value = cell.Value;
                                break;
                            }
                        case "idphisical":
                            {
                                if (activeTabel == "phisical") return;
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        case "idtest":
                            {
                                if (activeTabel == "test") return;
                                cmd.Parameters.Add("@a", NpgsqlDbType.Integer).Value = cell.Value;
                                break;
                            }
                        default:
                            {
                                cmd.Parameters.Add("@a", NpgsqlDbType.Boolean).Value = cell.Value;
                                break;
                            }
                    }

                    try
                    {
                        if (cmd.ExecuteNonQuery() != -1)
                            MessageBox.Show("Ячейка успешно обновлена!", "Успешно");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }                
                LoadData(activeTabel);
            }
            else
            {
                MessageBox.Show("Выберите ячейки для обновления!", "Ячейки не выбраны");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string command = Microsoft.VisualBasic.Interaction.InputBox("Введите SQL - запрос", "Запрос для поиска");
            if (command == "" || command == null) return;
            try
            {
                dataGridView1.DataSource = new NpgsqlDataAdapter(command, _connection).Fill(new DataTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
