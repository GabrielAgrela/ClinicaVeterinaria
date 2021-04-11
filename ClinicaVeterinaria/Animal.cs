using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public string Id { get; set; }

        private List<Servico> m_servicos = new List<Servico>();
        public List<Servico> servicos
        {
            get { return m_servicos; }
        }

        public Animal(string nome, int idade, string genero, string especie, string id)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Especie = especie;
            Id = id;
        }
        public void addServico(Servico servico)
        {
            servicos.Add(servico);
        }

        //recebe inputs para parametros do Servico e indicaServico(), para o mesmo animal, dependendo do input do user
        public void indicarServico(Animal animal)
        {
            Console.WriteLine("Nome do servico: ");
            string nome = Console.ReadLine();

            Console.WriteLine("duracao do servico (em minutos): ");
            int duracao = 0;
            try
            {
                duracao = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("input invalido");
                indicarServico(animal);
                return;
            }

            Console.WriteLine("medicamentos do servico: ");
            string medicamentos = Console.ReadLine();

            Console.WriteLine("preco do servico (em euros): ");
            int preco = 0;
            try
            {
                preco = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("input invalido");
                indicarServico(animal);
            }

            Console.WriteLine("Nome do profissional do servico: ");
            string nomeProfissional = Console.ReadLine();

            Console.WriteLine("horario do profissional do servico (hh:mm-hh:mm): ");
            string disponibilidade = Console.ReadLine();

            //Ao criar uma instancia servico, atribuimos uma instancia da disponibilidade de um profissional ao mesmo
            Profissional dr = new Profissional(nomeProfissional, disponibilidade);
            Servico servicoTemp = new Servico(nome, duracao, medicamentos, preco, dr);
            animal.addServico(servicoTemp);

            //No enunciado não está especificado a criação de um profissional, no entando o creio que o correto seria a criação de uma instancia de um profissional 
            //e também atribuir a instancia do servico ao mesmo, sendo que um profissional tem varios servicos, mas um animal também pode ter os mesmos vários servicos
            //De qualquer modo, implementei esse design no Servico() para facilidade de uma futura implementação da funcionalidade

            Console.WriteLine("Adicionar mais um servico a este animal?(s/n)");

            string yorno = Console.ReadLine();
            switch (yorno)
            {
                case "s":
                    indicarServico(animal);
                    break;
                default:
                    break;
            }
        }
    }

}
