namespace L2Net.PacketConverter.Core
{
    public static class StringExtensions
    {
        public static string NormalizeString(this string s)
        {
            return s.Replace("-", " ");
        }

        public static string RemoveSeparators(this string s)
        {
            return s.Replace(" ", string.Empty).Replace("-", string.Empty);
        }
    }
}
