namespace WebApplication6.DTO
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;


    public class VolumesNfDTO
    {
        [JsonProperty("cdvDesVolume")]
        public string? CdvDesVolume { get; set; }

        [JsonProperty("cdvQtdVolumes")]
        public decimal? CdvQtdVolumes { get; set; }

        [JsonProperty("cdvFltPesoBruto")]
        public decimal? CdvFltPesoBruto { get; set; }

        [JsonProperty("cdvFltPesoLiquido")]
        public decimal? CdvFltPesoLiquido { get; set; }
    }
    public class NfeDTO
    {
        [JsonProperty("fdnEspId")]
        public string? fdnEspId { get; set; }


    }

    public class NotaFiscalSaidaDTO
    {
        [JsonProperty("docCod")]
        public long? DocCod { get; set; }

        [JsonProperty("pdcDocFederal")]
        public string? PdcDocFederal { get; set; }

        [JsonProperty("dpeNomPessoa")]
        public string? DpeNomPessoa { get; set; }

        [JsonProperty("docEspDocest")]
        public string? DocEspDocest { get; set; }

        [JsonProperty("endEspZipcod")]
        public string? EndEspZipcod { get; set; }

        [JsonProperty("paDesNome")]
        public string? PaDesNome { get; set; }

        [JsonProperty("endDesCidade")]
        public string? EndDesCidade { get; set; }

        [JsonProperty("endDesBairro")]
        public string? EndDesBairro { get; set; }

        [JsonProperty("endDesLogradouro")]
        public string? EndDesLogradouro { get; set; }

        [JsonProperty("endEspNlogradouro")]
        public string? EndEspNlogradouro { get; set; }

        [JsonProperty("espSerie")]
        public string? EspSerie { get; set; }

        [JsonProperty("docEspNumero")]
        public string? DocEspNumero { get; set; }

        [JsonProperty("fisVldFundapDesc")]
        public string? FisVldFundapDesc { get; set; }

        [JsonProperty("docMnyValor")]
        public decimal? DocMnyValor { get; set; }

        [JsonProperty("vldStatus")]
        public string? VldStatus { get; set; }

        [JsonProperty("fisVldNfemitida")]
        public string? FisVldNfemitida { get; set; }

        [JsonProperty("tpdDesNome")]
        public string? TpdDesNome { get; set; }

        [JsonProperty("pesCod")]
        public long? PesCod { get; set; }

        [JsonProperty("pgtDesNome")]
        public string? PgtDesNome { get; set; }

        [JsonProperty("gerDes")]
        public string? GerDes { get; set; }

        [JsonProperty("amzDesNome")]
        public string? AmzDesNome { get; set; }

        [JsonProperty("ufEspSigla")]
        public string? UfEspSigla { get; set; }

        [JsonProperty("mnyBruto")]
        public decimal? MnyBruto { get; set; }

        [JsonProperty("mnyLiquido")]
        public decimal? MnyLiquido { get; set; }

        [JsonProperty("mnyIcms")]
        public decimal? MnyIcms { get; set; }

        [JsonProperty("mnyPis")]
        public decimal? MnyPis { get; set; }

        [JsonProperty("mnyCofins")]
        public decimal? MnyCofins { get; set; }

        [JsonProperty("mnyIpi")]
        public decimal? MnyIpi { get; set; }

        [JsonProperty("mnyIcmsSub")]
        public decimal? MnyIcmsSub { get; set; }

        [JsonProperty("fisCodTransportadora")]
        public long? FisCodTransportadora { get; set; }

        [JsonProperty("pdcDocFederalTrans")]
        public string? PdcDocFederalTrans { get; set; }

        [JsonProperty("dpeNomPessoaTrans")]
        public string? DpeNomPessoaTrans { get; set; }

        [JsonProperty("paDesNomeTrans")]
        public string? PaDesNomeTrans { get; set; }

        [JsonProperty("fisEspPlaca")]
        public string? FisEspPlaca { get; set; }

        [JsonProperty("ufEspSiglaTrans")]
        public string? UfEspSiglaTrans { get; set; }

        [JsonProperty("pesCodTransRed")]
        public long? PesCodTransRed { get; set; }

        [JsonProperty("dpeNomPessoaTransRed")]
        public string? DpeNomPessoaTransRed { get; set; }

        [JsonProperty("pdcDocFederalTransRed")]
        public string? PdcDocFederalTransRed { get; set; }

        [JsonProperty("endEspZipcodTransRed")]
        public string? EndEspZipcodTransRed { get; set; }

        [JsonProperty("paDesNomeTransRed")]
        public string? PaDesNomeTransRed { get; set; }

        [JsonProperty("ufEspSiglaTransRed")]
        public string? UfEspSiglaTransRed { get; set; }

        [JsonProperty("endDesCidadeTransRed")]
        public string? EndDesCidadeTransRed { get; set; }

        [JsonProperty("endDesBairroTransRed")]
        public string? EndDesBairroTransRed { get; set; }

        [JsonProperty("endDesLogradouroTransRed")]
        public string? EndDesLogradouroTransRed { get; set; }

        [JsonProperty("endEspNlogradouroTransRed")]
        public string? EndEspNlogradouroTransRed { get; set; }

        [JsonProperty("fisEspIdBalsa")]
        public string? FisEspIdBalsa { get; set; }

        [JsonProperty("fisEspIdVagao")]
        public string? FisEspIdVagao { get; set; }

        [JsonProperty("obs")]
        public string? Obs { get; set; }

        [JsonProperty("docDtaEmissao")]
        public string? DocDtaEmissao { get; set; }

        [JsonProperty("nfeDTOList")]
        public List<NfeDTO> NfeDTOList { get; set; }

        [JsonProperty("volumesNfDTOList")]
        public List<VolumesNfDTO> VolumesNfDTOList { get; set; }
    }

}
