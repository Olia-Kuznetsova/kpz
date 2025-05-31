using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        void Feed(Food food);
    }

    public interface IEmployee
    {
        string FullName { get; }
        string Role { get; }
    }

    public interface IEnclosure
    {
        string Name { get; }
        List<IAnimal> Animals { get; }
        void AddAnimal(IAnimal animal);
    }

    public class Animal : IAnimal
    {
        public string Name { get; }
        public string Species { get; }

        public Animal(string name, string species)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species))
                throw new ArgumentException("Name and species must be provided.");

            Name = name;
            Species = species;
        }

        public void Feed(Food food)
        {
            Console.WriteLine($"{Name} the {Species} is eating {food.Name}.");
        }
    }

    public class Employee : IEmployee
    {
        public string FullName { get; }
        public string Role { get; }

        public Employee(string fullName, string role)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Full name and role are required.");

            FullName = fullName;
            Role = role;
        }
    }

    public class Enclosure : IEnclosure
    {
        public string Name { get; }
        public List<IAnimal> Animals { get; }

        public Enclosure(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Enclosure name cannot be empty.");

            Name = name;
            Animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal));

            Animals.Add(animal);
        }
    }

    public class Food
    {
        public string Name { get; }

        public Food(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }

    public class Inventory
    {
        private readonly List<IEnclosure> _enclosures;
        private readonly List<IEmployee> _employees;

        public Inventory(List<IEnclosure> enclosures, List<IEmployee> employees)
        {
            _enclosures = enclosures ?? new List<IEnclosure>();
            _employees = employees ?? new List<IEmployee>();
        }

        public void PrintAnimalInfo()
        {
            Console.WriteLine("== Zoo Animals ==");
            foreach (var enclosure in _enclosures)
            {
                Console.WriteLine($"Enclosure: {enclosure.Name}");
                foreach (var animal in enclosure.Animals)
                {
                    Console.WriteLine($" - {animal.Name} ({animal.Species})");
                }
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine("\n== Zoo Employees ==");
            foreach (var employee in _employees)
            {
                Console.WriteLine($" - {employee.FullName}, {employee.Role}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            IAnimal lion = new Animal("Leo", "Lion");
            IAnimal giraffe = new Animal("Gina", "Giraffe");

            IEnclosure savannah = new Enclosure("Savannah");
            savannah.AddAnimal(lion);
            savannah.AddAnimal(giraffe);

            IEmployee keeper = new Employee("Olia Kuznietsova", "Animal Keeper");

            lion.Feed(new Food("Meat"));
            giraffe.Feed(new Food("Leaves"));

            var inventory = new Inventory(
                new List<IEnclosure> { savannah },
                new List<IEmployee> { keeper }
            );

            inventory.PrintAnimalInfo();
            inventory.PrintEmployeeInfo();
        }
    }
}