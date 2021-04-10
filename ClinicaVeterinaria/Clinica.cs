using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Clinica 
    {
        public string Nome { get; set; }
        public List<Profissional> Profissionais { get; set; }

        private List<Profissional> m_profissionais = new List<Profissional>();
        public List<Profissional> profissionais
        {
            get { return m_profissionais; }
        }

        private List<Cliente> m_clientes = new List<Cliente>();
        public List<Cliente> clientes
        {
            get { return m_clientes; }
        }

        public Clinica(string nome)
        {
            this.Nome = nome;
        }

        public void addProfissional(Profissional profissional)
        {
            profissionais.Add(profissional);
        }

        public void addCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        //recebe inputs para os parametros do Cliente e registaAnimal() dependendo do input user
        private void registarCliente()
        {
            Console.WriteLine("Nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("numero do cliente: ");
            string numero = Console.ReadLine();

            Console.WriteLine("endereco do cliente: ");
            string endereco = Console.ReadLine();

            Cliente clienteTemp = new Cliente(nome, numero, endereco);
            
            Console.WriteLine("Adicionar animal a este cliente? (s/n)");


            string yorno = Console.ReadLine();
            switch (yorno)
            {
                case "s":
                    registarAnimal(clienteTemp);
                    break;
                default:
                    break;
            }
            addCliente(clienteTemp);
            
        }

        //recebe inputs para parametros do Animal e indicaServico() dependendo do input do user
        private void registarAnimal(Cliente cliente)
        {
            Console.WriteLine("Nome do animal: ");
            string nome = Console.ReadLine();

            Console.WriteLine("idade do animal: ");
            int idade = 0;
            try
            {
                idade = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("input invalido");
                registarAnimal(cliente);
                return;
            }

            Console.WriteLine("genero do animal: ");
            string genero = Console.ReadLine();

            Console.WriteLine("especie do animal: ");
            string especie = Console.ReadLine();

            Console.WriteLine("id do animal: ");
            string id = Console.ReadLine();

            Animal animalTemp = new Animal(nome, idade, genero,especie,id);
            
            Console.WriteLine("Adicionar servico a este animal? (s/n)");

            string yorno = Console.ReadLine();
            switch (yorno)
            {
                case "s":
                    indicarServico(animalTemp);
                    cliente.addAnimal(animalTemp);

                    //Método não muito elegante de, ao retornar indicarServico(), adicionar mais um animal ao mesmo cliente, dependendo do input do user
                    Console.WriteLine("Adicionar mais um animal a este cliente? (s/n)");

                    yorno = Console.ReadLine();
                    switch (yorno)
                    {
                        case "s":
                            registarAnimal(cliente);
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    cliente.addAnimal(animalTemp);
                    break;
            }
        }

        //recebe inputs para parametros do Servico e indicaServico(), para o mesmo animal, dependendo do input do user
        private void indicarServico(Animal animal)
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
                registarCliente();
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

        //devolve, em hierarquia com tabs, nome do cliente>animais>servicos+profissional
        public string produzirRelatorio(String nomeCliente)
        {
            string relatorio = "";
            foreach (Cliente c in clientes)
            {
                if(c.Nome == nomeCliente)
                {
                    relatorio = relatorio + "\nCliente: " + c.Nome + " ";
                    foreach (Animal a in c.animals)
                    {
                        relatorio = relatorio + "\n   Animal: " + a.Nome + " ";
                        foreach (Servico s in a.servicos)
                        {
                            relatorio = relatorio + "\n       Servico: " + s.fullData() + " ";
                        }
                    }
                }
            }
            return relatorio+"\n";
        }

        public void printMenu()
        {
            Console.WriteLine("1 - Registar cliente\n2 - Produzir relatório de cliente");
            chooseMenuOption();
        }

        private void chooseMenuOption()
        {
            int optionNumber = Int32.Parse(Console.ReadLine());
            switch (optionNumber)
            {
                case 1:
                    registarCliente();
                    break;
                case 2:
                    Console.WriteLine("Nome do cliente:");
                    Console.WriteLine(produzirRelatorio(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            printMenu();
        }

    }
}
