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
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Cefet_JR_Consultoria
{
    /// <summary>
    /// Interaction logic for JanelaCriarUsuario.xaml
    /// </summary>
    public partial class JanelaCriarUsuario : Window
    {
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
            this.criarUsuario();
        }

        private void criarUsuario()
        {
            Usuario usuario = new Usuario();

        }
    }
}
