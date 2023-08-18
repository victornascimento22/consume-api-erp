using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication6.DTO.Produtos
{
    public class ConsultaProdutos
    {
        public class Message
        {
            [JsonProperty("valid")]
            public string Valid { get; set; }
        }

        public class ConsultaProdutoDTO
        {
            [JsonProperty("prdCod")]
            public long? PrdCod { get; set; }

            [JsonProperty("prdDesNome")]
            public string? PrdDesNome { get; set; }

            [JsonProperty("tecEspCod")]
            public string? TecEspCod { get; set; }

            [JsonProperty("tecEspCodSeq")]
            public string? TecEspCodSeq { get; set; }

            [JsonProperty("prdEspCodExterno")]
            public string? PrdEspCodExterno { get; set; }

            [JsonProperty("prdVldTipo")]
            public string? PrdVldTipo { get; set; }

            [JsonProperty("prdVldLi")]
            public string? PrdVldLi { get; set; }

            [JsonProperty("nomeMedSug")]
            public string? NomeMedSug { get; set; }

            [JsonProperty("nomeMedProv")]
            public string? NomeMedProv { get; set; }

            [JsonProperty("pctIi")]
            public double? PctIi { get; set; }

            [JsonProperty("pctIpi")]
            public double? PctIpi { get; set; }

            [JsonProperty("pctPis")]
            public double? PctPis { get; set; }

            [JsonProperty("pctCofins")]
            public double? PctCofins { get; set; }

            [JsonProperty("prdVldSituacao")]
            public string? PrdVldSituacao { get; set; }

            [JsonProperty("dpeNomPessoaFab")]
            public string? DpeNomPessoaFab { get; set; }

            [JsonProperty("dpeNomPessoaExp")]
            public string? DpeNomPessoaExp { get; set; }

            [JsonProperty("prdLngComplemento")]
            public string? PrdLngComplemento { get; set; }

            [JsonProperty("undDesNomeNcm")]
            public string? UndDesNomeNcm { get; set; }
        }

        public class ResponseDataProdutos
        {
            [JsonProperty("comProdutos")]
            public ConsultaProdutoDTO ComProdutos { get; set; }
        }

        public class RootObjectProdutos
        {
            [JsonProperty("messages")]
            public List<Message> Messages { get; set; }

            [JsonProperty("responseData")]
            public ResponseDataProdutos ResponseData { get; set; }
        }
    }
}
