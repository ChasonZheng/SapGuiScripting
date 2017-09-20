namespace Engine.text {

    public class RemoveTextBlock : TextTransform {
        public string Transform(string text) {
            return text.Substring(0, text.LastIndexOf("_"));
        }
    }

}
