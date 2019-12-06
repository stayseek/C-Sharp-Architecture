namespace HW8.Models
{
    public interface IModelObserver
    {
        void DataUpdated(IModel model, ModelEventArgs args);
    }
}
