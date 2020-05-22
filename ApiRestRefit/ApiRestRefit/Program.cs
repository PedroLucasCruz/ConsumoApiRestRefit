using Refit;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiRestRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cep = RestService.For<ICepService>("https://viacep.com.br/");
                Console.WriteLine("informe seu cep");

                String cepinformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando dados de cep");

                //Chamada do refit
                var retorno = await cep.GetAnddressAsync(cepinformado);
             
               //Console.WriteLine($"\nLogradouro:{retorno.logradouro},\nBairro:{retorno.bairro},\nCidade:{retorno.localidade}");
                
                Console.WriteLine(retorno.logradouro.ToString());
                Console.WriteLine(retorno.bairro.ToString());
                Console.WriteLine(retorno.localidade.ToString());

                Console.WriteLine("Consultado");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro na sessão: " + e.Message);
            }
        }
    }
}
