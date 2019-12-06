using System;

namespace HW8.Models
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
    public class ModelEventArgs: EventArgs
    {
        public string NewValue;
        public ModelEventArgs(string value)
        {
            NewValue = value;
        }
    }
}
