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
    public partial class frmLogin : Form
    {
      
        // "const" significa constante: un valor que nunca cambia mientras el programa corre.
        // Se escriben en MAYÚSCULAS para reconocerlas rápido.

        // Regla del sistema: el número de cuenta tiene exactamente 11 dígitos
        private const int LONGITUD_CUENTA = 11;

        // Regla del sistema: el PIN tiene exactamente 4 dígitos
        private const int LONGITUD_PIN = 4;

        // Color rojo que usamos para todos los mensajes de error
        private readonly Color colorError = Color.FromArgb(214, 69, 69);


        // Variables que usa el botón INGRESAR (declaradas al inicio de la clase)
        private string cuenta;               // número de cuenta que escribió el usuario
        private string pin;                  // PIN que escribió el usuario
        private ResultadoLogin resultado;    // respuesta que da el Banco
        private int restantes;               // intentos que le quedan al usuario
        private frmMenu menu;                // ventana del menú principal

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {   // Muestra una ventana con la pregunta y los botones Sí / No.
            // Lo que el usuario elija se guarda en la variable "r".
            DialogResult r = MessageBox.Show("¿Deseas salir de la aplicación?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar es la tecla que se presionó.
            // char.IsDigit  -> es un número (0 al 9)
            // char.IsControl -> es una tecla especial, como Borrar (Backspace)
            // Si NO es número y NO es tecla especial, la bloqueamos.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                // e.Handled = true le dice a Windows: "ya manejé esta tecla, no la escribas".
                e.Handled = true;

        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números en el campo del PIN
            // char.IsDigit  -> es un número (0 al 9)
            // char.IsControl -> es una tecla especial, como Borrar (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // e.Handled = true bloquea la tecla: no se escribe en el campo
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Guardamos lo que escribió el usuario en dos variables.
            // Trim() quita los espacios que pudieran quedar al inicio o al final.
            cuenta = txtCuenta.Text.Trim();
            pin = txtPin.Text.Trim();

            // El mensaje de error siempre se muestra en rojo
            lblMensaje.ForeColor = colorError;

            // VALIDACIÓN 1: que ningún campo esté vacío
            if (cuenta == "" || pin == "")
            {
                lblMensaje.Text = "Completa todos los campos.";
                return; // "return" detiene el método aquí
            }

            // VALIDACIÓN 2: el número de cuenta debe tener exactamente 11 dígitos
            if (cuenta.Length != LONGITUD_CUENTA )
            {
                lblMensaje.Text = "El número de cuenta debe tener 11 dígitos.";
                return;
            }

            // VALIDACIÓN 3: el PIN debe tener exactamente 4 dígitos
            if (pin.Length != LONGITUD_PIN)
            {
                lblMensaje.Text = "El PIN debe tener 4 dígitos.";
                return;
            }

            // Le pedimos al Banco que revise la cuenta y el PIN
            resultado = Banco.Autenticar(cuenta, pin);

            // Según lo que responda el Banco, hacemos algo distinto
            switch (resultado)
            {
                case ResultadoLogin.Correcto:
                    lblMensaje.Text = "";

                    // Escondemos el login mientras el cliente está en el menú
                    this.Hide();

                    // Creamos la ventana del menú y la mostramos.
                    // ShowDialog() pausa el código aquí hasta que el menú se cierre.
                    menu = new frmMenu();
                    menu.ShowDialog();

                    // Cuando el menú se cierra, volvemos al login limpio
                    txtCuenta.Clear();
                    txtPin.Clear();
                    txtCuenta.Focus();
                    this.Show();
                    break;

                case ResultadoLogin.CuentaNoExiste:
                    lblMensaje.Text = "La cuenta no existe.";
                    break;

                case ResultadoLogin.Bloqueada:
                    lblMensaje.Text = "Cuenta bloqueada. Contacta a tu banco.";
                    break;

                case ResultadoLogin.PinIncorrecto:
                    // Calculamos cuántos intentos le quedan (el máximo es 3)
                    restantes = 3 - Banco.Cuentas[cuenta].IntentosFallidos;
                    lblMensaje.Text = "PIN incorrecto. Intentos restantes: " + restantes;
                    txtPin.Clear();  // borramos el PIN para que lo escriba de nuevo
                    txtPin.Focus();  // dejamos el cursor listo en el campo del PIN
                    break;

                case ResultadoLogin.BloqueadaAhora:
                    lblMensaje.Text = "Demasiados intentos. La cuenta fue bloqueada.";
                    txtPin.Clear();
                    break;
            }

        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
