using Refit;
using System.Threading.Tasks;

namespace ApiRestRefit
{

   interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAnddressAsync(string cep);
    }

}
