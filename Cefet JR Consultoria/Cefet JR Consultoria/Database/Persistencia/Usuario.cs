using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cefet_JR_Consultoria.Database.Contexto;

namespace Cefet_JR_Consultoria.Database.Persistencia
{
    class Usuario
    {
        private Banco banco = new Banco();
        private Conceitual.Usuario usuario = new Conceitual.Usuario();

        public bool criar(string nome, string email, string senha)
        {
            try
            {
                this.montar(nome, email, senha);
                this.banco.usuarios.Add(this.usuario);
                this.banco.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void montar(string nome, string email, string senha)
        {
            this.usuario.nome = nome;
            this.usuario.email = email;
            this.usuario.senha = senha;
        }
    }
}
