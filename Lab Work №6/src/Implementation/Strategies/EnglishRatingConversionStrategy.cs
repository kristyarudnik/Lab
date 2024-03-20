using Lab4.Interfaces;

namespace Lab4.Implementation.Strategies
{
    public class EnglishRatingConversionStrategy : IRatingConversionStrategy
    {
        public string ConvertRating(double rating)
        {
            return $"Rating: {rating.ToString("0.0")} out of 5";
        }
    }
}
