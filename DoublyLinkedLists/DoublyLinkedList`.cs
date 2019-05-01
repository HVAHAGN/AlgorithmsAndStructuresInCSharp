using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DoublyLinkedLists
{
    public class DoublyLinkedList_<T>:IEnumerable<T>
    {
        DoublyNode<T> head; // головной/первый элемент
        DoublyNode<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            //В методе добавления Add(), если в списке уже есть элементы, то у добавляемого узла 
            //свойство Previous указывает на узел, который до этого хранился в переменной tail:
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            //Аналогично в методе AddFirst добавлении в начало списка для головного элемента свойство Previous начинает указывать 
            //на новый элемент, а новый элемент, таким образом, становиться первым элементом в списке.
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
             
        }

        public bool Remove(T data)
        {
            //При удалении вначале необходимо найти удаляемый элемент. Затем в общем случае надо переустановить две ссылки:
            DoublyNode<T> current = head;
            // поиск удаляемого узла
            while(current!=null)
            {
                if(current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.Next == null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.Previous;
                }
                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public int Count { get { return count; } }
        public bool isEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        //Интерфейс IEnumerable имеет метод, возвращающий ссылку на другой интерфейс - перечислитель:
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }


      /*  //А интерфейс IEnumerator определяет функционал для перебора внутренних объектов в контейнере:
        public interface IEnumerator
        {
            bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
            object Current { get; }  // текущий элемент в контейнере
            void Reset(); // перемещение в начало контейнера
        }
        */
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }
        //И также в отличие от односвязной реализации здесь добавлен метод BackEnumerator() для перебора элементов с конца.
        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }




    }
}
