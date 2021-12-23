using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaDB
{
    public partial class FormPsyco : Form
    {
        int left, top, height, width, _userID, score;
        bool q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16;
        bool[] answers = new bool[17];
        int currentQuestion = 1;
        string[] questions = 
        {
            "empty",
            "У вас есть склонность к самоповреждениям?",
            "Вы периодически совершаете безрассудные поступки.",
            "Вы стараетесь соблюдать законы?",
            "Время от времени вы разговариваете с каким-либо вымышленным персонажами",
            "Можешь ли вы без спроса взять чужую вещь?",
            "Часто ли у вас меняется настроение?",
            "У вас периодически возникают мысли, что за вами постоянно следят, или возникает желание следить",
            "Часто врете друзьям, родным?",
            "Если вы совершили ошибку, то всегда можете это признать и извиниться.",
            "Часто срываете свою злость на других (более слабых людях, животных, предметах)?",
            "Есть тяга к употреблению алкоголя, наркотиков?",
            "Обычно Вы одеваетесь, в соответствии с погодой и обстановкой",
            "Издевались или унижали ли вы кого-нибудь?",
            "В сложных ситуациях вы не теряете самообладание и адекватно воспринимаете возникающие проблемы",
            "Вы всегда знаете какой сегодня день (или число) и где вы находитесь?",
            "Вы не живете в мире фантазий, а реально воспринимаете окружающий мир.",
        };
        
        NpgsqlConnection _connection;

        public FormPsyco(int X, int Y, int Height, int Width, NpgsqlConnection connection, int userID)
        {
            InitializeComponent();
            left = X;
            top = Y;
            height = Height;
            width = Width;
            _connection = connection;
            _userID = userID;
        }

        private void FormPsyco_Load(object sender, EventArgs e)
        {
            this.Left = left + width / 2 - (this.Width / 2);
            this.Top = top + height / 2 - (this.Height / 2);
            lblQuestion.Text = questions[currentQuestion];
        }

        private void NextQuestion()
        {
            currentQuestion++;
            try
            {
                lblQuestion.Text = questions[currentQuestion];
            }
            catch { }
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            
            if (rdoYes.Checked)
            {
                score++;
                answers[currentQuestion] = true;
            }
            else
                answers[currentQuestion] = false;
            NextQuestion();
            if (currentQuestion == 17)
            {
                SaveData();
                return;
            }
        }

        private void SaveData()
        {
            var command = $"INSERT INTO test (Idankete, Score, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16) " +
                $"VALUES ({_userID}, {score}, {answers[1]}, {answers[2]}, {answers[3]}, {answers[4]}, {answers[5]}, {answers[6]}, {answers[7]}, {answers[8]}, {answers[9]}, {answers[10]}, {answers[11]}, {answers[12]}, {answers[13]}, {answers[14]}, {answers[15]}, {answers[16]})";
                
            try
            {
                new NpgsqlCommand(command, _connection).ExecuteNonQuery();
                MessageBox.Show("Вас можно назвать странным человеком. Многие знакомые замечают ваше необычное поведение, но это их не пугает. Наоборот, они еще больше интересуются вами. Может странности это ваша коронная фишечка, которая придает особый шарм. Ну, а в целом вы вполне адекватны!","Успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
