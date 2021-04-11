using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinica clinica = new Clinica("st maria");
            clinica.printMenu();
        }
    }
}
