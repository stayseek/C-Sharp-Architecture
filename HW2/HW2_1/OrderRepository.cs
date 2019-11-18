using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    class OrderRepository
    {
        //Я посчитал, что в данном случае 
        //(одновременное существование нескольких механизмов доступа к данным, с одновременным доступом только к одному из них) 
        //уместно будет использовать внедрение через свойство.
        //Для каждого из механизмов необходимо будет создать отдельный класс, реализующий интерфейс IRepository.

        //Для случая использования только одного механизма в ходе работы с программой имеет смысл реализовывать внедрение через конструктор.
        //Для случая, когда механизмы будут использоваться параллельно - через метод.
        private IRepository _repository;
        public void SetRepository(IRepository repository)
        {
            _repository = repository;
        }
        public Order Load(int orderId) 
        { 
            return _repository.Load(orderId); 
        }
        public void Save(Order order) 
        {
            _repository.Save(order);
        }
        public void Update(Order order) 
        {
            _repository.Update(order);
        }
        public void Delete(Order order) 
        {
            _repository.Delete(order);
        }
    }
}
