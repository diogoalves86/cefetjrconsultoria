using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Cefet_JR_Consultoria.Database.Persistencia;

namespace Cefet_JR_Consultoria
{
    /// <summary>
    /// Interaction logic for JanelaCriarUsuario.xaml
    /// </summary>
    public partial class JanelaCriarUsuario : Window
    {
        private Usuario usuario = new Usuario();

        public JanelaCriarUsuario()
        {
            InitializeComponent();
        }

        private void btnLimparFormulario_Click(object sender, RoutedEventArgs e)
        {
            this.limparFormulario();
        }

        private void limparFormulario()
        {
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void btnCriarUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.criarUsuario(txtNome.Text, txtEmail.Text, txtSenha.Text);
        }

        private void criarUsuario(string nome, string email, string senha)
        {
            if (this.usuario.criar(nome, email, senha))
                MessageBox.Show("Usuario cadastrado com sucesso!");
            else
                MessageBox.Show("Erro ao cadastrar usuário. Tente novamente mais tarde.");

        }
    }
}
