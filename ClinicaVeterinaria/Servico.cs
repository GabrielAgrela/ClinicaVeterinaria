using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Servico
    {
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Medicamentos{ get; set; }
        public string Preco { get; set; }
        public Profissional m_profissional{ get; set; }

        public Servico(string nome, string duracao, string medicamentos, string preco, Profissional profissional)
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.Medicamentos = medicamentos;
            this.Preco = preco;
            this.m_profissional = profissional;
        }

        public string fullData()
        {
            return Nome+" "+Duracao + " " +Medicamentos + " " +Preco + " " +m_profissional.Nome;
        }
    }
}
