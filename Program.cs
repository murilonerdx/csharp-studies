using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 214748368L;
            char genero = 'F';
            double n5 = 4.5;
            float n6 = 4.5f;
            string nome = "Maria Green";
            object obj1 = "Murilo Pereira";
            object obj2 = 4.5f;
            string nome2 = "Murilo Pereira da Silva";
            double saldo = 10.36724;

            // Exemplo 
            // int _5minutos; int salario; int salarioDoFuncionario;
            // Converções
            //Camel Case: lastname (parametros de metodos, variaveis dentro de metodos)
            //PascalCase: LastName (namespaces, classe, properties e metodos)
            //Pad~rao_lasName (atributos internos da classe)
           


            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(nome2);

            //F2 vai delimitar a quantidade de caracters depois da virgula eu quero imprimir
            Console.WriteLine(saldo.ToString("F2"));

            //Definir formatação do numero
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));


            //Imprimir em um console
            int idade = 20;
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");





        }
    }
}
