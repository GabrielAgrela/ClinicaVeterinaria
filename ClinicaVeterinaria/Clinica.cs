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
            Nome = nome;
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
                    clienteTemp.registarAnimal(clienteTemp);
                    break;
                default:
                    break;
            }
            addCliente(clienteTemp);
            
        }

        //devolve, em hierarquia com tabs, nome do cliente>animais>servicos+profissional
        public string produzirRelatorio(String nomeCliente)
        {
            string relatorio = "";
            int frequencia = 0;
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
                            frequencia++;
                        }
                    }
                }
            }
            return relatorio+"\n"+" Frequencia: "+frequencia+"\n";
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
