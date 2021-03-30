using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }

        public List<Animal> m_animals = new List<Animal>();
        public List<Animal> animals
        {
            get { return m_animals; }
        }

        public Cliente(string nome, string contato, string endereco)
        {
            this.Nome = nome;
            this.Contato = contato;
            this.Endereco = endereco;
        }

        public void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
