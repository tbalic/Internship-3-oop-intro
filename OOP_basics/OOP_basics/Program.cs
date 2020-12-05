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

            var firstEvent = new Event("Kava s prijateljima");
            var secondEvent = new Event("Predavanje na FESB-u");
            var thirdEvent = new Event("Prljavo Kazalište u Areni");
            var fourthEvent = new Event("Repeticije");

            firstEvent.EventType = (int)DecidingEventType.Coffee;
            secondEvent.EventType = (int)DecidingEventType.Lecture;
            thirdEvent.EventType = (int)DecidingEventType.Concert;
            fourthEvent.EventType = (int)DecidingEventType.StudySession;

            firstEvent.StartDateTime = new DateTime(2020, 12, 29, 10, 00, 00);
            secondEvent.StartDateTime = new DateTime(2021, 1, 17, 17, 00, 00);
            thirdEvent.StartDateTime = new DateTime(2021, 1, 21, 20, 00, 00);
            fourthEvent.StartDateTime = new DateTime(2021, 1, 25, 10, 00, 00);

            firstEvent.EndDateTime = new DateTime(2020, 12, 29, 12, 00, 00);
            secondEvent.EndDateTime = new DateTime(2021, 1, 17, 20, 00, 00);
            thirdEvent.EndDateTime = new DateTime(2021, 1, 21, 23, 00, 00);
            fourthEvent.EndDateTime = new DateTime(2021, 1, 25, 13, 00, 00);


            var dictionary = new Dictionary<Event, List<Person>>
            {
                {firstEvent, CoffeeList},
                {secondEvent, LectureList },
                {thirdEvent, ConcertList },
                {fourthEvent, StudySessionList }
            };

            var mainVariable = Menu();

            while (mainVariable != 0)
            {
                switch (mainVariable)
                {
                    case 1:
                        Console.WriteLine(" ");
                        Console.WriteLine("Odabrali ste dodavanje eventa. Molimo unesite ime eventa koji želite dodati");
                        var addingEventName = Console.ReadLine();
                        var helper = 0;
                        while (helper < 2)
                        {
                            foreach (var pair in dictionary)
                            {
                                bool comparingNames = pair.Key.Name.Equals(addingEventName, StringComparison.OrdinalIgnoreCase);
                                while (comparingNames)
                                {
                                    Console.WriteLine("Već postoji event s ovim imenom. Molimo vas unesite drugo ime.");
                                    addingEventName = Console.ReadLine();
                                    comparingNames = pair.Key.Name.Equals(addingEventName, StringComparison.OrdinalIgnoreCase);
                                    helper = 0;
                                }
                            }
                            helper++;
                            while (addingEventName == "")
                            {
                                Console.WriteLine("Niste unijeli ime eventa. Molimo unesite ime eventa.");
                                addingEventName = Console.ReadLine();
                                helper = 0;
                            }
                            helper++;
                        }
                        var addedEventName = addingEventName;
                        Console.WriteLine("Unesite vrstu eventa kojeg želite dodati");
                        Console.WriteLine("Za Coffee unesite 1");
                        Console.WriteLine("Za Lecture unesite 2");
                        Console.WriteLine("Za Concert unesite 3");
                        Console.WriteLine("Za StudySession unesite 4");
                        int number;
                        var addingEventType = Console.ReadLine();
                        bool success = Int32.TryParse(addingEventType, out number);
                        while (!success)
                        {
                            Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                            addingEventType = Console.ReadLine();
                            success = Int32.TryParse(addingEventType, out number);
                        }
                        var addedEventType = int.Parse(addingEventType);

                        var a = 0;
                        while (a < 13)
                        {
                            Console.WriteLine("Unesite godinu održavanja eventa");
                            int numberHelper;
                            var addingYear = Console.ReadLine();
                            bool checkingYear = Int32.TryParse(addingYear, out numberHelper);
                            while (!checkingYear)
                            {
                                Console.WriteLine("Molimo upišite godinu BROJEM: ");
                                addingYear = Console.ReadLine();
                                checkingYear = Int32.TryParse(addingYear, out numberHelper);
                            }
                            var addedYear = int.Parse(addingYear);
                            a++;
                            Console.WriteLine("Unesite mjesec održavanja eventa");
                            int helperNumber;
                            var addingMonth = Console.ReadLine();
                            bool checkingMonth = Int32.TryParse(addingMonth, out helperNumber);
                            while (!checkingMonth)
                            {
                                Console.WriteLine("Molimo upišite mjesec BROJEM: ");
                                addingMonth = Console.ReadLine();
                                checkingMonth = Int32.TryParse(addingMonth, out helperNumber);
                            }
                            var addedMonth = int.Parse(addingMonth);
                            a++;
                            Console.WriteLine("Unesite dan održavanja eventa");
                            int helpNumber;
                            var addingDay = Console.ReadLine();
                            bool checkingDay = Int32.TryParse(addingDay, out helpNumber);
                            while (!checkingDay)
                            {
                                Console.WriteLine("Molimo upišite dan BROJEM: ");
                                addingDay = Console.ReadLine();
                                checkingDay = Int32.TryParse(addingDay, out helpNumber);
                            }
                            var addedDay = int.Parse(addingDay);
                            a++;
                            Console.WriteLine("Unesite puni sat održavanja eventa");
                            int numberHelp;
                            var addingHour = Console.ReadLine();
                            bool checkingHour = Int32.TryParse(addingHour, out numberHelp);
                            while (!checkingHour)
                            {
                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                addingHour = Console.ReadLine();
                                checkingHour = Int32.TryParse(addingHour, out numberHelp);
                            }
                            var addedHour = int.Parse(addingHour);
                            a++;
                            Console.WriteLine("Unesite minute održavanja eventa");
                            int HelpingNumber;
                            var addingMinutes = Console.ReadLine();
                            bool checkingMinutes = Int32.TryParse(addingMinutes, out HelpingNumber);
                            while (!checkingMinutes)
                            {
                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                addingMinutes = Console.ReadLine();
                                checkingMinutes = Int32.TryParse(addingMinutes, out HelpingNumber);
                            }
                            var addedMinutes = int.Parse(addingMinutes);
                            a++;
                            var addedSeconds = 00;

                            Console.WriteLine("Unesite godinu završavanja eventa");
                            int numberHelperEnd;
                            var addingEndYear = Console.ReadLine();
                            bool checkingEndYear = Int32.TryParse(addingEndYear, out numberHelperEnd);
                            while (!checkingEndYear)
                            {
                                Console.WriteLine("Molimo upišite godinu BROJEM: ");
                                addingEndYear = Console.ReadLine();
                                checkingEndYear = Int32.TryParse(addingEndYear, out numberHelperEnd);
                            }
                            var addedEndYear = int.Parse(addingEndYear);
                            while (addedEndYear < addedYear)
                            {
                                Console.WriteLine("Event ne može završiti prije no što počne.");
                                Console.WriteLine("Molimo unesite novu godinu");
                                addingEndYear = Console.ReadLine();
                                checkingEndYear = Int32.TryParse(addingEndYear, out numberHelperEnd);
                                while (!checkingEndYear)
                                {
                                    Console.WriteLine("Molimo upišite godinu BROJEM: ");
                                    addingEndYear = Console.ReadLine();
                                    checkingEndYear = Int32.TryParse(addingEndYear, out numberHelperEnd);
                                }
                                addedEndYear = int.Parse(addingEndYear);
                            }
                            a++;
                            Console.WriteLine("Unesite mjesec završavanja eventa");
                            int helperNumberEnd;
                            var addingEndMonth = Console.ReadLine();
                            bool checkingEndMonth = Int32.TryParse(addingEndMonth, out helperNumberEnd);
                            while (!checkingEndMonth)
                            {
                                Console.WriteLine("Molimo upišite mjesec BROJEM: ");
                                addingEndMonth = Console.ReadLine();
                                checkingEndMonth = Int32.TryParse(addingEndMonth, out helperNumberEnd);
                            }
                            var addedEndMonth = int.Parse(addingEndMonth);
                            if (addedEndYear == addedYear)
                            {
                                while (addedEndMonth < addedMonth)
                                {
                                    Console.WriteLine("Event ne može završiti prije no što počne.");
                                    Console.WriteLine("Molimo unesite novi mjesec");
                                    addingEndMonth = Console.ReadLine();
                                    checkingEndMonth = Int32.TryParse(addingEndMonth, out helperNumberEnd);
                                    while (!checkingEndMonth)
                                    {
                                        Console.WriteLine("Molimo upišite mjesec BROJEM: ");
                                        addingEndMonth = Console.ReadLine();
                                        checkingEndMonth = Int32.TryParse(addingEndMonth, out helperNumberEnd);
                                    }
                                    addedEndMonth = int.Parse(addingEndMonth);
                                }
                            }
                            a++;
                            Console.WriteLine("Unesite dan završavanja eventa");
                            int helpNumberEnd;
                            var addingEndDay = Console.ReadLine();
                            bool checkingEndDay = Int32.TryParse(addingEndDay, out helpNumberEnd);
                            while (!checkingEndDay)
                            {
                                Console.WriteLine("Molimo upišite dan BROJEM: ");
                                addingEndDay = Console.ReadLine();
                                checkingEndDay = Int32.TryParse(addingEndDay, out helpNumberEnd);
                            }
                            var addedEndDay = int.Parse(addingEndDay);
                            if (addedEndYear == addedYear)
                            {
                                if (addedEndMonth == addedMonth)
                                {
                                    while (addedEndDay < addedDay)
                                    {
                                        Console.WriteLine("Event ne može završiti prije no što počne.");
                                        Console.WriteLine("Molimo unesite novi dan");
                                        addingEndDay = Console.ReadLine();
                                        checkingEndDay = Int32.TryParse(addingEndDay, out helpNumberEnd);
                                        while (!checkingEndDay)
                                        {
                                            Console.WriteLine("Molimo upišite dan BROJEM: ");
                                            addingEndDay = Console.ReadLine();
                                            checkingEndDay = Int32.TryParse(addingEndDay, out helpNumberEnd);
                                        }
                                        addedEndDay = int.Parse(addingEndDay);
                                    }
                                }
                            }
                            a++;
                            Console.WriteLine("Unesite puni sat završavanja eventa");
                            int numberHelpEnd;
                            var addingEndHour = Console.ReadLine();
                            bool checkingEndHour = Int32.TryParse(addingEndHour, out numberHelpEnd);
                            while (!checkingEndHour)
                            {
                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                addingEndHour = Console.ReadLine();
                                checkingEndHour = Int32.TryParse(addingEndHour, out numberHelpEnd);
                            }
                            var addedEndHour = int.Parse(addingEndHour);
                            if (addedEndYear == addedYear)
                            {
                                if (addedEndMonth == addedMonth)
                                {
                                    if (addedEndDay == addedDay)
                                    {
                                        while (addedEndHour < addedHour)
                                        {
                                            Console.WriteLine("Event ne može završiti prije no što počne.");
                                            Console.WriteLine("Molimo unesite novi puni sat");
                                            addingEndHour = Console.ReadLine();
                                            checkingEndHour = Int32.TryParse(addingEndHour, out numberHelpEnd);
                                            while (!checkingEndHour)
                                            {
                                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                                addingEndHour = Console.ReadLine();
                                                checkingEndHour = Int32.TryParse(addingEndHour, out numberHelpEnd);
                                            }
                                            addedEndHour = int.Parse(addingEndHour);
                                        }
                                    }
                                }
                            }
                            a++;
                            Console.WriteLine("Unesite minute završavanja eventa");
                            int HelpingNumberEnd;
                            var addingEndMinutes = Console.ReadLine();
                            bool checkingEndMinutes = Int32.TryParse(addingEndMinutes, out HelpingNumberEnd);
                            while (!checkingEndMinutes)
                            {
                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                addingEndMinutes = Console.ReadLine();
                                checkingEndMinutes = Int32.TryParse(addingEndMinutes, out HelpingNumberEnd);
                            }
                            var addedEndMinutes = int.Parse(addingEndMinutes);
                            if (addedEndYear == addedYear)
                            {
                                if (addedEndMonth == addedMonth)
                                {
                                    if (addedEndDay == addedDay)
                                    {
                                        if (addedEndHour == addedHour)
                                        {
                                            while (addedEndMinutes < addedMinutes)
                                            {
                                                Console.WriteLine("Event ne može završiti prije no što počne.");
                                                Console.WriteLine("Molimo unesite nove minute");
                                                addingEndMinutes = Console.ReadLine();
                                                checkingEndMinutes = Int32.TryParse(addingEndMinutes, out HelpingNumberEnd);
                                                while (!checkingEndMinutes)
                                                {
                                                    Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                                    addingEndMinutes = Console.ReadLine();
                                                    checkingEndMinutes = Int32.TryParse(addingEndMinutes, out HelpingNumberEnd);
                                                }
                                                addedEndMinutes = int.Parse(addingEndMinutes);
                                            }
                                        }
                                    }
                                }
                            }
                            a++;
                            var addedEndSeconds = 00;

                            var addedEvent = new Event(addedEventName);
                            addedEvent.EventType = addedEventType;
                            addedEvent.StartDateTime = new DateTime(addedYear, addedMonth, addedDay, addedHour, addedMinutes, addedSeconds);
                            addedEvent.EndDateTime = new DateTime(addedEndYear, addedEndMonth, addedEndDay, addedEndHour, addedEndMinutes, addedEndSeconds);
                            var b = 0;
                            foreach(var pair in dictionary)
                            {
                                if((addedEvent.StartDateTime > pair.Key.StartDateTime) && (addedEvent.StartDateTime < pair.Key.EndDateTime))
                                {
                                    b=0;
                                }
                                else
                                {
                                    b++;
                                }
                            }
                            if (b == dictionary.Count)
                            {
                                a++;
                            }
                            var c = 0;
                            foreach (var pair in dictionary)
                            {
                                if ((addedEvent.EndDateTime > pair.Key.StartDateTime) && (addedEvent.EndDateTime < pair.Key.EndDateTime))
                                {
                                    c=0;
                                }
                                else
                                {
                                    c++;
                                }
                            }
                            if (c == dictionary.Count)
                            {
                                a++;
                            }
                            var d = 0;
                            foreach(var pair in dictionary)
                            {
                                if((addedEvent.StartDateTime < pair.Key.StartDateTime) && (addedEvent.EndDateTime > pair.Key.EndDateTime))
                                {
                                    d = 0;
                                }
                                else
                                {
                                    d++;
                                }
                            }
                            if (d == dictionary.Count)
                            {
                                a++;
                            }
                            if (a < 13)
                            {
                                Console.WriteLine("Vrijeme eventa preklapa se s vremenom već postojećeg eventa. Molimo vas promijenite vrijeme eventa.");
                            }
                            else
                            {
                                addedEvent = new Event(addedEventName);
                                addedEvent.EventType = addedEventType;
                                addedEvent.StartDateTime = new DateTime(addedYear, addedMonth, addedDay, addedHour, addedMinutes, addedSeconds);
                                addedEvent.EndDateTime = new DateTime(addedEndYear, addedEndMonth, addedEndDay, addedEndHour, addedEndMinutes, addedEndSeconds);

                                var AddedEventList = new List<Person>() { };

                                dictionary.Add(addedEvent, AddedEventList);
                                break;
                            }
                        }
                        Console.WriteLine("Event uspješno dodan u dictionary");
                        mainVariable = Decision();
                        break;
                    case 2:
                        Console.WriteLine(" ");
                        Console.WriteLine("Odabrali ste brisanje eventa. Upišite ime eventa koji želite izbrisati.");
                        var deleteEventName = Console.ReadLine();
                        var counter = 0;
                        var rememberValue = new Event("");
                        foreach(var pair in dictionary)
                        {
                            bool comparison = deleteEventName.Equals(pair.Key.Name, StringComparison.OrdinalIgnoreCase);
                            if (comparison)
                            {
                                rememberValue = pair.Key; 
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        if (counter == dictionary.Count)
                        {
                            Console.WriteLine("Odabrani event nije pronađen.");
                        }
                        else
                        {
                            dictionary.Remove(rememberValue);
                            Console.WriteLine("Odabrani event uspješno uklonjen.");
                        }
                        mainVariable = Decision();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        var branchVariable = AdditionalMenu();
                        while (branchVariable != 0)
                        {
                            switch (branchVariable)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    branchVariable = 999;
                                    break;
                                default:
                                    break;
                            }
                            if (branchVariable == 999)
                            {
                                break;
                            }
                            branchVariable = AdditionalMenu();
                            if (branchVariable == 4)
                            {
                                break;
                            }
                        }
                        break;
                    case 7:
                        mainVariable = 999;
                        break;
                    default:
                        Console.WriteLine("Odabrani broj ne postoji u izborniku.");
                        mainVariable = Decision();
                        break;
                }
                if (mainVariable == 999)
                {
                    break;
                }
                mainVariable = Menu();
                if (mainVariable == 7)
                {
                    break;
                }
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
            while (!conversion)
            {
                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                choiceOfAction = Console.ReadLine();
                conversion = Int32.TryParse(choiceOfAction, out number);
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
            bool secondConversion = Int32.TryParse(secondChoiceOfAction, out number);
            while (!secondConversion)
            {
                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                secondChoiceOfAction = Console.ReadLine();
                secondConversion = Int32.TryParse(secondChoiceOfAction, out number);
            }
            var result = int.Parse(secondChoiceOfAction);
            return result;
        }

        static int Decision()
        {
            Console.WriteLine("Povratak na izbornik?(da/ne)");
            var goBack = Console.ReadLine();
            bool equality = goBack.Equals("da", StringComparison.OrdinalIgnoreCase);
            if (equality == true)
            {
                var finalDecision = 0;
                return finalDecision;
            }
            else
            {
                Console.WriteLine("Kraj programa");
                var finalDecision = 999;
                return finalDecision;
            }

        }

    }
}
