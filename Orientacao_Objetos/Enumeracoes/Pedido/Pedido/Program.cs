using Pedido.Entities;
using Pedido.Entities.Enums;
using System;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString(); // convertendo orderstatus para texto;          
                  
            ///OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // string para enumerado
            // Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
