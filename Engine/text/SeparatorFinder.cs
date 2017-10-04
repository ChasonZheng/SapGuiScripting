namespace Engine.actions.removeTextBlockAction {

    public interface SeparatorFinder {
        int GetIndex(string text);
        int GetIndex(string text, int fromIndex);
    }

}
