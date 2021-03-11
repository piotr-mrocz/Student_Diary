using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<double>();
        }


        // List - klasa wbudowana dostarczająca metody do wyszukiwania, sortowania, modyfikowania. 
        // Przechowuje listę ocen ucznia.
        List<double> ratings;

        public int quantity = 0;

        // Metoda dodawająca oceny do listy:
        public void AddRating(double rating)
        {
            ratings.Add(rating);
            quantity = ratings.Count();
        }

        // Metoda obliczająca średnią z ocen ucznia:
        public double CalculateAverage()
        {
            double sum = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            double avg = sum / ratings.Count();

            return avg;
        }


        // Metoda zwracająca największą ocenę:
        public double GiveMaxRating()
        {
            return ratings.Max();
        }

        // Metoda zwracająca najmniejszą ocenę:
        public double GiveMinRating()
        {
            return ratings.Min();
        }

    }
}