using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void addServicoTest()
        {
            Profissional drGervasio = new Profissional("gervasio", "10as16");
            Servico servico1 = new Servico("tratamento x", 2, "antibioticos", 10, drGervasio);
            Animal boby = new Animal("boby",10,"f","canino","0");
            boby.addServico(servico1);
            Assert.AreEqual(servico1, boby.servicos[0], "wrong datas");
        }
    }
}