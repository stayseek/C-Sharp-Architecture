using HW8.Views;

namespace HW8.Controllers
{
    public interface IController
    {
        void ViewChanged(IView view, ViewEventArgs args);
    }
}
