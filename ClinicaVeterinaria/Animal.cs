using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public string Id { get; set; }

        public List<Servico> m_servicos = new List<Servico>();
        public List<Servico> servicos
        {
            get { return m_servicos; }
        }

       

        public Animal(string nome, string idade, string genero, string especie, string id)
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
