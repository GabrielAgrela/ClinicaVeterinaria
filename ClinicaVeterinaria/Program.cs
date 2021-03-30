using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria
{
    public interface IFileSystem
    {
        string[] ReadAllLines(string path);
    }

    public class Menu
    {
        public void printMenu()
        {
            Console.WriteLine("Opção 1\nOpção2\n");
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Animal animal = new Animal();
            animal.registarAnimal(animal);
            animal.printAnimal();*/

        }
    }
}
