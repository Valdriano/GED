using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class ModalidadeProc : Filtros
    {
        public string MOPMODALIDADE { get; set; }
        public string MOPSIGLA { get; set; }
        public ModalidadeProc()
        {
            SQL = "SELECT MOPID, MOPMODALIDADE, MOPSIGLA FROM MODALIDADEPROC";
        }

        public DataSet Dados()
        {
            return new DAO( SQL ).Dados;
        }
    }
}
