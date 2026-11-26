using System.Collections.Generic;
namespace CajeroAutomatico2
{
    // MOLDE: describe los datos que tiene cada cuenta del cajero
    public class Cuenta
    {
        public string NumeroCuenta { get; set; }   // 11 dígitos
        public string Titular { get; set; }        // nombre del dueño
        public string Pin { get; set; }            // 4 dígitos
        public decimal Saldo { get; set; }         // dinero disponible
        public bool Bloqueada { get; set; }        // true = cuenta bloqueada
        public int IntentosFallidos { get; set; }  // cuántas veces falló el PIN
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();  // historial de la cuenta
    }
}