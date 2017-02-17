using System;
using EFPerson.Models;

namespace EFPerson
{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello! Please answer a few questions!");
            System.Console.WriteLine("First Name:");
            string fname = Console.ReadLine();
            System.Console.WriteLine("Last Name:");
            string lname = Console.ReadLine();
            System.Console.WriteLine("Age:");
            string age = Console.ReadLine();

            int myAge = Int32.Parse(age);


            using(var db = new PersonContext()){
                var TableContents = db.Persons;

                Person NewPerson = new Person{
                    FirstName = fname,
                    LastName = lname,
                    Age = myAge
                };
                db.Add(NewPerson);
                db.SaveChanges();
            }


            System.Console.WriteLine($"Thank You {fname} {lname}!");
        }
    }
}
