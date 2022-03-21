using System.Text.RegularExpressions;

namespace Task3_3_2
{
    public static class MyExtensions
    {
        static bool IsContainRussian(string text)
        {
            return Regex.IsMatch(text, "[а-яА-ЯёЁ]");
        }

        static bool IsContainEnglish(string text)
        {
            return Regex.IsMatch(text, "[a-zA-Z]");
        }

        static bool IsContainNumber(string text)
        {
            return Regex.IsMatch(text, "[0-9]");
        }

        static bool IsContainSpecialSymbol(string text)
        {
            return Regex.IsMatch(text, @"\s|\t|[^а-яА-ЯёЁ\w]|_");
        }

        public static bool IsRussian(this string text)
        {
            if (IsContainEnglish(text) || IsContainNumber(text) || IsContainSpecialSymbol(text))
            {
                return false;
            }

            return Regex.IsMatch(text, "[а-яА-ЯеЁ]");
        }

        public static bool IsEnglish(this string text)
        {
            if (IsContainRussian(text) || IsContainNumber(text) || IsContainSpecialSymbol(text))
            {
                return false;
            }

            return Regex.IsMatch(text, "[a-zA-Z]");
        }

        public static bool IsNumber(this string text)
        {
            if (IsContainEnglish(text) || IsContainRussian(text) || IsContainSpecialSymbol(text))
            {
                return false;
            }

            return Regex.IsMatch(text, "[0-9]");
        }

        public static bool IsMixed(this string text)
        {
            if (IsContainSpecialSymbol(text))
            {
                return true;
            }

            int countedStyles = 0;
            if (IsContainRussian(text))
            {
                countedStyles += 1;
            }

            if (IsContainEnglish(text))
            {
                countedStyles += 1;
            }

            if (IsContainNumber(text))
            {
                countedStyles += 1;
            }

            return countedStyles >= 2;
        }
    }
}
