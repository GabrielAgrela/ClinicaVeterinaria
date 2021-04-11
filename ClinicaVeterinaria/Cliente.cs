using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }

        private List<Animal> m_animals = new List<Animal>();
        public List<Animal> animals
        {
            get { return m_animals; }
        }

        public Cliente(string nome, string contato, string endereco)
        {
            Nome = nome;
            Contato = contato;
            Endereco = endereco;
        }

        public void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        //recebe inputs para parametros do Animal e indicaServico() dependendo do input do user
        public void registarAnimal(Cliente cliente)
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

            Animal animalTemp = new Animal(nome, idade, genero, especie, id);

            Console.WriteLine("Adicionar servico a este animal? (s/n)");

            string yorno = Console.ReadLine();
            switch (yorno)
            {
                case "s":
                    animalTemp.indicarServico(animalTemp);
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
    }
}
