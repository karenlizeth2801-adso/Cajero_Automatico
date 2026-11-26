using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico2
{
    public partial class frmDeposito : Form
    { 
        // La cuenta que inició sesión en el login (la tomamos del Banco)
        private Cuenta cuentaActual;

        // Monto que el cliente quiere depositar
        private decimal monto;

        // Respuesta del cliente en la ventana de confirmación (Sí o No)
        private DialogResult respuesta;

        // Movimiento que vamos a anotar en el historial de la cuenta
        private Movimiento nuevoMovimiento;

        // Regla del sistema: máximo que se puede depositar en una sola operación
        private const decimal LIMITE_POR_DEPOSITO = 5000000;

        // Colores para los mensajes: rojo claro para errores, verde claro para éxito
        private readonly Color colorError = Color.LightCoral;
        private readonly Color colorExito = Color.LightGreen;

        public frmDeposito()
        {
            InitializeComponent();
        }

        private void frmDeposito_Load(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando la ventana de depósito se abre.

            // Guardamos en la variable de arriba la cuenta que inició sesión
            cuentaActual = Banco.CuentaActual;

            // Mostramos su saldo con formato de dinero, sin decimales 
            lblSaldo.Text = "Saldo disponible: " + cuentaActual.Saldo.ToString("C0");
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // EVENTO: se ejecuta cada vez que el usuario presiona una tecla en el campo del monto.
            // char.IsDigit  -> es un número (0 al 9)
            // char.IsControl -> es una tecla especial, como Borrar (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // e.Handled = true bloquea la tecla: no se escribe en el campo
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en CONFIRMAR DEPÓSITO.

            // VALIDACIÓN 1: la caja no puede estar vacía
            if (txtMonto.Text.Trim() == "")
            {
                lblMensaje.ForeColor = colorError;
                lblMensaje.Text = "Escribe un monto.";
                return; // "return" detiene el método aquí
            }

            // Convertimos el texto a número y lo guardamos en la variable de arriba
            monto = decimal.Parse(txtMonto.Text);

            // VALIDACIÓN 2: el monto debe ser mayor que cero
            if (monto <= 0)
            {
                lblMensaje.ForeColor = colorError;
                lblMensaje.Text = "El monto debe ser mayor que cero.";
                return;
            }

            // VALIDACIÓN 3: el monto no puede superar el límite por depósito
            if (monto > LIMITE_POR_DEPOSITO)
            {
                lblMensaje.ForeColor = colorError;
                lblMensaje.Text = "El máximo por depósito es " + LIMITE_POR_DEPOSITO.ToString("C0") + ".";
                return;
            }

            // Si pasó las validaciones, limpiamos el mensaje de error
            lblMensaje.Text = "";

            // Le preguntamos al cliente si está seguro del depósito
            respuesta = MessageBox.Show("¿Confirmas el depósito de " + monto.ToString("C0") + "?",
                "Confirmar depósito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si responde que No, cancelamos: no se suma nada
            if (respuesta == DialogResult.No)
            {
                lblMensaje.ForeColor = colorError;
                lblMensaje.Text = "Depósito cancelado.";
                return;
            }

            // Sumamos el monto al saldo de la cuenta
            cuentaActual.Saldo = cuentaActual.Saldo + monto;

            // Creamos el movimiento con los datos del depósito
            nuevoMovimiento = new Movimiento();
            nuevoMovimiento.Fecha = DateTime.Now;                     // fecha y hora de este momento
            nuevoMovimiento.Tipo = "Depósito";                        // qué tipo de operación fue
            nuevoMovimiento.Monto = monto;                            // cuánto se depositó
            nuevoMovimiento.SaldoResultante = cuentaActual.Saldo;     // saldo que quedó después

            // Lo agregamos a la libreta (la lista) de movimientos de la cuenta
            cuentaActual.Movimientos.Add(nuevoMovimiento);

            // Actualizamos el saldo que se ve en pantalla
            lblSaldo.Text = "Saldo disponible: " + cuentaActual.Saldo.ToString("C0");

            // Mostramos el mensaje de éxito en verde
            lblMensaje.ForeColor = colorExito;
            lblMensaje.Text = "Depósito exitoso. Depositaste " + monto.ToString("C0") + ".";

            // Limpiamos la caja para un nuevo depósito
            txtMonto.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en VOLVER.
            // Cerramos esta ventana. Como el menú la abrió con ShowDialog,
            // al cerrarse el menú vuelve a aparecer solo.
            this.Close();
        }
    }
}
