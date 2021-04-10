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

            Cliente jorge = new Cliente("jorge", "92", "rua do carmo");
            Cliente luis = new Cliente("luis", "9009", "rua do cosco");
            Cliente gertrudes = new Cliente("gertrudes", "39596", "rua do bife");

            Profissional drArroz = new Profissional("dr Arroz", "10-19");
            Profissional drAntonieta = new Profissional("dr Antonia", "8-19");

            Animal teiomoso = new Animal("teiomoso", 17, "M", "marsupial", "2");
            Animal scooby = new Animal("scooby", 17, "M", "marsupial", "2");
            Animal geremias = new Animal("geremias", 17, "M", "marsupial", "2");
            Animal bolas = new Animal("bolas", 17, "M", "marsupial", "2");
            Animal toby = new Animal("toby", 17, "M", "marsupial", "2");
            Animal kobe = new Animal("kobe", 17, "M", "marsupial", "2");
            Animal MarcusAurelius = new Animal("MarcusAurelius", 17, "M", "marsupial", "2");

            clinica.addCliente(jorge);
            clinica.addCliente(luis);
            clinica.addCliente(gertrudes);

            clinica.addProfissional(drArroz);
            clinica.addProfissional(drAntonieta);

            Servico servico1 = new Servico("nome1",21,"meds1",121,drArroz);
            Servico servico2 = new Servico("nome2", 22, "meds2", 122, drArroz);
            Servico servico3 = new Servico("nome3", 23, "meds3", 123, drAntonieta);
            Servico servico4 = new Servico("nome4", 24, "meds4", 124, drAntonieta);
            Servico servico5 = new Servico("nome5", 25, "meds5", 125, drAntonieta);
            Servico servico6 = new Servico("nome6", 26, "meds6", 126, drArroz);
            Servico servico7 = new Servico("nome7", 27, "meds7", 127, drArroz);
            Servico servico8 = new Servico("nome8", 28, "meds8", 128, drArroz);
            Servico servico9 = new Servico("nome9", 29, "meds9", 129, drAntonieta);
            Servico servico10 = new Servico("nome10", 210, "meds10", 1210, drArroz);
            Servico servico11 = new Servico("nome11", 211, "meds11", 1211, drAntonieta);
            Servico servico12 = new Servico("nome12", 212, "meds12", 1212, drArroz);


            teiomoso.addServico(servico1);
            scooby.addServico(servico2);
            scooby.addServico(servico3);
            scooby.addServico(servico4);
            geremias.addServico(servico5);
            bolas.addServico(servico6);
            toby.addServico(servico7);
            toby.addServico(servico8);
            kobe.addServico(servico9);
            kobe.addServico(servico10);
            kobe.addServico(servico11);
            MarcusAurelius.addServico(servico12);

            jorge.addAnimal(teiomoso);
            jorge.addAnimal(scooby);
            jorge.addAnimal(geremias);
            luis.addAnimal(bolas);
            luis.addAnimal(toby);
            gertrudes.addAnimal(kobe);
            gertrudes.addAnimal(MarcusAurelius);

            Assert.AreEqual("jorge", clinica.produzirRelatorio(jorge.Nome), "wrong user");
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
    }
}