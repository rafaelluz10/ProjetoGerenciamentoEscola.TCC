using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio; 

namespace ProjetoGerenciamentoEscolar
{
    public partial class frmLogin : Form
    {
        ClasseNegocio clsuser = new ClasseNegocio();
        ClasseEntidade clsent = new ClasseEntidade();
        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        frmPrincipal f = new frmPrincipal(); 
        

        public frmLogin()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
        }
    }
}
