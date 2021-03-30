using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public class Clinica
    {
        public string Nome { get; set; }
        public List<Profissional> Profissionais { get; set; }

        public List<Profissional> m_profissionais = new List<Profissional>();
        public List<Profissional> profissionais
        {
            get { return m_profissionais; }
        }

        public List<Cliente> m_clientes = new List<Cliente>();
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

        public string returnClientes()
        {
            foreach (Cliente c in clientes)
            {
                return c.Nome;
            }
            return "not found any";
        }

        public Profissional searchProfissional(Profissional profissional)
        {
            foreach (Profissional p in profissionais)
            {
                return p;
            }
            return profissional;
        }

        public string produzirRelatorio(Cliente cliente)
        {
            string relatorio = "";
            foreach (Cliente c in clientes)
            {
                if(c.Nome == cliente.Nome)
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
            return relatorio;
        }




        /* public Profissional searchProfissional(Profissional profissional)
         {
             foreach (Profissional p in profissionais)
             {
                 if (profissional.nome == p.nome)
                 {
                     return p;
                 }
             }
             return profissional;
         }*/

    }
}
