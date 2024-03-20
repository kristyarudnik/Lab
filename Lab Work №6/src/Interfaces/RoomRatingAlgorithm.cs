namespace Lab4.Interfaces
{
    public abstract class RoomRatingAlgorithm
    {
        // Шаблонный метод для оценки комнаты
        public void RateRoom()
        {
            Console.WriteLine("Rating process started.");
            double rating = CalculateRating();
            DisplayRating(rating);
            Console.WriteLine("Rating process completed.");
        }

        protected abstract double CalculateRating();

        protected virtual void DisplayRating(double rating)
        {
            Console.WriteLine($"Room rated with {rating} stars.");
        }
    }
}
