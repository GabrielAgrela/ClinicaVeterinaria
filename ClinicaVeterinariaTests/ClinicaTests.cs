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
        public void relatorioTest()
        {
            Clinica clinica = new Clinica("Clinica do geremias");

            Cliente jorge = new Cliente( "jorge","123","rua do carmo");
            Cliente luis = new Cliente("luis", "234", "rua do cosco");
            Cliente gertrudes = new Cliente("gertrudes", "345", "rua do bife");

            Profissional drArroz = new Profissional("dr Arroz", "10-19");
            Profissional drAntonieta = new Profissional("dr Antonia", "8-19");

            Animal teiomoso = new Animal("teiomoso", "17","M","marsupial","2");
            Animal scooby = new Animal("scooby", "17", "M", "marsupial", "2");
            Animal geremias = new Animal("geremias", "17", "M", "marsupial", "2");
            Animal bolas = new Animal("bolas", "17", "M", "marsupial", "2");
            Animal toby = new Animal("toby", "17", "M", "marsupial", "2");
            Animal kobe = new Animal("kobe", "17", "M", "marsupial", "2");
            Animal MarcusAurelius = new Animal("MarcusAurelius", "17", "M", "marsupial", "2");

            clinica.addCliente(jorge);
            clinica.addCliente(luis);
            clinica.addCliente(gertrudes);

            clinica.addProfissional(drArroz);
            clinica.addProfissional(drAntonieta);

            Servico servico1 = new Servico("10€","2 dias","mebocaina","dores de garganta1", drArroz);
            Servico servico2 = new Servico("20€", "3 dias", "leite", "dores de garganta2", drArroz);
            Servico servico3 = new Servico("230€", "30 dias", "anti-inflamatorios", "dores de garganta3", drAntonieta);
            Servico servico4 = new Servico("140€", "10 dias", "mebocaina", "dores de garganta4", drAntonieta);
            Servico servico5 = new Servico("120€", "23 dias", "mebocain3a", "dores de garganta5", drAntonieta);
            Servico servico6 = new Servico("150€", "33 dias", "mebocaina", "dores de garganta5", drArroz);
            Servico servico7 = new Servico("110€", "43 dias", "mebocaina2", "dores de garganta6", drArroz);
            Servico servico8 = new Servico("10€", "23 dias", "mebocaina", "dores de garganta4", drArroz);
            Servico servico9 = new Servico("410€", "13 dias", "meboc5aina", "dores de garganta7", drAntonieta);
            Servico servico10 = new Servico("510€", "3 dias", "mebocaina", "dores de garganta8", drArroz);
            Servico servico11 = new Servico("101€", "32 dias", "mebocareina", "dores de garganta9", drAntonieta);
            Servico servico12 = new Servico("103€", "31 dias", "mebocaina", "dores de garganta4", drArroz);

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

            Assert.AreEqual("jorge", clinica.produzirRelatorio(jorge), "wrong user");
        }
    }
}