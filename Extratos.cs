using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class Extratos : Filtros
    {
        public Extratos()
        {
            SQL = "SELECT ID, TPDOC, CODMUN, EXEORC, ORGAO, UNDORC, BANCO, AGENCIA, CONTA, DTABERTURA, DTREFDOC, SUBSTRING( DTREFDOC, 5, 2 ) +' - ' + SUBSTRING( DTREFDOC, 1, 4 ) AS DATA, SITU, IMG FROM EXTRATOS ";
        }

        public DataSet Dados()
        {
            string WHERE = " WHERE 1 = 1 ";
            if ( NUM_CONTA != string.Empty ) WHERE = WHERE + " AND CONTA = " + NUM_CONTA;
            WHERE = WHERE + " AND SUBSTRING( DTREFDOC, 5, 2 )  BETWEEN " + MES_INI + " AND " + MES_FIM;

            return new DAO( SQL + WHERE ).Dados;
        }
    }
}
