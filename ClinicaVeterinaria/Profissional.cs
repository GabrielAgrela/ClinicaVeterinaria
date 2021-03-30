using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Profissional 
    {
        public string Nome { get; set; }
        public string Disponibilidade { get; set; }

        public static List<Servico> m_servicos = new List<Servico>();
        public List<Servico> servicos
        {
            get { return m_servicos; }
        }

        public Profissional(string nome, string disponibilidade)
        {
            this.Nome = nome;
            this.Disponibilidade = disponibilidade;
        }

        public void addServico(Servico servico)
        {
            servicos.Add(servico);
        }

        public Servico searchServico(Servico servico)
        {
            foreach (Servico s in servicos)
            {
                if(servico.Nome == s.Nome)
                    return s;
            }
            return servico;
        }
    }
}
