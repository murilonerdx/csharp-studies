using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repositories
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        //Listar os veículos
        IList<Usuario> Listar();
    }
}
