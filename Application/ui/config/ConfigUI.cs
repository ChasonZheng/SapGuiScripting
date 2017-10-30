namespace Application.ui.config {

    public class ConfigUI {

        private readonly ConfigForm form = new ConfigForm();

        public void Show() {
            form.ShowDialog();
        }


    }
}
