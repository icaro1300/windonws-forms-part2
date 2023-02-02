using JuridicoSISCSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuridicoSISCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection(@"Server=.\SENAI2022; Database=BDJURIDICO; User Id =sa; Password=senai.123;");
            var sql = "SELECT *FROM ESTADO";
            object conexao = null;
            var dados = conexao.Query<Estado>(sql)
                .ToList();

            foreach (var item in dados) ;
            }
    }
}

