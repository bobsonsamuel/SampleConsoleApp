
namespace SampleConsoleApp.ExtensionMethods
{
    static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsGreaterThan(this float i, int value)
        {
            return i > value;
        }
    }
}