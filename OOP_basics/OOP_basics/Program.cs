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

            string stringHelperOne = DecidingEventType.Coffee;
            string stringHelperTwo = DecidingEventType.Lecture;
            string stringHelperThree = DecidingEventType.Concert;
            string stringHelperFour = eventType.StudySession;

            var dictionary = new Dictionary<string, List<Person>>
            {
                {stringHelperOne, CoffeeList },
                {stringHelperTwo, LectureList },
                {stringHelperThree, ConcertList },
                {stringHelperFour, StudySessionList }

            };
        }

        enum DecidingEventType
        {
            Coffee,
            Lecture,
            Concert,
            StudySession
        }
    }
}
