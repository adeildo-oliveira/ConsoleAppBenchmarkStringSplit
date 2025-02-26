namespace ConsoleAppBenchmarkStringSplit
{
    public class ExtractWithSplit
    {
        public static string SplitWithSpan(string request)
        {
            if (string.IsNullOrEmpty(request))
                return string.Empty;

            var originalSpan = request.AsSpan();
            var segments = originalSpan.Split('_').GetEnumerator();

            segments.MoveNext();
            var first = originalSpan[segments.Current];

            segments.MoveNext();
            var second = originalSpan[segments.Current];

            return first.ToString();
        }

        public static string SplitWithString(string request)
        {
            if (string.IsNullOrEmpty(request))
                return string.Empty;

            return request.Split('_').FirstOrDefault()!;
        }
    }
}
