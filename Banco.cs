using System.Collections.Generic;

namespace CajeroAutomatico2
{
    // Los posibles resultados de intentar iniciar sesión
    public enum ResultadoLogin
    {
        Correcto,        // cuenta y PIN bien
        CuentaNoExiste,  // el número de cuenta no está registrado
        Bloqueada,       // la cuenta ya estaba bloqueada
        PinIncorrecto,   // PIN malo, todavía quedan intentos
        BloqueadaAhora   // PIN malo y llegó a 3 intentos: se bloquea
    }

    // "static" significa que no hay que crear un Banco: se usa directo (Banco.Autenticar)
    public static class Banco
    {
        // Aquí guardamos la cuenta que inició sesión, para usarla en las otras ventanas
        public static Cuenta CuentaActual;

        // Las cuentas de prueba, guardadas en memoria.
        // El número de cuenta es la "llave" para encontrarlas rápido.
        public static Dictionary<string, Cuenta> Cuentas = new Dictionary<string, Cuenta>
        {
            ["10000000001"] = new Cuenta { NumeroCuenta = "10000000001", Titular = "Ana Pérez",    Pin = "1234", Saldo = 1500000 },
            ["10000000002"] = new Cuenta { NumeroCuenta = "10000000002", Titular = "Carlos Gómez", Pin = "4321", Saldo = 800000 },
            ["10000000003"] = new Cuenta { NumeroCuenta = "10000000003", Titular = "María Ruiz",   Pin = "1111", Saldo = 300000 }
        };

        // Revisa la cuenta y el PIN, y devuelve qué pasó
        public static ResultadoLogin Autenticar(string numero, string pin)
        {
            // 1. ¿Existe la cuenta?
            if (!Cuentas.ContainsKey(numero))
                return ResultadoLogin.CuentaNoExiste;

            Cuenta c = Cuentas[numero];

            // 2. ¿Está bloqueada?
            if (c.Bloqueada)
                return ResultadoLogin.Bloqueada;

            // 3. ¿El PIN es incorrecto?
            if (c.Pin != pin)
            {
                c.IntentosFallidos++;          // sumamos un intento fallido

                if (c.IntentosFallidos >= 3)   // al tercero, se bloquea
                {
                    c.Bloqueada = true;
                    return ResultadoLogin.BloqueadaAhora;
                }
                return ResultadoLogin.PinIncorrecto;
            }

            // 4. Todo bien: reiniciamos los intentos y guardamos la cuenta actual
            c.IntentosFallidos = 0;
            CuentaActual = c;
            return ResultadoLogin.Correcto;
        }
    }
}
