using Lab4.Interfaces;

namespace Lab4.Implementation.Strategies
{
    public class RussianRatingConversionStrategy : IRatingConversionStrategy
    {
        public string ConvertRating(double rating)
        {
            return $"Рейтинг: {rating.ToString("0.0")} из 5";
        }
    }
}
