using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class Processos : Filtros
    {
        public Processos()
        {
            SQL = "SELECT P.PRC_ID, P.PRC_CODMUN, P.PRC_DOCCAIXA, P.PRC_CATEG_ECON, P.PRC_CONVENIO, P.PRC_LOTE, P.PRC_LOCALIZACAO,P.PRC_DTREFDOC, SUBSTRING(P.PRC_DTREFDOC,1 , 2 ) + ' - ' + SUBSTRING(P.PRC_DTREFDOC , 3, 4) AS DATA, P.PRC_VRPAGAM, P.PRC_ORGAO, P.PRC_UND_ORC," +
                  " P.PRC_UND_GEST, P.PRC_NOTAEMP, P.PRC_ELEMDESP, P.PRC_NUMSUBEMP, P.PRC_NOTAPAG, P.PRC_CODRESP_PAG, P.PRC_NMRESP_PAG, P.PRC_DTPAGAM, P.PRC_NUM_EMPENHO, P.PRC_CREDOR," +
                  " P.PRC_CNPJ_CPF, P.DEX_CONTAEXTRA, P.DEX_BANCO, P.DEX_AGENCIA, P.DEX_NCHQDOC, P.DEX_DTDESP, P.DEX_VRDESPESA, P.DEX_VRDEDUCAO, P.DEX_TIPO, P.DEX_CONTA, P.DEX_MESANO," +
                  " P.PRC_IMG, UG.UOR_ID, UG.UOR_COD_UNG, UG.UOR_COD_ORGAO, UG.UOR_NOME_ORGAO, UG.UOR_COD_UNIDORC, UG.UOR_NOME_UNIDORC, UG.UNG_ID, UG.UNG_COD_MUNICIPIO," +
                  " UG.UNG_COD_UNG, UG.UNG_NOME_UG, UG.UNG_SIGLA, UG.UOR_MESANOINI, UG.UOR_MESANOFIM" +
                  " FROM PROCESSOS AS P LEFT OUTER JOIN VW_UNIDGESTORGUNDORC AS UG ON UG.UOR_COD_ORGAO = P.PRC_ORGAO AND UG.UOR_COD_UNIDORC = P.PRC_UND_ORC";
        }

        public DataSet Dados()
        {
            string WHERE = " WHERE 1 = 1 ";
            if ( DOC_CAIXA != string.Empty ) WHERE = WHERE + " AND P.PRC_DOCCAIXA = " + DOC_CAIXA;
            if ( NUM_EMPENHO != string.Empty ) WHERE = WHERE + " AND P.PRC_NUM_EMPENHO = " + NUM_EMPENHO;
            if ( CREDOR != string.Empty ) WHERE = WHERE + " AND P.PRC_CREDOR = " + CREDOR;

            WHERE = WHERE + " AND( SUBSTRING( P.PRC_DTREFDOC , 1 , 2 ) BETWEEN " + MES_INI + " AND " + MES_FIM;

            return new DAO( SQL + WHERE ).Dados;
        }
    }
}
