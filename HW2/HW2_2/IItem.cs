using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{

    //Так как каждое из устанавливаемых свойств в данном примере может относиться к разным товарам,
    //причем нельзя указать жесткую зависимость между двумя свойствами (кроме цены, поэтому её вынесем, в интерфейс, от которого будем наследовать другие), 
    //имеет смысл выделить каждый метод установки значения в отдельный интерфейс.
    interface IItem
    {
        void SetPrice(double price);
    }

    interface IColorableItem : IItem
    {
        void SetColor(Color color);
    }

    interface ISizableItem : IItem
    {
        void SetSize(Size size);
    }

    interface IPromoItem : IItem
    {
        void SetPromocode(string promocode);
    }
    interface IDiscountableItem : IItem
    {
        void SetDiscount(double discount);
    }
}
