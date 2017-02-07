using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class DAO
    {
        public DataSet Dados { get; set; }

        public DAO( string sql )
        {
            Dados = new DataSet();

            using ( OleDbConnection conn = OpenConn() )
            {
                OleDbDataAdapter adp = new OleDbDataAdapter( sql, conn );

                adp.Fill( Dados );
            }
        }

        private OleDbConnection OpenConn()
        {

            try
            {
                OleDbConnection _conn = new OleDbConnection( @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C\GEDMidia\DBGED.mdb;Persist Security Info=False;Jet OLEDB:Database Password=selva406" );

                _conn.Open();

                return _conn;
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }

        }
    }
}
