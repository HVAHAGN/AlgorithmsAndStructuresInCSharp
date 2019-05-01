using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DoublyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Двусвязные списки также представляют последовательность связанных узлов, однако теперь каждый 
             * узел хранит ссылку на следующий и на предыдущий элементы. Но в то же время у нас появляется 
             * возможность обходить список как от первого к последнему элементу, так и наоборот - от последнего к первому элементу*/
            DoublyLinkedList_<string> linkedList = new DoublyLinkedList_<string>();
            // добавление элементов 
            linkedList.Add("Armen");
            linkedList.Add("Karen");
            linkedList.Add("Vahan");
            linkedList.Add("Babken");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.Remove("Karen");

            Console.WriteLine("After removing Karen");
            // перебор с последнего элемента
            foreach (var t in linkedList.BackEnumerator())
            {
                Console.WriteLine(t);

            }



            Console.ReadLine();
        }
    }
    //Для создания двусвязного списка вначале надо определить класс узла, который будет представлять элемент списка:
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;

        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
}
