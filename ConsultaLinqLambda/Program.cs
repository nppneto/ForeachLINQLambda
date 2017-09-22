using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaLinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("São Bernardo");
            cidades.Add("Santos");
            cidades.Add("São Caetano");
            cidades.Add("Praia Grande");
            cidades.Add("São Vicente");

            BuscaPrimeiroComLambda(cidades, "Sã").ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }

        public static string BuscaPrimeiroComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }
            return "Não encontrado.";
        }

        public static List<string> BuscaPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscaPrimeiroComLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}
