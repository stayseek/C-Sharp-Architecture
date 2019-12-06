using System;
using System.Windows.Forms;
using HW8.Views;
using HW8.Controllers;
using HW8.Models;

namespace HW8
{
    public partial class MVCForm : Form, IView, IModelObserver
    {
        private IController _controller;

        public MVCForm()
        {
            InitializeComponent();
        }

        public event ViewHandler<IView> AddString;

        public void DataUpdated(IModel model, ModelEventArgs args)
        {
           listBox.Items.Add(args.NewValue);
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }

        private void MVCForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddString.Invoke(this, new ViewEventArgs(textBox.Text));
            }
            catch
            {
                MessageBox.Show("Поле для ввода не должно быть пустым.", "Заполните поле.");
            }
        }
    }
}
