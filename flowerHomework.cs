using System;

namespace flowerHomework
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class Student : Person
        {
            private string studentID;

            public Student(string name, string address, string citizenID, string studentID)
            : base(name, address, citizenID)
            {
                this.studentID = studentID;
            }
            public void newStudent() 
            {
                static string InputName()
                {
                    Console.Write("Name: ");

                    return Console.ReadLine();
                }

                static string InputStudentID()
                {
                    Console.Write("Student ID: ");

                    return Console.ReadLine();
                }

                static string InputAddress()
                {
                    Console.Write("Address: ");

                    return Console.ReadLine();
                }

                static string InputCitizenID()
                {
                    Console.Write("Citizen ID: ");

                    return Console.ReadLine();
                }
            }

        }
        class Person
        {
            protected string name;
            protected string address;
            protected string citizenID;

            public Person(string name, string address, string citizenID)
            {
                this.name = name;
                this.address = address;
                this.citizenID = citizenID;
            }

            public string GetName()
            {
                return this.name;
            }

        }

        class PersonList
        {
            private List<Person> personList;

            public PersonList()
            {
                this.personList = new List<Person>();
            }

            public void AddNewPerson(Person person)
            {
                this.personList.Add(person);
            }

            public void FetchPersonsList()
            {
                Console.WriteLine("List Persons");
                Console.WriteLine("---------------------");
                foreach (Person person in this.personList)
                {
                    if (person is Student)
                    {
                        Console.WriteLine("Name: {0} \nType: Student \n", person.GetName());
                    }
                    else if (person is Teacher)
                    {
                        Console.WriteLine("Name: {0} \nType: Teacher \n", person.GetName());
                    }
                }
            }
        }


    }

}
