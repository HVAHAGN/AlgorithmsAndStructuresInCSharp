using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Связный список(Linked List) представляет набор связанных узлов, каждый из которых хранит собственно данные и             
            ссылку на следующий узел.Таким образом, если в массиве положение элементов определяется индексами, то в связном списке - 
            указателями на следующий и (или) на предыдущий элемент.Связные списки могут различаться. Есть односвязные списки, в которых
            каждый узел хранит указатель только на следующий узел. Есть двусвязные списки: в них каждый элемент хранит ссылку как на 
            следующий элемент, так и на предыдущий. Есть кольцевые замкнутые списки.*/

            LinkedList<string> linkedList = new LinkedList<string>();
            // добавление элементов
            linkedList.Add("Armen");
            linkedList.Add("Sona");
            linkedList.Add("Vardan");
            linkedList.Add("Annman");
            linkedList.Add("Sam");

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item + " ");
            }
            // удаляем элемент
            Console.WriteLine("List after removing Annman");
            linkedList.Remove("Annman");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }


            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent == true? "Sam exist in list": "Sam does not exist in our list");

            // добавляем элемент в начало
            linkedList.AppendFirst("Vahagn");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }

        /*Класс Node является обобщенным, поэтому может хранить данные любого типа. Для хранения данных предназначено свойство Data. 
         Для ссылки на следующий узел определено свойство Next*/
        
    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;

        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}





