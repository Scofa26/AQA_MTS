using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ArrayList
{
    internal class Books_Actions
    {
        ArrayList books = new ArrayList();
        public void Add(string name, string fio, int year) { 

            Book bookForAdd = new Book(name, fio, year);

            try 
            { 
                books.Add(bookForAdd);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");  
            }   
           
        } 
        

    }
}
