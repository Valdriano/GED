using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEDConsultar
{
    class Mes
    {
        public string Codigo { get; set; }
    }

    class Meses
    {
        List<Mes> meses = new List<Mes>();

        public Meses()
        {
            meses.Add( new Mes { Codigo = "01" } );
            meses.Add( new Mes { Codigo = "02" } );
            meses.Add( new Mes { Codigo = "03" } );
            meses.Add( new Mes { Codigo = "04" } );
            meses.Add( new Mes { Codigo = "05" } );
            meses.Add( new Mes { Codigo = "06" } );
            meses.Add( new Mes { Codigo = "07" } );
            meses.Add( new Mes { Codigo = "08" } );
            meses.Add( new Mes { Codigo = "09" } );
            meses.Add( new Mes { Codigo = "10" } );
            meses.Add( new Mes { Codigo = "11" } );
            meses.Add( new Mes { Codigo = "12" } );
        }

        public List<Mes> Dados()
        {
            return meses;
        }
    }
}
