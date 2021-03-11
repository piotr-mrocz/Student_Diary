using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Podaj numer klasy ucznia: ");
            person.grade = Console.ReadLine();

            Console.WriteLine("Podaj numer ucznia: ");
            while (!uint.TryParse(Console.ReadLine(), out person.id_ucznia))
            {
                Console.WriteLine("Nieprawidłowy format!");
                Console.WriteLine("Podaj numer ucznia: ");
            }

            Console.WriteLine("Podaj imię ucznia: ");
            person.name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko ucznia: ");
            person.surname = Console.ReadLine();

            Thread.Sleep(1000);
            Console.Clear();

            Diary diary = new Diary();

            bool loop = true;
            int choice;
            string answer;
            double rating;

            while (loop)
            {

                Console.WriteLine("     Dzienniczek ucznia: {0} {1}", person.name.ToUpperInvariant(), person.surname.ToUpperInvariant());
                Console.WriteLine("     Klasa: {0}   Numer w dzienniku: {1}", person.grade.ToUpperInvariant(), person.id_ucznia);
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("*        1 - Dodaj ocenę                                         *");
                Console.WriteLine("*        2 - Oblicz średnią                                      *");
                Console.WriteLine("*        3 - Zobacz największą ocenę                             *");
                Console.WriteLine("*        4 - Zobacz najmniejszą liczbę                           *");
                Console.WriteLine("*        5 - Wyjście                                             *");
                Console.WriteLine("******************************************************************");

                Console.WriteLine("Wybierz opcję: ");
                int.TryParse(Console.ReadLine(), out choice);


                // First option
                if (choice == 1)
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.Write("Wprowadź ocenę: ");
                        Console.WriteLine();
                        double.TryParse(Console.ReadLine(), out rating);

                        if (rating == 10)
                        {
                            Console.Clear();
                            break;
                        }


                        if (rating >= 0 && rating <= 6)
                        {
                            diary.AddRating(rating);
                        }

                        else
                        {
                            Console.WriteLine("Nieprawidłowy format!");
                            continue;
                        }

                    }
                }


                // Second option
                else if (choice == 2)
                {
                    if (diary.quantity == 0)
                    {
                        Console.WriteLine("Nie podałeś żadnych ocen. Nie mogę policzyć średniej.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Średnia ocen wynosi: {0}", diary.CalculateAverage());
                        Thread.Sleep(1500);
                        Console.Clear();
                    }
                }


                //Third option
                else if (choice == 3)
                {
                    Console.WriteLine("Największa z ocen: {0}", diary.GiveMaxRating());
                    Thread.Sleep(1500);
                    Console.Clear();
                }


                //Fourth option
                else if (choice == 4)
                {
                    Console.WriteLine("Najmniejsza z ocen: {0}", diary.GiveMinRating());
                    Thread.Sleep(1500);
                    Console.Clear();
                }


                //Last option
                else if (choice == 5)
                {
                    Console.WriteLine("Czy na pewno chcesz wyjść? tak/nie");
                    answer = Console.ReadLine();

                    if (answer.Equals("tak") || answer.Equals("TAK") || answer.Equals("Tak") || answer.Equals("T") || answer.Equals("t"))
                    {
                        loop = false;
                    }

                    else if (answer.Equals("nie") || answer.Equals("NIE") || answer.Equals("Nie") || answer.Equals("N") || answer.Equals("n"))
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Nieprawidłowy wybór!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }

                else
                {
                    Console.WriteLine("Nieprawidłowy wybór!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
    }
}
