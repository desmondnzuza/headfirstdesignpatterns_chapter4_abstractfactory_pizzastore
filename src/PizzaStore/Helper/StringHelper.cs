using System.Linq;

namespace PizzaStore.Helper
{
    public static class StringHelper
    {
        public static bool IsValidAnswer(this string answer)
        {
            var supportedAnswers = new []{"Cheese", "Greek", "Pepperoni", "Clam", "Veggie"};
            return supportedAnswers.Contains(answer);
        }

        public static bool IsValidAnswer(this SupportedStoreEnum answer)
        {
            return answer != SupportedStoreEnum.UnKnown;
        }
    }
}
