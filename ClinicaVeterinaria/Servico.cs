using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Servico
    {
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Medicamentos{ get; set; }
        public int Preco { get; set; }
        public Profissional m_profissional{ get; set; }

        //constructor de um servico para uma instancia de Animal
        public Servico(string nome, int duracao, string medicamentos, int preco, Profissional profissional)
        {
            Nome = nome;
            Duracao = duracao;
            Medicamentos = medicamentos;
            Preco = preco;
            m_profissional = profissional;
        }

        //constructor de um servico para uma instancia de Profissional
        public Servico(string nome, int duracao, string medicamentos, int preco)
        {
            Nome = nome;
            Duracao = duracao;
            Medicamentos = medicamentos;
            Preco = preco;
        }

        public string fullData()
        {
            return "| Nome do servico: "+ Nome+ " | Duração em minutos: " + Duracao + " | Medicamentos: " + Medicamentos + " | Preco em euros: " + Preco + " | Profissional: " + m_profissional.Nome + " | Disponibilidade: " + m_profissional.Disponibilidade;
        }
    }
}
