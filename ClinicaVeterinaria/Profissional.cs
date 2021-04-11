using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Profissional 
    {
        public string Nome { get; set; }
        public string Disponibilidade { get; set; }

        private List<Servico> m_servicos = new List<Servico>();
        public List<Servico> servicos
        {
            get { return m_servicos; }
        }

        public Profissional(string nome, string disponibilidade)
        {
            Nome = nome;
            Disponibilidade = disponibilidade;
        }

        public void addServico(Servico servico)
        {
            servicos.Add(servico);
        }
    }
}
