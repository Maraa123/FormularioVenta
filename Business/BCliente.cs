using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCliente
    {
        public static List<Cliente> Get()
        {
            try
            {
                return DCliente.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
