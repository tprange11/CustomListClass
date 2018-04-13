using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomListClass
{
    public class MyList<T> : IEnumerable<T>
    {
        // member variables
        T[] genericArray;
        public int count = 0;
        public int capacity;
        //Properties
        public T this[int index]
        {
            get
            {
                return genericArray[index];
            }
            set
            {
                genericArray[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }



        // constructor
        public MyList()
        {
            this.capacity = 5;
            this.genericArray = new T[capacity];

        }
        // member methods
        public void Add(T data)
        {
            if (CheckArrayCapacity())
            {
                var tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = genericArray[i];
                }
                tempArray[count] = data;
                genericArray = tempArray;
            }
            else
            {
                genericArray[count] = data;
            }
            count++;
        }
        private void MoveElementsForward(int index)
        {
            int i;
            for (i = index; i < count - 1; i++)
            {
                genericArray[i] = genericArray[i + 1];
            }
            genericArray[i] = default(T);
        }

        public bool Remove(T data)
        {
            bool result = false;
            for (int i = 0; i < count; i++)
            {
                if (data.Equals(genericArray[i]))
                {
                    MoveElementsForward(i);
                    count--;
                    if (result == false)
                    {
                        result = true;
                    }
                    break;
                }
            }
            return result;
        }

        public static MyList<T> operator +(MyList<T> myList1, MyList<T> myList2)
        {
            MyList<T> tempList = new MyList<T>();
            for (int i = 0; i < myList1.count; i++)
            {
                tempList.Add(myList1[i]);
            }
            for (int j = 0; j < myList2.count; j++)
            {
                tempList.Add(myList2[j]);
            }
            tempList.count = myList1.count + myList2.count;
            return tempList;
        }

        public static MyList<T> operator -(MyList<T> myList1, MyList<T> myList2)
        {
            MyList<T> tempList = myList1;
            for (int i = 0; i < myList2.count; i++)
            {
                tempList.Remove(myList2.ElementAt(i));
            }
            return tempList;
        }
        public MyList<T> Zip(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> zippedList = new MyList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                zippedList.Add(list1[i]);
                zippedList.Add(list2[i]);
            }
            return zippedList;
        }
        public override string ToString()
        {
            string newString = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(genericArray[i]);
            }
            newString = sb.ToString();
            return newString;
        }


        private bool CheckArrayCapacity()
        {
            if (capacity / 2 <= count)
            {
                DoubleArrayCapacity();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DoubleArrayCapacity()
        {
            capacity += capacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int x = 0; x <= genericArray.Length; x++)
            {
                yield return genericArray[x];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
