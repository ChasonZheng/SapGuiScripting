namespace Engine.actions {
    public class ActionDecorator : Action{
        private readonly Action origin;

        public ActionDecorator(Action origin) {
            this.origin = origin;
        }
       
        public virtual void Execute(ActionContext context) {
            origin.Execute(context);
        }
    }
}