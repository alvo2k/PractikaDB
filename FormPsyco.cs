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
        int left, top, height, width;                
        NpgsqlConnection _connection;

        public FormPsyco(int X, int Y, int Height, int Width, NpgsqlConnection connection)
        {
            InitializeComponent();
            left = X;
            top = Y;
            height = Height;
            width = Width;
            _connection = connection;
        }

        private void FormPsyco_Load(object sender, EventArgs e)
        {
            this.Left = left + width / 2 - (this.Width / 2);
            this.Top = top + height / 2 - (this.Height / 2);
        }


    }
}
