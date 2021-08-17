using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Usuario
    {
        public string Email;
        public string Senha;

        public override string ToString() {
            return Email + ", " + Senha;
        }
    }
}
