using Generics;
using System.Net.Mail;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        SimplePerson simplePerson = new SimplePerson(546, "Tom");
        ObjectPerson objectPerson = new ObjectPerson("abs", "Ben");

        int tomId = simplePerson.Id;
        string benId = objectPerson.Id.ToString();

        Console.WriteLine($"id1 = {tomId}");
        Console.WriteLine($"id1 = {benId}");

        ObjectPerson objectPerson1 = new ObjectPerson(123, "Bob"); // упаковка в значения int в тип Object
        int intBobId = (int)objectPerson1.Id; // Распаковка в тип int
                                              // string strBobId = (string)objectPerson1.Id;                  // Ошибка при выполнении

        // -=================== Generics ===================- 

        GenericPerson<int> intgenericPerson = new GenericPerson<int>(123, "SAle");
        GenericPerson<string> stringPerson = new GenericPerson<string>("", "");
        GenericPerson<Guid> guidPerson = new GenericPerson<Guid>(Guid.NewGuid(), "Alex");
        int intPerId = intgenericPerson.Id;
        intgenericPerson.Print();
        string stringID = stringPerson.Id;
        Company<GenericPerson<int>> mtsCompany = new Company<GenericPerson<int>>(intgenericPerson);
        Company<GenericPerson<string>> mtsCompany1 = new Company<GenericPerson<string>>(stringPerson);

        // -=================== Static
        // StaticPerson.code = 123; // Ошибка - отсутствует типизация
        StaticPerson<int>.code = 123;
        StaticPerson<string>.code = "- 123 -";

        Console.WriteLine(StaticPerson<int>.code);
        Console.WriteLine(StaticPerson<string>.code);

        int x = 19;
        int y = 15;
        Helper.Swap<int>(ref x, ref y);
        Helper.Swap(ref x, ref y);

        string x1 = "12";
        string y1 = "323";

        Helper.Swap(ref x1, ref y1);

        // -=================== Ограничения Generics ===================-
        // -=================== Ограничения методов
        Helper.SendMessage(new Message("Bye World"));
        Helper.SendMessage(new EmailMessage("This is email message "));
        Helper.SendMessage<SmsMessage>(new SmsMessage("This is email message "));

        // -=================== Ограничения обобщений в типах
        Messenger<Message> telegram = new Messenger<Message>();
        telegram.SendMessage(new Message("Hello World"));

        Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
        outlook.SendMessage(new EmailMessage("Bye World"));

        // -=================== Структуры 


        MessengerStruct<MessageStruct> messengerStruct = new MessengerStruct<MessageStruct>();
        // MessengerStruct<int> // Ошибка - int не struct
        // MessengerStruct<Message> // Ошибка - class не struct
        messengerStruct.SendMessage(new MessageStruct("Struct is cool for small objects..."));

        // -=================== Ограничения нескольких универсальных параметров
        SimplePerson sender = new SimplePerson(1, "Ted");
        SimplePerson receiver = new SimplePerson(3, "Fred");
        MessengerService<EmailMessage, SimplePerson> messengerService = new MessengerService<EmailMessage, SimplePerson>();
        messengerService.SendMessage(sender, receiver, new EmailMessage("Email..."));
    }
}