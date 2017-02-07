using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class Licitacao : Filtros
    {
        public Licitacao()
        {
            SQL = "SELECT ID, TPDOC, CODMUN, NUMPROC, MODALPROC, DESCOBJ, TOTALORC, DTREAL, MODALIC, TIPOLIC,DTREFDOC, SUBSTRING( DTREFDOC , 5 , 2 ) + ' - ' + SUBSTRING( DTREFDOC, 1 , 4) AS DATA, LICUNG, SITU FROM LICITACAO ";
        }

        public DataSet Dados()
        {
            string WHERE = " WHERE 1 = 1 ";
            if ( NUM_PROC != string.Empty ) WHERE = WHERE + " AND NUMPROC = " + NUM_PROC;
            if ( MODALPROC != string.Empty ) WHERE = WHERE + " AND MODALPROC = " + MODALPROC;

            WHERE = WHERE + " AND SUBSTRING( DTREFDOC , 5 , 2 ) BETWEEN " + MES_INI + " AND " + MES_FIM;

            return new DAO( SQL + WHERE ).Dados;
        }
    }
}
