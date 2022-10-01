using System.Collections.Generic;

class PersonList {
    private List<Person> personlist;

    public PersonList() {
        this.personlist = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personlist.Add(person);
    }

    public void FetchPersonList() {
        Console.WriteLine("List Person");
        Console.WriteLine("**********************");

        foreach(Person person in this.personlist) {
            if (person is Student) {
                Console.WriteLine("Type: Student");
                Console.WriteLine("\n Name : {0}", person.GetName());
                Console.WriteLine(" Address : {0}", person.GetAddress());
                Console.WriteLine(" CitizenID : {0}", person.GetCitizenID());
                Console.WriteLine(" StudentID : {0}");
                Console.WriteLine();
            } else if (person is Teacher) {
                Console.WriteLine("Type: Teacher");
                Console.WriteLine("\n Name : {0}", person.GetName());
                Console.WriteLine(" Address : {0}", person.GetAddress());
                Console.WriteLine(" CitizenID : {0}", person.GetCitizenID());
                Console.WriteLine(" EmployeeID : {0}");
                Console.WriteLine();
            }
        }
    }
}