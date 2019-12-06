using System.Collections.Generic;

namespace HW8.Models
{
    public class ListModel : IModel
    {
        public event ModelHandler<ListModel> DataChanged;

        private List<string> strings;
        public ListModel()
        {
            strings = new List<string>();
        }

        public void AddString(string data)
        {
            strings.Add(data);
            DataChanged.Invoke(this, new ModelEventArgs(data));
        }

        public void AddObserver(IModelObserver observer) 
        { 
            DataChanged += new ModelHandler<ListModel>(observer.DataUpdated); 
        }
    }
}
