using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApplication6.DTO.ConsultaBL
{
    public class MessageCE
    {
        [JsonProperty]
        public string valid { get; set; }
    }

    public class CargaCeDTO
    {
        [JsonProperty("sncEspNumce")]
        public string? SncEspNumce { get; set; }

        [JsonProperty("priEspRefcliente")]
        public string? PriEspRefcliente { get; set; }

        [JsonProperty("numBl")]
        public string? NumBl { get; set; }

        [JsonProperty("sndVldStatus")]
        public string? SndVldStatus { get; set; }

        [JsonProperty("sndDtaStatus")]
        public string? SndDtaStatus { get; set; }

        [JsonProperty("sndEspAmzDesc")]
        public string? SndEspAmzDesc { get; set; }

        [JsonProperty("sndEspAmzTipo")]
        public string? SndEspAmzTipo { get; set; }

        [JsonProperty("sndEspAmzNum")]
        public string? SndEspAmzNum { get; set; }

        [JsonProperty("tpdCon")]
        public string? TpdCon { get; set; }

        [JsonProperty("ceMaster")]
        public string? CeMaster { get; set; }

        [JsonProperty("dtaEmiss")]
        public string? DtaEmiss { get; set; }
    }

    public class ResponseDataCE 
    {
        [JsonProperty]
        public CargaCeDTO prcConhecimentoTrasp { get; set; }
    }

    public class RootObjectCE
    {


        [JsonProperty]
        public List<MessageCE> messages { get; set; }
        [JsonProperty]
        public ResponseDataCE responseData { get; set; }
    }
}
