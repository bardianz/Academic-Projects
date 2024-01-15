using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExercise
{
    class Queue
    {
        int front, rear,size;
        int[] array;
        

        public Queue(int size)
        {
            array = new int[size];
            front = -1;
            rear = -1;
            this.size = size;
        }

        public void add(int num)
        {
            if (isFull())
            {
                // do nothing
            }
            else
            {
                array[++rear] = num;
            }
        }

        public void delete()
        {
            if (isEmpty())
            {
                // do nothing
            }
            else
            {
                array[++front] = 0; //null
            }
        }

        private bool isFull()
        {
            if (rear == size - 1)
                return true;
            else return false;
        }

        private bool isEmpty()
        {
            if (rear == front)
                return true;
            else return false;
        }
    }
}
