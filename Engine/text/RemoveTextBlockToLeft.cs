using System.Collections.Generic;
using System.Linq;

namespace Engine.text {

    public enum Direction {
        LEFT, RIGHT
    };

    public class RemoveTextBlockToLeft {

        private readonly char[] separators;

        public RemoveTextBlockToLeft(char[] separators) {
            this.separators = separators;
        }

        public RemoveTextBlockToLeft(List<char> separators)
            : this(separators.ToArray()) { }

        public RemoveTextBlockToLeft(char separator)
            : this(new char[] { separator }) { }


        public string Remove(string text) {
            return Remove(text, text.Length - 1);
        }

        public string Remove(string text, int startIndex) {
            int index = GetIndex(text, startIndex);
            if (index < 0) {
                return text;
            }
            return text.Substring(0, index + 1);
        }

        private int GetIndex(string text, int startIndex) {
            int index = text.LastIndexOfAny(separators, startIndex);
            if (index < 0) return -1;
            if (separators.Contains(text[startIndex])) {
                index--;
            }
            return index;
        }
    }

}
