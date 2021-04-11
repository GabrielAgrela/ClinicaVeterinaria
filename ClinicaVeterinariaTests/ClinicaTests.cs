using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria.Tests
{
    [TestClass()]
    public class ClinicaTests
    {
        [TestMethod()]
        public void produzirRelatorioTest()
        {
            Clinica clinica = new Clinica("Clinica do geremias");
            Cliente jorge = new Cliente("jorge", "926564656", "rua do carmo");
            Profissional drArroz = new Profissional("dr Arroz", "10-19");
            Animal teiomoso = new Animal("teimoso", 17, "M", "marsupial", "2");

            clinica.addCliente(jorge);
            clinica.addProfissional(drArroz);

            Servico servico = new Servico("operacao",21,"meds1",121,drArroz);

            teiomoso.addServico(servico);
            jorge.addAnimal(teiomoso);

            Assert.AreEqual("\nCliente: jorge \n   Animal: teimoso \n       Servico: | Nome do servico: nome1 | Duração em minutos: 21 | Medicamentos: meds1 | Preco em euros: 121 | Profissional: dr Arroz | Disponibilidade: 10-19 \n Frequencia: 1\n", clinica.produzirRelatorio(jorge.Nome), "wrong user");
        }

        [TestMethod()]
        public void addProfissionalTest()
        {
            Clinica clinica = new Clinica("st maria");
            Profissional drGervasio = new Profissional("gervasio", "10as16");

            clinica.addProfissional(drGervasio);

            Assert.AreEqual(drGervasio, clinica.profissionais[0], "wrong datas");
        }

        [TestMethod()]
        public void addClienteTest()
        {
            Clinica clinica = new Clinica("st maria");
            Cliente jorge = new Cliente("Jorge", "8945466786", "rua do caneco");
            clinica.addCliente(jorge);
            Assert.AreEqual(jorge, clinica.clientes[0], "wrong datas");
        }

        //registarCliente() não tem testMethod() pois é a aplicação do teste produzirRelatorioTest(), mas com inputs do user.
    }
}