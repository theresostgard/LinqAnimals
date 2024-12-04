namespace DBDay04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalsInHospital = new List<Animal>()
            {
                new Animal { Name = "Lucas", IsVaccinated = true, Age = 5, AmountOfLegs = 4, Species = "Dog" },
                new Animal { Name = "Björne", IsVaccinated = true, Age = 3, AmountOfLegs = 4, Species = "Dog" },
                new Animal { Name = "Mira", IsVaccinated = false, Age = 4, AmountOfLegs = 4, Species = "Dog" },
                new Animal { Name = "Zacco", IsVaccinated = true, Age = 7, AmountOfLegs = 4, Species = "Dog" },
                new Animal { Name = "Pelle", IsVaccinated = true, Age = 2, AmountOfLegs = 4, Species = "Cat" },
                new Animal { Name = "Lisa", IsVaccinated = true, Age = 4, AmountOfLegs = 4, Species = "Cat" },
                new Animal { Name = "Tuva", IsVaccinated = false, Age = 13, AmountOfLegs = 4, Species = "Cat" },
                new Animal { Name = "Sven", IsVaccinated = false, Age = 1, AmountOfLegs = 2, Species = "Parrot" },
                new Animal { Name = "Beast", IsVaccinated = false, Age = 2, AmountOfLegs = 8, Species = "Spider" },
                new Animal { Name = "Hoppe", IsVaccinated = true, Age = 3, AmountOfLegs = 4, Species = "Rabbit" },
                new Animal { Name = "Shadow", IsVaccinated = false, Age = 5, AmountOfLegs = 0, Species = "Snake" }
            };

            var amountOfDogs = animalsInHospital.Where(d => d.Species == "Dog").Count();

            var oldestAnimalinHospital = animalsInHospital.Max(d => d.Age);

            var vaccinatedAnimals = animalsInHospital.Where(a => a.IsVaccinated == true).ToList();

            var fourLeggedAnimalsOver3 = animalsInHospital.Where(f => f.AmountOfLegs == 4 && f.Age > 3).ToList();

            var isThereAhadowAnimal = animalsInHospital.Where(n => n.Name == "Shadow");
        }
    }
}
