namespace HW8.Models
{
    public interface IModel
    {
        void AddObserver(IModelObserver observer);
        void AddString(string data);
    }
}
