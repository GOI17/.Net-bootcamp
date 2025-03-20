namespace HelloWorld
{

    public class Person(string firstName, string lastName, int age)
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;

        public bool IsValidFirstName()
        {
            return FirstName.Length > 0;
        }

        public bool IsValidLastName()
        {
            return LastName.Length > 0;
        }

        public bool IsValidAge()
        {
            return Age > 0;
        }
        public override string ToString()
        {
            return $"My name is {FirstName} {LastName} and I am {Age} years old.";
        }
    }

    internal interface ICRUD<T>
    {
        public T GetById<K>(K id);
        public List<T> GetAll();
        public T Create(T person);
        public T Update(T person);
        public T Delete<K>(K id);
    }

    public class People : ICRUD<Person>
    {
        private readonly List<Person> peopleList = [];

        public Person Create(Person person)
        {
            if (!person.IsValidFirstName())
            {
                throw new Exception("FirstName can not be empty, please provide a valid value");
            }
            if (!person.IsValidLastName())
            {
                throw new Exception("LastName can not be empty, please provide a valid value");
            }
            if (!person.IsValidAge())
            {
                throw new Exception("Age should be graater than 0.");
            }

            int newId = peopleList.Count + 1;
            person.Id = newId;
            peopleList.Add(person);

            return person;
        }

        Person ICRUD<Person>.Delete<K>(K id)
        {
            throw new NotImplementedException();
        }

        List<Person> ICRUD<Person>.GetAll()
        {
            throw new NotImplementedException();
        }

        Person ICRUD<Person>.GetById<K>(K id)
        {
            throw new NotImplementedException();
        }

        Person ICRUD<Person>.Update(Person person)
        {
            throw new NotImplementedException();
        }

        public void DisplayPeople()
        {
            peopleList.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}

