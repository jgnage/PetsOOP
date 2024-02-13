using ClassLibrary1;

string input = "";

List<Pet> pets = new List<Pet>();

while (input != "4")
{
    Console.WriteLine("Welcome to the Pet Store");
    Console.WriteLine("1. Add a new pet");
    Console.WriteLine("2. List all pets");
    Console.WriteLine("3. Have 2 pets meet");
    Console.WriteLine("4. Exit");
    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("What is the name of the new pet?");
            string petName = Console.ReadLine();
            Console.WriteLine("1. Add a new Cat");
            Console.WriteLine("2. Add a new Chimpanzee");
            Console.WriteLine("3. Add a new Turtle");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    pets.Add(new Cat(petName)); 
                    break;
                case "2":
                    pets.Add(new Chimpanzee(petName)); 
                    break;
                case "3":
                    pets.Add(new Turtle(petName)); 
                    break;
            }
            break;
        case "2":
            Console.WriteLine("All of your pets:");
            if (pets.Count == 0)
            {
                Console.WriteLine("No pets available.");
            }
            else
            {
                foreach (Pet pet in pets)
                {
                    Console.WriteLine($"Name: {pet.Name}, Type: {pet.GetType().Name}");
                }
            }
            break;
        case "3":
            if (pets.Count < 2)
            {
                Console.WriteLine("You need two pets for them to meet.");
            }
            else
            {
                Console.WriteLine("Select the first pet:");
                for (int i = 0; i < pets.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {pets[i].Name}");
                }
                Console.Write("Enter the number of the first pet: ");
                int petIndex1 = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Select the second pet:");
                for (int i = 0; i < pets.Count; i++)
                {
                    if (i != petIndex1)
                    {
                        Console.WriteLine($"{i + 1}. {pets[i].Name}");
                    }
                }
                Console.Write("Enter the number of the second pet: ");
                int petIndex2 = int.Parse(Console.ReadLine()) - 1;

                Pet pet1 = pets[petIndex1];
                Pet pet2 = pets[petIndex2];

                if ((pet1 is Cat && pet2 is Chimpanzee) || (pet1 is Chimpanzee && pet2 is Cat))
                {
                    Console.WriteLine("A cat and a chimpanzee met! They are friends!");

                }
                else if ((pet1 is Turtle && pet2 is Cat) || (pet1 is Cat && pet2 is Turtle))
                {
                    Console.WriteLine("A turtle and cat have met. It's a fight!");
                }
                else
                {
                    Console.WriteLine($"The pets {pet1.Name} and {pet2.Name} have met!");
                }
            }
            break;
        case "4":
            break;
        default:
            break; 
    }

}

