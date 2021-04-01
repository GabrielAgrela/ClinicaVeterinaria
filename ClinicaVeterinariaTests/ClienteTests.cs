using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void addAnimalTest()
        {
            Cliente jorge = new Cliente("Jorge", "8945466786", "rua do caneco");
            Animal boby = new Animal("boby", "10", "f", "canino", "0");
            jorge.addAnimal(boby);
            Assert.AreEqual(boby, jorge.animals[0], "wrong data");
        }
    }
}