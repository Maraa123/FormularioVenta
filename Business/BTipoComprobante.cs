using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BTipoComprobante
    {
        public static List<TipoComprobante> Get()
        {
            try
            {
                return DTipoComprobante.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
