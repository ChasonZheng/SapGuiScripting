namespace Engine.text {

    public class RemoveTextBlockToRight {

        private readonly TextBlockFinder finder;

        public RemoveTextBlockToRight(TextBlockFinder finder) {
            this.finder = finder;
        }

        public string Remove(string text, int fromIndex) {
            int index = finder.GetIndex(text, fromIndex);
            return text.Remove(fromIndex, index - fromIndex);
        }
    }

}
