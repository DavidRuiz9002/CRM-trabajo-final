using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Services;

namespace CRMTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void ValidarNombreVacio()
        {
            bool resultado =
                ClienteService.ValidarNombre("");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidarCorreoIncorrecto()
        {
            bool resultado =
                ClienteService.ValidarCorreo(
                    "cliente.com");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidarTelefonoInvalido()
        {
            bool resultado =
                ClienteService.ValidarTelefono(
                    "12345");

            Assert.IsFalse(resultado);
        }
    }
}