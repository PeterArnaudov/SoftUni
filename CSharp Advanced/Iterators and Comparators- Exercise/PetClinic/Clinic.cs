namespace PetClinic
{
    using System;
    using System.Linq;

    public class Clinic
    {
        private string name;
        private Pet[] rooms;

        public Clinic(string name, int rooms)
        {
            if (rooms % 2 == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            this.Name = name;
            this.rooms = new Pet[rooms];
        }

        public string Name
        {
            get => this.name;

            private set => this.name = value;
        }

        public bool AddPet(Pet pet)
        {
            int centralNumber = this.rooms.Length == 1 ? 0 : this.rooms.Length / 2;
            
            for (int i = 0; i <= centralNumber; i++)
            {
                if (this.rooms[centralNumber - i] == null)
                {
                    this.rooms[centralNumber - i] = pet;
                    return true;
                }

                if (this.rooms[centralNumber + i] == null)
                {
                    this.rooms[centralNumber + i] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool ReleasePet()
        {
            int centralNumber = this.rooms.Length == 1 ? 0 : this.rooms.Length / 2;

            for (int i = centralNumber; i < this.rooms.Length; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < centralNumber; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.rooms.Any(r => r == null);
        }

        public void Print()
        {
            foreach (var room in rooms)
            {
                if (room != null)
                {
                    Console.WriteLine(room);
                }
                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }

        public void Print(int roomNumber)
        {
            if (this.rooms[roomNumber - 1] != null)
            {
                Console.WriteLine(this.rooms[roomNumber - 1]);
            }
            else
            {
                Console.WriteLine("Room empty");
            }
        }
    }
}
