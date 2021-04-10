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
            Profissional drGervasio = new Profissional("gervasio", "10as16");
            Servico servico1 = new Servico("tratamento x", 2, "antibioticos", 10, drGervasio);
            drGervasio.addServico(servico1);
            Assert.AreEqual(servico1, drGervasio.servicos[0], "wrong datas");
        }
    }
}