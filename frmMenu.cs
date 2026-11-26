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
    public partial class frmMenu : Form
    {
        
        // Ventana de retiro que abre el botón Retirar
        private frmRetiro ventanaRetiro;
        // Ventana de depósito que abre el botón Depositar
        private frmDeposito ventanaDeposito;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando la ventana del menú se abre.
            // Banco.CuentaActual es la cuenta que inició sesión en el login.
            // .Titular es el nombre del dueño de esa cuenta.
            lblSaludo.Text = "Hola, " + Banco.CuentaActual.Titular;
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en "Consultar saldo".
            // Banco.CuentaActual es la cuenta que inició sesión.
            // ToString("C0") le da formato de dinero, sin decimales (ej: $1.500.000).
            MessageBox.Show("Tu saldo disponible es: " + Banco.CuentaActual.Saldo.ToString("C0"),
                "Consultar saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en "Cerrar sesión".
            // Preguntamos primero, para evitar cerrar la sesión por error.
            DialogResult r = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Borramos la cuenta que estaba en uso: ya nadie tiene la sesión iniciada
                Banco.CuentaActual = null;

                // Cerramos el menú y el login vuelve a aparecer limpio
                this.Close();
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en "Retirar".

            // Creamos la ventana de retiro y la guardamos en la variable de arriba
            ventanaRetiro = new frmRetiro();

            // Escondemos el menú mientras el cliente está en la ventana de retiro
            this.Hide();

            // ShowDialog() pausa el código aquí hasta que la ventana de retiro se cierre
            ventanaRetiro.ShowDialog();

            // Cuando se cierra, mostramos el menú otra vez
            this.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            // EVENTO: se ejecuta cuando el usuario hace clic en "Depositar".

            // Creamos la ventana de depósito y la guardamos en la variable de arriba
            ventanaDeposito = new frmDeposito();

            // Escondemos el menú mientras el cliente está en la ventana de depósito
            this.Hide();

            // ShowDialog() pausa el código aquí hasta que la ventana de depósito se cierre
            ventanaDeposito.ShowDialog();

            // Cuando se cierra, mostramos el menú otra vez
            this.Show();
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
