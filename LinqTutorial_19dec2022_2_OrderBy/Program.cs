namespace LinqTutorial_19dec2022_2_OrderBy;

internal class Program
{
    static void Main(string[] args)
    {
        var pets = new[]
    {
        new Pet(1, "Hannibal", PetType.Fish, 1.1f),
        new Pet(2, "Anthony", PetType.Cat, 2f),
        new Pet(3, "Ed", PetType.Cat, 0.7f),
        new Pet(4, "Taiga", PetType.Dog, 35f),
        new Pet(5, "Rex", PetType.Dog, 40f),
        new Pet(6, "Lucky", PetType.Dog, 5f),
        new Pet(7, "Storm", PetType.Cat, 0.9f),
        new Pet(8, "Nyan", PetType.Cat, 2.2f)
    };
        var numbers = new[] { 16, 8, 9, -1, 2 };
        var orderedNumbers = numbers.OrderBy(number => number);

        //Console.WriteLine("\nOrdered Numbers:");
        //foreach (var number in orderedNumbers)
        //{
        //    Console.WriteLine($"{number}");
        //}

        var words = new[] { "lion", "tiger", "snow leopard" };
        var orderedWords = words.OrderBy(word => word);
        
        //Console.WriteLine("\nOrdered Words:");
        //foreach (var word in orderedWords)
        //{
        //    Console.WriteLine($"{word}");
        //}

        var petsOrderByName = pets.OrderBy(pet => pet.Name);

        //Console.WriteLine("\nOrdered Pets:");
        //foreach (var pet in petsOrderByName)
        //{
        //    Console.WriteLine(pet.Name);
        //}

        //Console.WriteLine("\nPets:");
        //foreach (var pet in pets)
        //{
        //    Console.WriteLine(pet.Name);
        //}

        var petsOrderByIdDesc = pets.OrderByDescending(pet => pet.Id);

        //Console.WriteLine("\nOrdered Pets:");
        //foreach (var pet in petsOrderByIdDesc)
        //{
        //    Console.WriteLine($"{pet.Id}, {pet.Name}");
        //}

        var petsOrderedByTypeThenName = pets.OrderBy(pet => pet.Type).ThenBy(pet => pet.Name);

        //Console.WriteLine("\nOrdered Pets Twice:");
        //foreach (var pet in petsOrderedByTypeThenName)
        //{
        //    Console.WriteLine($"{pet}");
        //}

        var petsOrderedByTypeWithComparer = pets.OrderBy(pet => pet, new PetByTypeComparer());

        //Console.WriteLine($"\n{nameof(petsOrderedByTypeWithComparer)}:");
        //foreach (var pet in petsOrderedByTypeWithComparer)
        //{
        //    Console.WriteLine($"{pet.Name}");
        //}

        var petsReversed = pets.Reverse();
        Console.WriteLine($"\n{nameof(petsReversed)}:");
        foreach (var pet in petsReversed)
        {
            Console.WriteLine($"{pet.Id}, {pet.Name}");
        }
    }
}