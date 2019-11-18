using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    //С учётом разделения интерфейсов класс будет представлен в следующем виде:
    class Clothes : ISizableItem, IColorableItem, IPromoItem, IDiscountableItem
    {
        public void SetColor(Color color) { }
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
    }
}
