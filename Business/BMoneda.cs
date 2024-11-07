using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BMoneda
    {
        public static List<Moneda> Get()
        {
            try
            {
                return DMoneda.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
