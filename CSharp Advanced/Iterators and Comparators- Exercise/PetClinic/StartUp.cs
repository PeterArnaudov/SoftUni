namespace PetClinic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Create" && command[1] == "Pet")
                {
                    pets.Add(new Pet(command[2], int.Parse(command[3]), command[4]));
                }
                else if (command[0] == "Create" && command[1] == "Clinic")
                {
                    try
                    {
                        clinics.Add(new Clinic(command[2], int.Parse(command[3])));
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (command[0] == "Add")
                {
                    Pet pet = pets.Find(p => p.Name == command[1]);
                    Clinic clinic = clinics.Find(c => c.Name == command[2]);

                    Console.WriteLine(clinic.AddPet(pet));
                }
                else if (command[0] == "Release")
                {
                    Clinic clinic = clinics.Find(c => c.Name == command[1]);

                    Console.WriteLine(clinic.ReleasePet());
                }
                else if (command[0] == "HasEmptyRooms")
                {
                    Clinic clinic = clinics.Find(c => c.Name == command[1]);

                    Console.WriteLine(clinic.HasEmptyRooms());
                }
                else if (command[0] == "Print" && command.Length == 2)
                {
                    Clinic clinic = clinics.Find(c => c.Name == command[1]);

                    clinic.Print();
                }
                else if (command[0] == "Print" && command.Length == 3)
                {
                    Clinic clinic = clinics.Find(c => c.Name == command[1]);

                    clinic.Print(int.Parse(command[2]));
                }
            }
        }
    }
}
