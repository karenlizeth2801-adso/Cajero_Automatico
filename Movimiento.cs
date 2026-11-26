using System;

namespace CajeroAutomatico2
{
    // MOLDE: describe los datos de cada movimiento (retiro, depósito, etc.)
    public class Movimiento
    {
        public DateTime Fecha { get; set; }        // fecha y hora de la operación
        public string Tipo { get; set; }           // "Retiro", "Depósito"...
        public decimal Monto { get; set; }         // cuánto dinero se movió
        public decimal SaldoResultante { get; set; } // saldo que quedó después
    }
}
