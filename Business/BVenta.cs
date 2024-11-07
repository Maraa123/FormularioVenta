using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Modelos;

namespace Business
{
    public class BVenta
    {
        public static List<Venta> Get()
        {
            try
            {

                return DVenta.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(int codCliente, int codTipoComprobante, int codMoneda, int codCuenta, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto)
            
        {
            try
            {
                DVenta.InsertVenta(codCliente,  codTipoComprobante,  codMoneda, codCuenta, fecha,  imputacion,  tipoCambio,  punto,  numero,  netoGravado,  netoNoGravado,exento,  iva, percIVA,  percIIBB,percMunicipalidad, codCentroCosto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(int codCliente, int codTipoComprobante, int codMoneda, int codCuenta, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, int codCentroCosto)
        {
            try
            {
                DVenta.UpdateVenta(codCliente, codTipoComprobante, codMoneda, codCuenta, fecha, imputacion, tipoCambio, punto, numero, netoGravado, netoNoGravado, exento, iva, percIVA, percIIBB, percMunicipalidad, codCentroCosto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Delete(int idVenta)
        {
            try
            {
                DVenta.DeleteVenta(idVenta);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
