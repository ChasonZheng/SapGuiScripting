using System.Collections.Generic;

namespace Engine.text {
    public class TextBlockFinderToRight : TextBlockFinder {

        private char[] separators;

        public TextBlockFinderToRight(char[] separators) {
            this.separators = separators;
        }

        public TextBlockFinderToRight(List<char> separators)
            : this(separators.ToArray()) { }

        public TextBlockFinderToRight(char separator)
            : this(new char[] { separator }) { }


        public int GetIndex(string text, int fromIndex) {
            int originalLength = text.Length;
            if (fromIndex > text.Length) fromIndex = text.Length;
            text = text.Substring(fromIndex);
            int index = text.IndexOfAny(separators);
            if (index < 0) return originalLength;
            //Wenn direkt das erste Zeichen ein Separator war,
            //Muss der Zielindex um 1 nach rechts verschoben werden
            if (index == 0) index++;
            return (index > 0) ? index + fromIndex : text.Length;
        }
    }
}