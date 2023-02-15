using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using Bussines;
using System;

namespace Desafio_07_3camadas
{
    public partial class Form1 : Form
    {
        private object txtNota;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var aluno = new BaseAluno();
            aluno.Nome = textNome.Text;
            aluno.Idade = Int32.Parse(textIdade.Text) ;
            aluno.Nota = Int32.Parse(textNota.Text);
            Aluno.Salvar(aluno);
            MessageBox.Show("Dados salvo com sucesso!");

        }
    }
}
