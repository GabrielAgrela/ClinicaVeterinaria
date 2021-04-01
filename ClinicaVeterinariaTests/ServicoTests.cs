using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Tests
{
    [TestClass()]
    public class ServicoTests
    {
        [TestMethod()]
        public void fullDataTest()
        {
            Profissional drGervasio = new Profissional("Gervasio", "10as20");
            Servico servico1 = new Servico("tratamento x", "2 dias", "antibioticos", "10€", drGervasio);
            Assert.AreEqual("tratamento x" + " " + "2 dias" + " " + "antibioticos" + " " + "10€" + " " + drGervasio.Nome, servico1.fullData(), "wrong data");
        }
    }
}