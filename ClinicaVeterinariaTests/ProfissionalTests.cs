using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClinicaVeterinaria.Tests
{
    [TestClass()]
    public class ProfissionalTests
    {
        [TestMethod()]
        public void addServicoTest()
        {
            Profissional drGervasio = new Profissional("gervasio", "10-16");
            Servico servico = new Servico("tratamento x", 2, "antibioticos", 10, drGervasio);
            drGervasio.addServico(servico);
            Assert.AreEqual(servico, drGervasio.servicos[0], "unexpected servico");
        }
    }
}