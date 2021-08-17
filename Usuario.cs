using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Usuario
    {
        public string Email;
        public string Senha;

        public Usuario(string email, string senha) {
            Email = email;
            Senha = Senha;
        }

        public Usuario() { }

        public Usuario(string email) {
            Email = email;
        }

        public override string ToString() {
            return Email + ", " + Senha;
        }
    }
}
