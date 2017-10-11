namespace Engine.text {

    public class RemoveTextBlockToLeft {

        private readonly TextBlockFinder finder;

        public RemoveTextBlockToLeft(TextBlockFinder finder) {
            this.finder = finder;
        }

        public string Remove(string text, int fromIndex) {
            int index = finder.GetIndex(text, fromIndex);
            if (index < 0) index++;
            // if (fromIndex - index == 1) {
            ////  }
            string result = text.Remove(index, fromIndex - index);
            return result;
        }
    }

}
