using HW8.Controllers;

namespace HW8.Views
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs args);
    public interface IView
    {
        event ViewHandler<IView> AddString;
        void SetController(IController controller);
    }
}
