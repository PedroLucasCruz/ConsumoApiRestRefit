using Newtonsoft.Json;

namespace ApiRestRefit
{
    class CepResponse
    {
        //Essa propriedade para especificar o nome do parametro de armazenagem só será valida se o pacote de
        //Json.net da Newtonsoft for instalado em Tools NuGet packege Manager > manager nuget packege for solution
        //Selecione bro
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string logradouro { get; set; }

        [JsonProperty("complemento")]
        public string complemento { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("localidade")]
        public string localidade { get; set; }

        [JsonProperty("uf")]
        public string uf { get; set; }

        [JsonProperty("unidade")]
        public string unidade { get; set; }

        [JsonProperty("ibge")]
        public string ibge { get; set; }

        [JsonProperty("gia")]
        public string gia { get; set; }
    }
}
