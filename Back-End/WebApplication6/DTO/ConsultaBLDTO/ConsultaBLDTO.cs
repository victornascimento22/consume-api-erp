using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApplication6.DTO.ConsultaBL
{
    public class Message
    {
        [JsonProperty]
        public string valid { get; set; }
    }
    public class ConsultaBLDTO
    {
        [JsonProperty]
        public long? cntCod { get; set; }
        [JsonProperty]
        public string? cntEspNumeroHouse { get; set; }
        [JsonProperty]
        public string? cntEspNumeroMaster { get; set; }
        [JsonProperty]
        public string? cntVldTpDocCarga { get; set; }
        [JsonProperty]
        public long? priCod { get; set; }
        [JsonProperty]
        public string? priEspRefcliente { get; set; }
        [JsonProperty]
        public string? cntDtaEmissao { get; set; }
        [JsonProperty]
        public string? cntEspNickmaster { get; set; }
        [JsonProperty]
        public string? viaDesNome { get; set; }
        [JsonProperty]
        public long? pesCodExportador { get; set; }
        [JsonProperty]
        public string? priVldStatus { get; set; }
        [JsonProperty]
        public long? cntQtdContainers { get; set; }
        [JsonProperty]
        public long? cntQtdPallets { get; set; }
        [JsonProperty]
        public decimal? cntMnyValorFinal { get; set; }
        [JsonProperty]
        public decimal? cntMnyFrete { get; set; }
        [JsonProperty]
        public string? cntEspManifesto { get; set; }
        [JsonProperty]
        public string? cntDtaEntrega { get; set; }
        public decimal? cntPreM3 { get; set; }
        [JsonProperty]
        public decimal? cntPrePesoBruto { get; set; }
        [JsonProperty]
        public decimal? cntPrePesoLiquido { get; set; }
        [JsonProperty]
        public string? cntEspNumeracao { get; set; }
        [JsonProperty]
        public string? cntEspNumeroPckList { get; set; }
        public string? cntVldConsolidado { get; set; }
        [JsonProperty]
        public long? cntPreDemurrage { get; set; }
        [JsonProperty]
        public long? cntPreTransitTime { get; set; }
        [JsonProperty]
        public string? cntDtaPrevCheg { get; set; }
        [JsonProperty]
        public string? cntDtaEmbarque { get; set; }
        [JsonProperty]
        public string? cntDtaChegada { get; set; }
        [JsonProperty]
        public decimal? cntMnyVlrDolar { get; set; }
        [JsonProperty]
        public decimal? cntMnyVlrFinalDolar { get; set; }
        [JsonProperty]
        public string? cntDtaPrevSai { get; set; }
        [JsonProperty]
        public string? cntDtaSaida { get; set; }
        public string? cntEspNumDst { get; set; }
        [JsonProperty]
        public string? cntEspObsmerc { get; set; }
        [JsonProperty]
        public string? cntDtaFechTrans { get; set; }
        [JsonProperty]
        public string? cntDtaPrevEmb { get; set; }
        [JsonProperty]
        public string? cntVldFormaNac { get; set; }
        [JsonProperty]
        public string? oriDesNomeOri { get; set; }
        [JsonProperty]
        public string? paDesNomeOri { get; set; }
        [JsonProperty]
        public string? ufEspSiglaOri { get; set; }
        [JsonProperty]
        public string? cidEspNomeOri { get; set; }
        [JsonProperty]
        public string? oriDesNomeDest { get; set; }
        [JsonProperty]
        public string? paDesNomeDest { get; set; }
        [JsonProperty]
        public string? ufEspSiglaDest { get; set; }
        [JsonProperty]
        public string? cidEspNomeDest { get; set; }
        [JsonProperty]
        public string? pesCodConsignatarioDesc { get; set; }
        [JsonProperty]
        public string? pesCodExportadorDesc { get; set; }
        [JsonProperty]
        public string? pesCodArmazemDesc { get; set; }
        [JsonProperty]
        public string? dpeNomPessoaArm { get; set; }
        [JsonProperty]
        public string? dpeNomPessoaAge { get; set; }
        [JsonProperty]
        public string? dpeNomPessoaAgtransp { get; set; }
        [JsonProperty]
        public string? moeEspNome { get; set; }
        [JsonProperty]
        public string? moeEspNomeFrete { get; set; }
        [JsonProperty]
        public string? veiDesNome { get; set; }
        [JsonProperty]
        public string? paDesNomeProc { get; set; }
        [JsonProperty]
        public string? dpeNomPessoaNot { get; set; }
        [JsonProperty]
        public string? dpeNomPessoaShip { get; set; }
        [JsonProperty]
        public string? veiDesNomeTransbordo { get; set; }
        [JsonProperty]
        public string? veiDesNomeTransbordo2 { get; set; }
        [JsonProperty]
        public string? urfDesNome { get; set; }
        [JsonProperty]
        public string? banDesNome { get; set; }
        [JsonProperty]
        public string? oriDesNomeTransbordo { get; set; }
        [JsonProperty]
        public string? oriDesNomeTransbordo2 { get; set; }
        [JsonProperty]
        public string? oriDesNomeIniTras { get; set; }
        [JsonProperty]
        public string? urfDesNomeEntrada { get; set; }
    }
    public class ResponseDataBL
    {
        [JsonProperty]
        public ConsultaBLDTO prcConhecimentoTrasp { get; set; }
    }

    public class RootObject
    {


        [JsonProperty]
        public List<Message> messages { get; set; }
        [JsonProperty]
        public ResponseDataBL responseData { get; set; }
    }


}
