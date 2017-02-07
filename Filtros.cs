using System;

namespace GEDConsultar
{
    class Filtros
    {
        public string SQL { get; set; }
        public string DOC_CAIXA { get; set; } = string.Empty;
        public string NUM_EMPENHO { get; set; } = string.Empty;
        public string MES_INI { get; set; } = string.Empty;
        public string MES_FIM { get; set; } = string.Empty;
        public string CREDOR { get; set; } = string.Empty;
        public string NUM_CONTA { get; set; } = string.Empty;
        public string NUM_PROC { get; set; } = string.Empty;
        public string MODALPROC { get; set; } = string.Empty;
    }
}
