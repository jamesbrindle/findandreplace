using System.Collections.Generic;

namespace FindAndReplace
{
    public class MatchPreviewLineNumber
    {
        public int LineNumber { get; set; }

        public bool HasMatch { get; set; }
    }

    public class LineNumberComparer : IEqualityComparer<MatchPreviewLineNumber>
    {
        public bool Equals(MatchPreviewLineNumber x, MatchPreviewLineNumber y)
        {
            return x.LineNumber == y.LineNumber;
        }

        public int GetHashCode(MatchPreviewLineNumber obj)
        {
            return obj.LineNumber.GetHashCode();
        }
    }
}
