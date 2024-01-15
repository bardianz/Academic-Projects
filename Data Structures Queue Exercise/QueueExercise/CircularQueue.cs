using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExercise
{
    class CircularQueue
    {
        int front, rear, size;
        int[] array;
        string message;

        public CircularQueue(int size)
        {
            array = new int[size];
            front = -1;
            rear = -1;
            this.size = size;
        }
        public float average_of_negative_numbers()
        {
            float sum = 0;
            int count = 0;
            if (isEmpty())
            {
                message = "the queue is empty";
                return 0;
            }
            int j = 0;
            for (int i = front; j < rear;)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                    count++;
                }
                i = (i+1) % size;
                j++;
            }
            return sum / count;
        }

        public void add(int num)
        {
            rear = (rear + 1) % size;
            if (isFull())
            {
                message = "the queue is full";
            }
            else
            {
                array[rear] = num;
            }
        }

        public void delete()
        {
            if (isEmpty())
            {
                message = "the queue is empty";
            }
            else
            {
                front = (front + 1) % size;
                array[front] = 0; //null
            }
        }

        private bool isFull()
        {
            if (rear == size)
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
