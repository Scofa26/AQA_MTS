using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MessengerService<T, P>
         where T : Message
    where P : SimplePerson
    {
        public void SendMessage(P sender, P receiver, T message)
        {
            Console.WriteLine($"Отправитель: {sender.Name}");
            Console.WriteLine($"Получатель: {receiver.Name}");
            Console.WriteLine($"Сообщение: {message.Text}");
        }
    }
}
