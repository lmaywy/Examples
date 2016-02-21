
namespace Examples.Algorithm.StringRelated
{
    public class NumToString
    {
        public static string ToString(int num)
        {
            var i = 10;
            var ret = string.Empty;
            do
            {
                ret = num % i + ret;
                num = num / i;
            } while (num > 0);

            return ret;
        }
    }
}
