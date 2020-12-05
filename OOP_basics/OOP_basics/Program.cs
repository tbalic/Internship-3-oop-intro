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

            var firstEvent = new Event("Kava s prijateljima", Event.DecidingEventType.Coffee, new DateTime(2020, 12, 29, 10, 00, 00), new DateTime(2020, 12, 29, 12, 00, 00));
            var secondEvent = new Event("Predavanje na FESB-u", Event.DecidingEventType.Lecture, new DateTime(2021, 1, 17, 17, 00, 00), new DateTime(2021, 1, 17, 20, 00, 00));
            var thirdEvent = new Event("Prljavo Kazalište u Areni", Event.DecidingEventType.Concert, new DateTime(2021, 1, 21, 20, 00, 00), new DateTime(2021, 1, 21, 23, 00, 00));
            var fourthEvent = new Event("Repeticije", Event.DecidingEventType.StudySession, new DateTime(2021, 1, 25, 10, 00, 00), new DateTime(2021, 1, 25, 13, 00, 00));

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
                        int promission = 0;
                        var addedType = Event.DecidingEventType.NoExistingType;
                        while (promission < 3)
                        {
                            int number;
                            var addingEventType = Console.ReadLine();
                            bool success = Int32.TryParse(addingEventType, out number);
                            while (!success)
                            {
                                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                                addingEventType = Console.ReadLine();
                                success = Int32.TryParse(addingEventType, out number);
                                promission = 0;
                            }
                            var addEventType = int.Parse(addingEventType);
                            promission++;
                            while (addEventType <= 0 && addEventType > 4)
                            {
                                Console.WriteLine("Ne postoji predloženi tip eventa. Pokušajte ponovno s dodavanjem tipa eventa.");
                                addingEventType = Console.ReadLine();
                                bool successful = Int32.TryParse(addingEventType, out number);
                                while (!successful)
                                {
                                    Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                                    addingEventType = Console.ReadLine();
                                    successful = Int32.TryParse(addingEventType, out number);
                                }
                                addEventType = int.Parse(addingEventType);
                                promission = 0;

                            }
                            var helperType = addEventType;
                            promission++;
                            if (helperType == 1)
                            {
                                addedType = Event.DecidingEventType.Coffee;
                                promission++;
                            }
                            else if (helperType == 2)
                            {
                                addedType = Event.DecidingEventType.Lecture;
                                promission++;
                            }
                            else if (helperType == 3)
                            {
                                addedType = Event.DecidingEventType.Concert;
                                promission++;
                            }
                            else if (helperType == 4)
                            {
                                addedType = Event.DecidingEventType.StudySession;
                                promission++;
                            }
                            else
                            {
                                Console.WriteLine("Odabrani tip ne postoji. Molimo pokušajte ponovno.");
                                promission = 0;
                            }
                        }
                        var addedEventType = addedType;

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

                            var addedEvent = new Event(addedEventName, addedEventType, new DateTime(addedYear, addedMonth, addedDay, addedHour, addedMinutes, addedSeconds), new DateTime(addedEndYear, addedEndMonth, addedEndDay, addedEndHour, addedEndMinutes, addedEndSeconds));

                            var b = 0;

                            foreach (var pair in dictionary)
                            {
                                if ((addedEvent.StartDateTime > pair.Key.StartDateTime) && (addedEvent.StartDateTime < pair.Key.EndDateTime))
                                {
                                    b = 0;
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
                                    c = 0;
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
                            foreach (var pair in dictionary)
                            {
                                if ((addedEvent.StartDateTime < pair.Key.StartDateTime) && (addedEvent.EndDateTime > pair.Key.EndDateTime))
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
                                addedEvent = new Event(addedEventName, addedEventType, new DateTime(addedYear, addedMonth, addedDay, addedHour, addedMinutes, addedSeconds), new DateTime(addedEndYear, addedEndMonth, addedEndDay, addedEndHour, addedEndMinutes, addedEndSeconds));

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
                        var rememberValue = new Event("", Event.DecidingEventType.NoExistingType, new DateTime(2020, 12, 4, 17, 10, 00), new DateTime(2020, 12, 5, 23, 30, 00));
                        foreach (var pair in dictionary)
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
                        Console.WriteLine(" ");
                        Console.WriteLine("Odabrali ste uređivanje eventa. Upišite ime eventa koji želite urediti.");
                        var editEventName = Console.ReadLine();
                        var count = 0;
                        var rememberingValue = new Event("", Event.DecidingEventType.NoExistingType, new DateTime(2020, 12, 4, 17, 10, 00), new DateTime(2020, 12, 5, 23, 30, 00));
                        foreach (var pair in dictionary)
                        {
                            bool compare = editEventName.Equals(pair.Key.Name, StringComparison.OrdinalIgnoreCase);
                            if (compare)
                            {
                                rememberingValue = pair.Key;
                            }
                            else
                            {
                                count++;
                            }
                        }
                        if (count == dictionary.Count)
                        {
                            Console.WriteLine("Odabrani event nije pronađen.");
                        }
                        else
                        {
                            var editChoice = EditingEvent();
                            while (editChoice > 0)
                            {
                                switch (editChoice)
                                {
                                    case 1:
                                        Console.WriteLine("");
                                        Console.WriteLine("Odabrali ste uređivanje imena eventa. Unesite novo ime kako želite preimenovati event.");
                                        var renameEvent = Console.ReadLine();
                                        rememberingValue.Name = renameEvent;
                                        editChoice = 0;
                                        break;
                                    case 2:
                                        Console.WriteLine("");
                                        Console.WriteLine("Odabrali ste uređivanje tipa eventa. Unesite novi tip u koji želite promijeniti event.");
                                        Console.WriteLine("Za Coffee unesite 1");
                                        Console.WriteLine("Za Lecture unesite 2");
                                        Console.WriteLine("Za Concert unesite 3");
                                        Console.WriteLine("Za StudySession unesite 4");
                                        var permissionCheck = 0;
                                        var editedType = Event.DecidingEventType.NoExistingType;
                                        while (permissionCheck < 3)
                                        {
                                            int someInteger;
                                            var editingEventType = Console.ReadLine();
                                            bool converting = Int32.TryParse(editingEventType, out someInteger);
                                            while (!converting)
                                            {
                                                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                                                editingEventType = Console.ReadLine();
                                                converting = Int32.TryParse(editingEventType, out someInteger);
                                                permissionCheck = 0;
                                            }
                                            var editEventType = int.Parse(editingEventType);
                                            permissionCheck++;
                                            while (editEventType <= 0 && editEventType > 4)
                                            {
                                                Console.WriteLine("Ne postoji predloženi tip eventa. Pokušajte ponovno s dodavanjem tipa eventa.");
                                                editingEventType = Console.ReadLine();
                                                bool convertingSuccessful = Int32.TryParse(editingEventType, out someInteger);
                                                while (!convertingSuccessful)
                                                {
                                                    Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                                                    editingEventType = Console.ReadLine();
                                                    convertingSuccessful = Int32.TryParse(editingEventType, out someInteger);
                                                }
                                                editEventType = int.Parse(editingEventType);
                                                permissionCheck = 0;

                                            }
                                            var helperEditType = editEventType;
                                            permissionCheck++;
                                            if (helperEditType == 1)
                                            {
                                                editedType = Event.DecidingEventType.Coffee;
                                                Console.WriteLine($"Tip eventa promijenjen u {Event.DecidingEventType.Coffee}");
                                                permissionCheck++;
                                            }
                                            else if (helperEditType == 2)
                                            {
                                                editedType = Event.DecidingEventType.Lecture;
                                                Console.WriteLine($"Tip eventa promijenjen u {Event.DecidingEventType.Lecture}");
                                                permissionCheck++;
                                            }
                                            else if (helperEditType == 3)
                                            {
                                                editedType = Event.DecidingEventType.Concert;
                                                Console.WriteLine($"Tip eventa promijenjen u {Event.DecidingEventType.Concert}");
                                                permissionCheck++;
                                            }
                                            else if (helperEditType == 4)
                                            {
                                                editedType = Event.DecidingEventType.StudySession;
                                                Console.WriteLine($"Tip eventa promijenjen u {Event.DecidingEventType.StudySession}");
                                                permissionCheck++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Odabrani tip ne postoji. Molimo pokušajte ponovno.");
                                                permissionCheck = 0;
                                            }
                                        }
                                        var editedEventType = editedType;

                                        rememberingValue.EventType = editedEventType;

                                        editChoice = 0;
                                        break;

                                    case 3:
                                        Console.WriteLine("Odabrali ste uređivanje vremena početka eventa.");
                                        Console.WriteLine("Unesite godinu održavanja eventa");
                                        int numberHelper;
                                        var editingYear = Console.ReadLine();
                                        bool checkYear = Int32.TryParse(editingYear, out numberHelper);
                                        while (!checkYear)
                                        {
                                            Console.WriteLine("Molimo upišite godinu BROJEM: ");
                                            editingYear = Console.ReadLine();
                                            checkYear = Int32.TryParse(editingYear, out numberHelper);
                                        }
                                        var editedYear = int.Parse(editingYear);
                                        Console.WriteLine("Unesite mjesec održavanja eventa");
                                        int helperNumber;
                                        var editingMonth = Console.ReadLine();
                                        bool checkMonth = Int32.TryParse(editingMonth, out helperNumber);
                                        while (!checkMonth)
                                        {
                                            Console.WriteLine("Molimo upišite mjesec BROJEM: ");
                                            editingMonth = Console.ReadLine();
                                            checkMonth = Int32.TryParse(editingMonth, out helperNumber);
                                        }
                                        var editedMonth = int.Parse(editingMonth);
                                        Console.WriteLine("Unesite dan održavanja eventa");
                                        int helpNumber;
                                        var editingDay = Console.ReadLine();
                                        bool checkDay = Int32.TryParse(editingDay, out helpNumber);
                                        while (!checkDay)
                                        {
                                            Console.WriteLine("Molimo upišite dan BROJEM: ");
                                            editingDay = Console.ReadLine();
                                            checkDay = Int32.TryParse(editingDay, out helpNumber);
                                        }
                                        var editedDay = int.Parse(editingDay);
                                        Console.WriteLine("Unesite puni sat održavanja eventa");
                                        int numberHelp;
                                        var editingHour = Console.ReadLine();
                                        bool checkHour = Int32.TryParse(editingHour, out numberHelp);
                                        while (!checkHour)
                                        {
                                            Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                            editingHour = Console.ReadLine();
                                            checkHour = Int32.TryParse(editingHour, out numberHelp);
                                        }
                                        var editedHour = int.Parse(editingHour);
                                        Console.WriteLine("Unesite minute održavanja eventa");
                                        int HelpingNumber;
                                        var editingMinutes = Console.ReadLine();
                                        bool checkMinutes = Int32.TryParse(editingMinutes, out HelpingNumber);
                                        while (!checkMinutes)
                                        {
                                            Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                            editingMinutes = Console.ReadLine();
                                            checkMinutes = Int32.TryParse(editingMinutes, out HelpingNumber);
                                        }
                                        var editedMinutes = int.Parse(editingMinutes);
                                        var editedSeconds = 00;
                                        rememberingValue.StartDateTime = new DateTime(editedYear, editedMonth, editedDay, editedHour, editedMinutes, editedSeconds);
                                        var y = 0;
                                        foreach (var pair in dictionary)
                                        {
                                            if ((rememberingValue.StartDateTime > pair.Key.StartDateTime) && (rememberingValue.StartDateTime < pair.Key.EndDateTime))
                                            {
                                                y = 0;
                                            }
                                            else
                                            {
                                                y++;
                                            }
                                        }
                                        foreach (var pair in dictionary)
                                        {
                                            if ((rememberingValue.StartDateTime < pair.Key.StartDateTime) && (rememberingValue.EndDateTime > pair.Key.EndDateTime))
                                            {
                                                y = 0;
                                            }
                                            else
                                            {
                                                y++;
                                            }
                                        }
                                        if (y != dictionary.Count * 2)
                                        {
                                            Console.WriteLine("Uređeni event se vremenom poklapa s već postojećim eventom. Molimo ponovno uredite event.");
                                            editChoice = EditingEvent();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Event uspješno promijenjen.");
                                            editChoice = 0;
                                        }
                                        break;
                                    case 4:
                                        var possible = 0;
                                        Console.WriteLine("Odabrali ste uređivanje vremena završavanja eventa.");
                                        while (possible < 6)
                                        {
                                            Console.WriteLine("Unesite godinu završavanja eventa");
                                            int helpInteger;
                                            var editingEndYear = Console.ReadLine();
                                            bool checkEndYear = Int32.TryParse(editingEndYear, out helpInteger);
                                            while (!checkEndYear)
                                            {
                                                Console.WriteLine("Molimo upišite godinu BROJEM: ");
                                                editingEndYear = Console.ReadLine();
                                                checkEndYear = Int32.TryParse(editingEndYear, out helpInteger);
                                                possible = 0;
                                            }
                                            var editedEndYear = int.Parse(editingEndYear);
                                            possible++;

                                            Console.WriteLine("Unesite mjesec završavanja eventa");
                                            int integerHelp;
                                            var editingEndMonth = Console.ReadLine();
                                            bool checkEndMonth = Int32.TryParse(editingEndMonth, out integerHelp);
                                            while (!checkEndMonth)
                                            {
                                                Console.WriteLine("Molimo upišite mjesec BROJEM: ");
                                                editingEndMonth = Console.ReadLine();
                                                checkEndMonth = Int32.TryParse(editingEndMonth, out integerHelp);
                                                possible = 0;
                                            }
                                            var editedEndMonth = int.Parse(editingEndMonth);
                                            possible++;

                                            Console.WriteLine("Unesite dan završavanja eventa");
                                            int integerSome;
                                            var editingEndDay = Console.ReadLine();
                                            bool checkEndDay = Int32.TryParse(editingEndDay, out integerSome);
                                            while (!checkEndDay)
                                            {
                                                Console.WriteLine("Molimo upišite dan BROJEM: ");
                                                editingEndDay = Console.ReadLine();
                                                checkEndDay = Int32.TryParse(editingEndDay, out integerSome);
                                                possible = 0;
                                            }
                                            var editedEndDay = int.Parse(editingEndDay);
                                            possible++;

                                            Console.WriteLine("Unesite puni sat završavanja eventa");
                                            int someHelpInteger;
                                            var editingEndHour = Console.ReadLine();
                                            bool checkEndHour = Int32.TryParse(editingEndHour, out someHelpInteger);
                                            while (!checkEndHour)
                                            {
                                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                                editingEndHour = Console.ReadLine();
                                                checkEndHour = Int32.TryParse(editingEndHour, out someHelpInteger);
                                                possible = 0;
                                            }
                                            var editedEndHour = int.Parse(editingEndHour);
                                            possible++;

                                            Console.WriteLine("Unesite minute završavanja eventa");
                                            int helpSomeInteger;
                                            var editingEndMinutes = Console.ReadLine();
                                            bool checkEndMinutes = Int32.TryParse(editingEndMinutes, out helpSomeInteger);
                                            while (!checkEndMinutes)
                                            {
                                                Console.WriteLine("Molimo upišite puni sat BROJEM: ");
                                                editingEndMinutes = Console.ReadLine();
                                                checkEndMinutes = Int32.TryParse(editingEndMinutes, out helpSomeInteger);
                                                possible = 0;
                                            }
                                            var editedEndMinutes = int.Parse(editingEndMinutes);
                                            var editedEndSeconds = 00;
                                            possible++;

                                            rememberingValue.EndDateTime = new DateTime(editedEndYear, editedEndMonth, editedEndDay, editedEndHour, editedEndMinutes, editedEndSeconds);

                                            if (rememberingValue.EndDateTime < rememberingValue.StartDateTime)
                                            {
                                                possible = 0;
                                                Console.WriteLine("Event ne može završiti prije no što počne. Molimo unesite ponovno vrijeme završavanja eventa.");
                                            }
                                            else
                                            {
                                                possible++;
                                            }
                                        }
                                        var x = 0;
                                        foreach (var pair in dictionary)
                                        {
                                            if ((rememberingValue.EndDateTime > pair.Key.StartDateTime) && (rememberingValue.EndDateTime < pair.Key.EndDateTime))
                                            {
                                                x = 0;
                                            }
                                            else
                                            {
                                                x++;
                                            }
                                        }
                                        foreach (var pair in dictionary)
                                        {
                                            if ((rememberingValue.StartDateTime < pair.Key.StartDateTime) && (rememberingValue.EndDateTime > pair.Key.EndDateTime))
                                            {
                                                x = 0;
                                            }
                                            else
                                            {
                                                x++;
                                            }
                                        }
                                        if (x != dictionary.Count * 2)
                                        {
                                            Console.WriteLine("Uređeni event se vremenom poklapa s već postojećim eventom. Molimo ponovno uredite event.");
                                            editChoice = EditingEvent();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Event uspješno promijenjen.");
                                            editChoice = 0;
                                        }
                                        break;
                                    case 5:
                                        editChoice = 999;
                                        break;
                                    default:
                                        Console.WriteLine("Odabrani broj ne postoji u izborniku.");
                                        editChoice = EditingEvent();
                                        break;
                                }
                                if (editChoice == 999)
                                {
                                    break;
                                }
                                editChoice = EditingEvent();
                                if (editChoice == 5)
                                {
                                    break;
                                }
                            }
                            mainVariable = Decision();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Odabrali ste dodavanje osobe na event");
                        Console.WriteLine("Unesite ime osobe koju želite dodati (first name)");
                        var addFirstName = Console.ReadLine();
                        bool validName = addFirstName.Equals("", StringComparison.OrdinalIgnoreCase);
                        while (validName)
                        {
                            Console.WriteLine("Niste unijeli ime. Molimo vas unesite ime osobe.");
                            addFirstName = Console.ReadLine();
                            validName = addFirstName.Equals("", StringComparison.OrdinalIgnoreCase);
                        }
                        var addedFirstName = addFirstName;
                        Console.WriteLine("Unesite prezime osobe koju želite dodati. (last name)");
                        var addLastName = Console.ReadLine();
                        bool validLastName = addLastName.Equals("", StringComparison.OrdinalIgnoreCase);
                        while (validLastName)
                        {
                            Console.WriteLine("Niste unijeli prezime. Molimo vas unesite prezimeime osobe.");
                            addLastName = Console.ReadLine();
                            validLastName = addLastName.Equals("", StringComparison.OrdinalIgnoreCase);
                        }
                        var addedLastName = addLastName;
                        Console.WriteLine("Unesite OIB osobe koju želite dodati");
                        var aprove = 0;
                        var addedOIB = 0;
                        while (aprove < 2)
                        {
                            int someIntegerValue;
                            var addOIB = Console.ReadLine();
                            bool conversionToOib = Int32.TryParse(addOIB, out someIntegerValue);
                            while (!conversionToOib)
                            {
                                Console.WriteLine("Molimo upišite OIB BROJEM: ");
                                addOIB = Console.ReadLine();
                                conversionToOib = Int32.TryParse(addOIB, out someIntegerValue);
                                aprove = 0;
                            }
                            var addingOIB = int.Parse(addOIB);
                            aprove++;
                            var helpAprove = 0;
                            var countPeople = 0;
                            foreach (var pair in dictionary)
                            {
                                for (var i = 0; i < pair.Value.Count; i++)
                                {
                                    if (pair.Value[i].OIB == addingOIB)
                                    {
                                        helpAprove = 0;
                                    }
                                    else
                                    {
                                        helpAprove++;
                                    }
                                    countPeople++;
                                }
                            }
                            if (helpAprove == countPeople)
                            {
                                aprove++;
                            }
                            else
                            {
                                aprove = 0;
                                Console.WriteLine("Već postoji osoba s ovim OIB-om. Molimo unesite novi OIB.");
                            }
                            addedOIB = addingOIB;
                            if (aprove == 2)
                            {
                                break;
                            }
                        }
                        var finalAddedOIB = addedOIB;
                        Console.WriteLine("Upišite broj mobitela osobe koju želite dodati");
                        var addPhoneNumber = Console.ReadLine();
                        int some;
                        bool checkingPhone = Int32.TryParse(addPhoneNumber, out some);
                        while (!checkingPhone)
                        {
                            Console.WriteLine("Molimo upišite broj mobitela BROJEM: ");
                            addPhoneNumber = Console.ReadLine();
                            checkingPhone = Int32.TryParse(addPhoneNumber, out some);
                        }
                        var addedPhoneNumber = addPhoneNumber;
                        Console.WriteLine("Upišite ime eventa na koji želite dodati osobu");
                        var chooseEvent = Console.ReadLine();
                        var control = 0;
                        while (control < 1)
                        {
                            foreach (var pair in dictionary)
                            {
                                bool findingEvent = pair.Key.Name.Equals(chooseEvent, StringComparison.OrdinalIgnoreCase);
                                while (!findingEvent)
                                {
                                    Console.WriteLine("Event nije pronađen. Molimo pokušajte ponovno");
                                    chooseEvent = Console.ReadLine();
                                    findingEvent = pair.Key.Name.Equals(chooseEvent, StringComparison.OrdinalIgnoreCase);
                                    control = 0;
                                }
                            }
                            control++;
                        }
                        var choosenEvent = chooseEvent;
                        var saveValue = new Event("", Event.DecidingEventType.NoExistingType, new DateTime(1000, 1, 1, 1, 1, 00), new DateTime(1000, 1, 1, 1, 1, 01))
                        foreach (var pair in dictionary)
                        {
                            bool findEvent = pair.Key.Name.Equals(choosenEvent, StringComparison.OrdinalIgnoreCase);
                            if (findEvent)
                            {
                                saveValue = pair.Key;
                            }
                        }
                        dictionary[saveValue].Add(new Person(addedFirstName, addedLastName, finalAddedOIB, addedPhoneNumber));
                        Console.WriteLine("Osoba dodana u odabrani event");
                        break;
                    case 5:
                        Console.WriteLine("Upišite ime eventa s kojeg želite ukloniti osobu");
                        var searchEvent = Console.ReadLine();
                        var savingValue = new Event("", Event.DecidingEventType.NoExistingType, new DateTime(2020, 12, 5, 9, 20, 00), new DateTime(2020, 12, 5, 9, 30, 00));
                        var someVariable = 0;
                        foreach (var pair in dictionary)
                        {
                            bool searchingEvent = pair.Key.Name.Equals(searchEvent, StringComparison.OrdinalIgnoreCase);
                            if (searchingEvent)
                            {
                                savingValue = pair.Key;
                                someVariable = 0;
                            }
                            else
                            {
                                someVariable++;
                            }
                        }
                        if (someVariable == dictionary.Count)
                        {
                            Console.WriteLine("Event nije pronađen");
                        }
                        else
                        {
                            Console.WriteLine("Unesite OIB osobe koju želite ukloniti s eventa");
                            var removeOIB = Console.ReadLine();
                            int integerValue;
                            bool checkingValidOIB = Int32.TryParse(removeOIB, out integerValue);
                            if (!checkingValidOIB)
                            {
                                Console.WriteLine("Molimo unesite OIB BROJEM");
                                removeOIB = Console.ReadLine();
                                checkingValidOIB = Int32.TryParse(removeOIB, out integerValue);
                            }
                            var removedOIB = removeOIB;
                            var deletePerson = 0;
                            var countHelp = 0;
                            for (var i = 0, i< dictionary[savingValue].Count , i++)
                            {
                                if (dictionary[savingValue][i].OIB == removedOIB)
                                {
                                    deletePerson = i;
                                    countHelp = 0;
                                }
                                else
                                {
                                    countHelp++;
                                }
                            }
                            if (countHelp == dictionary[savingValue].Count)
                            {
                                Console.WriteLine("Osoba nije pronađena u odabranom eventu");
                            }
                            else
                            {
                                dictionary[savingValue].RemoveAt(deletePerson);
                                Console.WriteLine("Osoba uspješno uklonjena iz eventa");
                            }
                        }
                        
                        break;
                    case 6:
                        var branchVariable = AdditionalMenu();
                        while (branchVariable != 0)
                        {
                            switch (branchVariable)
                            {
                                case 1:
                                    Console.WriteLine("Odaberite ime eventa čije detalje želite vidjeti");
                                    var detail = Console.ReadLine();
                                    foreach(var pair in dictionary)
                                    {
                                        bool equal = pair.Key.Name.Equals(detail, StringComparison.OrdinalIgnoreCase);
                                        if (equal)
                                        {
                                            Console.WriteLine(pair.Key.Name + " - " + pair.Key.EventType + " - " + pair.Key.StartDateTime + " - " + pair.Key.EndDateTime + " - " + (pair.Key.EndDateTime - pair.Key.StartDateTime) + " - " + pair.Value.Count);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Event nije pronađen");
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Odaberite ime eventa čije uzvanike želite vidjeti");
                                    var guests = Console.ReadLine();
                                    foreach (var pair in dictionary)
                                    {
                                        bool equality = pair.Key.Name.Equals(guests, StringComparison.OrdinalIgnoreCase);
                                        if (equality)
                                        {
                                            for ( var i=1; i < pair.Value.Count+1; i++)
                                            {
                                                Console.WriteLine($"{i} - {pair.Value[i].FirstName} - {pair.Value[i].LastName} - {pair.Value[i].PhoneNumber}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Event nije pronađen");
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Odaberite ime eventa čije detalje i popis uzvanika želite vidjeti");
                                    var details = Console.ReadLine();
                                    foreach (var pair in dictionary)
                                    {
                                        bool equals = pair.Key.Name.Equals(details, StringComparison.OrdinalIgnoreCase);
                                        if (equals)
                                        {
                                            Console.WriteLine(pair.Key.Name + " - " + pair.Key.EventType + " - " + pair.Key.StartDateTime +" - " + pair.Key.EndDateTime + " - " + (pair.Key.EndDateTime - pair.Key.StartDateTime) + " - " + pair.Value.Count);
                                            for (var i = 1; i < pair.Value.Count + 1; i++)
                                            {
                                                Console.WriteLine($"{i} - {pair.Value[i].FirstName} - {pair.Value[i].LastName} - {pair.Value[i].PhoneNumber}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Event nije pronađen");
                                        }
                                    }
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

        static int EditingEvent()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Odaberite stavku eventa koju želite urediti");
            Console.WriteLine("1 - Urediti ime eventa");
            Console.WriteLine("2 - Urediti tip eventa");
            Console.WriteLine("3 - Urediti vrijeme početka eventa");
            Console.WriteLine("4 - Urediti vrijeme kraja eventa");
            Console.WriteLine("5 - Povratak na glavni izbornik");
            int someNumberValue;
            var choiceOfEditAction = Console.ReadLine();
            bool conversion = Int32.TryParse(choiceOfEditAction, out someNumberValue);
            while (!conversion)
            {
                Console.WriteLine("Molimo upišite BROJ akcije koju želite odabrati: ");
                choiceOfEditAction = Console.ReadLine();
                conversion = Int32.TryParse(choiceOfEditAction, out int someNumberVaue);
            }
            var finalChoiceOfEditAction = int.Parse(choiceOfEditAction);

            return finalChoiceOfEditAction;

        }
    }

}




