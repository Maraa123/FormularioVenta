using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BTipoCuenta
    {
        public static List<TipoCuenta> Get()
        {
            try
            {
                return DTipoCuenta.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
