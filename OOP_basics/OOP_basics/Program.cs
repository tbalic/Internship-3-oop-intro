using System;
using System.Collections.Generic;

namespace OOP_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person("Ernest", "Hemingway", 111, 000);
            var secondPerson = new Person("Marko", "Marulić", 112, 001);
            var thirdPerson = new Person("Dobriša", "Cesarić", 113, 002);
            var fourthPerson = new Person("William", "Shakespeare", 114, 003);
            var fifthPerson = new Person("Pablo", "Neruda", 115, 004);
            var sixthPerson = new Person("Fjodor", "Mihajlovič Dostojevski", 116, 005);
            var seventhPerson = new Person("Alber", "Camus", 117, 006);
            var eighthPerson = new Person("Charles", "Dickens", 118, 007);
            var ninthPerson = new Person("Petar", "Preradović", 119, 008);
            var tenthPerson = new Person("Victor", "Hugo", 120, 009);
            var eleventhPerson = new Person("Miroslav", "Krleža", 121, 010);
            var twelfthPerson = new Person("Tin", "Ujević", 122, 011);

            var CoffeeList = new List<Person>() { firstPerson, secondPerson, thirdPerson };
            var LectureList = new List<Person>() { fourthPerson, fifthPerson, sixthPerson };
            var ConcertList = new List<Person>() { seventhPerson, eighthPerson, ninthPerson };
            var StudySessionList = new List<Person> { tenthPerson, eleventhPerson, twelfthPerson };

            var helpingVariableOne = 1;
            var helpingVariableTwo = 2;
            var helpingVariableThree = 3;
            var helpingVariableFour = 4;

            var firstEvent = new Event("Kava s prijateljima", helpingVariableOne, "1.1. u 10.00", "1.1. u 12.00");
            var secondEvent = new Event("Predavanje na FESB-u", helpingVariableTwo, "10.1. u 17.00", "10.1. u 20.00");
            var thirdEvent = new Event("Prljavo Kazalište u Areni", helpingVariableThree, "17.1. u 20.00", "17.1. u 23.00");
            var fourthEvent = new Event("Repeticije", helpingVariableFour, "21.1. u 10.00", "21.1. u 12.00");

            var dictionary = new Dictionary<string, List<Person>>
            {
                {firstEvent.Name , CoffeeList},
                {secondEvent.Name, LectureList },
                {thirdEvent.Name, ConcertList },
                {fourthEvent.Name, StudySessionList }
            };

            var a = Menu();
            switch (a)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    var b = AdditionalMenu();
                    switch (b)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    break;
                default:
                    break;
            }


        }

        enum DecidingEventType
        {
            Coffee = 1,
            Lecture = 2,
            Concert = 3,
            StudySession = 4
        }

        static int Menu()
        {
            Console.WriteLine("Izbornik");
            Console.WriteLine("1 - Dodajte eventa");
            Console.WriteLine("2 - Brisanje eventa");
            Console.WriteLine("3 - Edit eventa");
            Console.WriteLine("4 - Dodavanje osobe na event");
            Console.WriteLine("5 - Brisanje osobe s eventa");
            Console.WriteLine("6 - Ispis detalja eventa");
            Console.WriteLine("7 - Izlaz iz aplikacije");
            Console.WriteLine(" ");
            Console.WriteLine("Odaberite akciju upisujući njezin broj: ");
            int number;
            var choiceOfAction = Console.ReadLine();
            bool conversion = Int32.TryParse(choiceOfAction, out number);
            while (! conversion)
            {
                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                choiceOfAction = Console.ReadLine();
                conversion= Int32.TryParse(choiceOfAction, out number);
            }
            var finalChoiceOfAction = int.Parse(choiceOfAction);
            return finalChoiceOfAction;
        }

        static int AdditionalMenu()
        {
            Console.WriteLine("1 - Ispis detalja eventa");
            Console.WriteLine("2 - Popis osoba na eventu");
            Console.WriteLine("3 - Ispis detalja eventa i popis osoba tog eventa");
            Console.WriteLine("4 - Povratak na glavni izbornik");
            Console.WriteLine(" ");
            Console.WriteLine("Odaberite akciju upisujući njezin broj: ");
            int number;
            var secondChoiceOfAction = Console.ReadLine();
            bool success = Int32.TryParse(secondChoiceOfAction, out number);
            while (!success)
            {
                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                secondChoiceOfAction = Console.ReadLine();
                success = Int32.TryParse(secondChoiceOfAction, out number);
            }
            var result = int.Parse(secondChoiceOfAction);
            return result;
        }

    }

    
}
