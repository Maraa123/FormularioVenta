using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCentroCosto
    {
        public static List<CentroCosto> Get()
        {
            try
            {
                return DCentroCosto.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
