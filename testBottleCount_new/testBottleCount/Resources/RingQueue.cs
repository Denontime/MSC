using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlePickModuleForWindows.Resources
{

    public class RingQueue<T> : IDisposable
    {

        private T[] queue;
        private int length;
        private int capacity;
        private int head = 0;
        private int tail = 0;

        public RingQueue(int capacity)
        {
            this.capacity = capacity;
            this.head = 0;
            this.tail = 0;
            this.length = 0;
            this.queue = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index > capacity - 1)
                {
                    return this.queue[index % capacity];
                }
                else
                {
                    return this.queue[index];
                }
            }
        }

        public void Clear()
        {
            this.queue = null;
            this.queue = new T[capacity];
            this.head = 0;
            this.tail = 0;
            this.length = 0;
        }

        public bool IsEmpty()
        {
            return this.length == 0;
        }

        public bool IsFull()
        {
            return this.length == this.capacity;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetHeaderPos()
        {
            return this.head;
        }

        public bool EnQueue(T item)
        {
            if (!IsFull())
            {
                this.queue[tail] = item;
                this.tail = (++this.tail) % this.capacity;
                this.length++;
                return true;
            }
            return false;
        }

        public T FirstOrDefault()
        {
            return this.queue[head];
        }

        public T DeQueue()
        {
            T item = default(T);
            if (!IsEmpty())
            {
                item = this.queue[head];
                this.queue[head] = default(T);
                head = (++this.head) % this.capacity;
                this.length--;
            }
            return item;
        }


        public void Dispose()
        {
            queue = null;
        }
    }

}
