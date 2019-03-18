namespace DatabaseExtended
{
    using System;

    public class Person
    {
        private long id;
        private string username;

        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id
        {
            get => this.id;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID cannot be negative or 0.");
                }

                this.id = value;
            }
        }

        public string Username
        {
            get => this.username;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username cannot be null or empty.");
                }

                this.username = value;
            }
        }
    }
}
