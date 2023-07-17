using System;
using System.Collections.Generic;

namespace WebApplication6.DTO.ProcessoResumoDTO
{
    public class Message
    {
        public string? valid { get; set; }
    }

    public class ProcessoResumoDTO
    {
        public int? filCod { get; set; }
        public int? priCod { get; set; }
        public string? refExt { get; set; }
        public string? refCli { get; set; }
        public string? refAux { get; set; }
        public object? priMast { get; set; }
        public int? pesCod { get; set; }
        public int? pesSeq { get; set; }
        public string? pesDes { get; set; }
        public string? priDesTipo { get; set; }
        public string? respDes { get; set; }
        public string? finDes { get; set; }
        public string? regAduaDesTipo { get; set; }
        public long? dtaAber { get; set; }
        public object? fechGeral { get; set; }
        public long? dtaFechFinanceiro { get; set; }
        public string? encomDes { get; set; }
        public string? despDes { get; set; }
        public string? moeda { get; set; }
        public object? mnegCollect { get; set; }
        public int? mnegPrep { get; set; }
        public int? mnegTotal { get; set; }
        public string? conhecTransp { get; set; }
        public long? dtaEmbBl { get; set; }
        public string? sitEmbaDes { get; set; }
        public long? dtaChegBl { get; set; }
        public string? sitChegDes { get; set; }
        public string? viaTranspDes { get; set; }
        public string? origem { get; set; }
        public string? paisOrig { get; set; }
        public string? ufOrig { get; set; }
        public string? ufDest { get; set; }
        public string? paisDest { get; set; }
        public string? numDi { get; set; }
        public long? dtaCi { get; set; }
        public long? dtaReg { get; set; }
        public string? canalDes { get; set; }
        public object? numLi { get; set; }
        public string? incoterm { get; set; }
        public int? mnyFobInv { get; set; }
        public string? moeFob { get; set; }
        public int? qtdCont { get; set; }
        public object? dtaRealRegDi { get; set; }
        public object? dtaPrevRegDi { get; set; }
        public object? dtaRegDesem { get; set; }
        public object? dtaPrevDesem { get; set; }
        public object? dtaReaFatu { get; set; }
        public object? dtaPrevFatu { get; set; }
        public object? dtaRealCar { get; set; }
        public object? dtaPrevCar { get; set; }
        public object? dtaRealEmb { get; set; }
        public object? dtaPrevEmb { get; set; }
        public string? priSitDes { get; set; }
        public string? priStatusDes { get; set; }
        public object? localtransbDes { get; set; }
        public string? mercDes { get; set; }
        public string? necesLi { get; set; }
        public string? agentCargDes { get; set; }
        public string? armadorCiaDes { get; set; }
        public string? consignee { get; set; }
        public long? dtaEtd { get; set; }
        public object? navOrigDes { get; set; }
        public object? dtaTrasb { get; set; }
        public object? navTransDes { get; set; }
        public long? dtaEta { get; set; }
        public int? freeTime { get; set; }
        public long? presCarga { get; set; }
        public string? armAlfan { get; set; }
        public double? txaRegDi { get; set; }
        public object? dtaNumRec { get; set; }
        public double? solNum { get; set; }
   
        public long? dtaFat { get; set; }
        public string? urfDesem { get; set; }
        public object? fiscNomDes { get; set; }
    }

    public class ResponseData
    {
        public ProcessoResumoDTO? processoResumoDTO { get; set; }
    }

    public class RootObject
    {
        public List<Message>? messages { get; set; }
        public ResponseData? responseData { get; set; }
    }
}
