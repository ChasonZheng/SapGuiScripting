using Engine.actions.removeTextBlockAction;
using System.Collections.Generic;

namespace Engine.text {
    public class SeparatorFinderToLeft : SeparatorFinder {

        private readonly char[] separators;

        public SeparatorFinderToLeft(char[] separators) {
            this.separators = separators;
        }

        public SeparatorFinderToLeft(List<char> separators)
            : this(separators.ToArray()) { }

        public SeparatorFinderToLeft(char separator)
            : this(new char[] { separator }) { }


        public int GetIndex(string text) {
            return GetIndex(text, 0);
        }

        public int GetIndex(string text, int fromIndex) {
            int index = text.IndexOfAny(separators, fromIndex);
            if (index > 0) return index;
            return 0;
        }
    }
}
