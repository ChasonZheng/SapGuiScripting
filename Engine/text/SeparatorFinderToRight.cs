using Engine.actions.removeTextBlockAction;
using System.Collections.Generic;

namespace Engine.text {
    public class SeparatorFinderToRight : SeparatorFinder {

        private char[] separators;

        public SeparatorFinderToRight(char[] separators) {
            this.separators = separators;
        }

        public SeparatorFinderToRight(List<char> separators)
            : this(separators.ToArray()) { }

        public SeparatorFinderToRight(char separator)
            : this(new char[] { separator }) { }


        public int GetIndex(string text) {
            return GetIndex(text, 0);
        }

        public int GetIndex(string text, int fromIndex) {
            int index = text.LastIndexOfAny(separators, fromIndex);
            if (index > 0) return index;
            return 0;
        }
    }
}
