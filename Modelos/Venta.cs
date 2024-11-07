using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venta
    {
        public int idVenta { get; set; }//
        Cliente cliente { get; set; }//
        TipoComprobante tipoComprobante { get; set; }//
        Moneda moneda { get; set; }//
        Cuenta cuenta { get; set; }//
        public DateTime fecha { get; set; }//
        public int imputacion { get; set; }//
        public decimal tipoCambio { get; set; }//
        public int punto { get; set; }//
        public string numero { get; set; }//
        public double? netoGravado { get; set; }//
        public double? netoNoGravado { get; set; }//
        public double? exento { get; set; }//
        public double? iva { get; set; }//
        public double? percIVA { get; set; }//
        public double? percIIBB { get; set; }//
        public double? percMunicipalidad { get; set; }//
        CentroCosto? centroCosto { get; set; }
        public Venta() { }

        public int? Cliente {
            get
            {
                if (cliente != null)
                    return cliente.idCliente;
                else
                    return null;
            }
        }

        public int? TipoComprobante
        {
            get
            {
                if (tipoComprobante != null)
                    return tipoComprobante.idTipo;
                else
                    return null;
            }
        }
        public int? Moneda
        {
            get
            {
                if (moneda != null)
                    return moneda.idMoneda;
                else
                    return null;
            }
        }
        public  int? CentroCosto
        {
            get
            {
                if (centroCosto != null)
                    return centroCosto.idCentro;
                else
                    return null;
            }
        }

        public int? Cuenta
        {
            get
            {
                if (cuenta != null)
                    return cuenta.idCuenta;
                else
                    return null;
            }
        }

        public Venta(int idVenta, Cliente cliente, TipoComprobante tipoComprobante, Moneda moneda, Cuenta cuenta, DateTime fecha, int imputacion, decimal tipoCambio, int punto, string numero, double netoGravado, double netoNoGravado, double exento, double iva, double percIVA, double percIIBB, double percMunicipalidad, CentroCosto centroCosto)
        {
            this.idVenta = idVenta;
            this.cliente = cliente;
            this.tipoComprobante = tipoComprobante;
            this.moneda = moneda;
            this.cuenta = cuenta;
            this.fecha = fecha;
            this.imputacion = imputacion;
            this.tipoCambio = tipoCambio;
            this.punto = punto;
            this.numero = numero;
            this.netoGravado = netoGravado;
            this.netoNoGravado = netoNoGravado;
            this.exento = exento;
            this.iva = iva;
            this.percIVA = percIVA;
            this.percIIBB = percIIBB;
            this.percMunicipalidad = percMunicipalidad;
            this.centroCosto = centroCosto;

        }

    }
}
