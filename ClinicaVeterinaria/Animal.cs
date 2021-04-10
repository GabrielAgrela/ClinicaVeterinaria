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
            this.Nome = nome;
            this.Idade = idade;
            this.Genero = genero;
            this.Especie = especie;
            this.Id = id;
        }
        public void addServico(Servico servico)
        {
            servicos.Add(servico);
        }
    }

}
