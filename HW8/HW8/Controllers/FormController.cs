using HW8.Models;
using HW8.Views;

namespace HW8.Controllers
{
    public class FormController : IController
    {
        private IModel _model;
        private IView _view;

        public FormController(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.SetController(this);
            _model.AddObserver((IModelObserver)view);
            _view.AddString += new ViewHandler<IView>(this.ViewChanged);
        }
        public void ViewChanged(IView view, ViewEventArgs args) 
        { 
            _model.AddString(args.Value);
        }
    }
}
