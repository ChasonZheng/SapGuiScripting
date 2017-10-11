using System.Collections.Generic;

namespace Engine.text {
    public class TextBlockFinderToLeft : TextBlockFinder {

        private readonly char[] separators;

        public TextBlockFinderToLeft(char[] separators) {
            this.separators = separators;
        }

        public TextBlockFinderToLeft(List<char> separators)
            : this(separators.ToArray()) { }

        public TextBlockFinderToLeft(char separator)
            : this(new char[] { separator }) { }


        public int GetIndex(string text, int fromIndex) {
            int originalLength = text.Length;
            if (fromIndex > text.Length) fromIndex = text.Length;
            text = text.Substring(0, fromIndex);
            int result = text.LastIndexOfAny(separators);
            if (result < 0) return result;
            if (result + 1 != text.Length) result++;
            return result;
        }
    }
}
