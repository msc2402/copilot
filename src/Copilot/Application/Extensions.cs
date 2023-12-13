namespace Copilot.Application
{
    public static class Extensions
    {
        public static DateTime? ToDateTime(this string dateString)
        {
            try
            {
                var year = int.Parse(dateString.Substring(0, 4));
                var month = int.Parse(dateString.Substring(4, 2));
                var day = int.Parse(dateString.Substring(6, 2));

                return new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                return new DateTime();
            }
        }
    }
}
