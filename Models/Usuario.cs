using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Usuario
    {
        private string _email { get; set; }
        private string _senha { get; set; }

        public Usuario(string email, string senha)
        {
            _email = email;
            _senha = senha;
        }

        public Usuario() { }

        public Usuario(string email)
        {
            _email = email;
        }

        public override string ToString()
        {
            return _email + ", " + _senha;
        }
    }
}
