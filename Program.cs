using System;

namespace DynamicArray
{
    internal class Program
    {
        class Da<T>
        {
            T[] arr;
            int lastIndex;

            public Da(int size)
            {
                if (size > 0)
                {
                    arr = new T[size];
                }
                else
                {
                    arr = new T[1];
                }
                lastIndex = -1;
            }

            public T this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }

            public void expandStorage()
            {
                T[] arr2 = new T[arr.Length * 2];
                Array.Copy(arr, arr2, arr.Length);
                arr = arr2;
            }

            public int getLength()
            {
                return lastIndex + 1;
            }

            public int getStorage()
            {
                return arr.Length;
            }

            public void add(T item)
            {
                if (lastIndex == arr.Length - 1)
                {
                    expandStorage();
                }
                lastIndex++;
                arr[lastIndex] = item;
            }

            public void print()
            {
                for (int i = 0; i <= lastIndex; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            public void insert(T item, int index)
            {
                if (index < 0 || index > lastIndex)
                {
                    throw new Exception("ERROR IN INDEX");

                }
                if (lastIndex == arr.Length - 1)
                {
                    expandStorage();
                }
                int segL = lastIndex - index + 1;
                Array.Copy(arr, index, arr, index + 1, segL);
                lastIndex++;
                arr[index] = item;
            }
            public void reverse1()
            {
                for (int i = lastIndex; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);

                }


            }

            public void reverse2()
            {
                T[] revArr = new T [arr.Length];

                for (int i = lastIndex; i >= 0; i--)
                {
                    revArr[i] = arr[i];
                    Console.WriteLine(revArr[i]);
                }
            }

            public void sort()
            {
                T temp ;
                for (int i = 0; i < lastIndex; i++)
                {
                    for (int j = i + 1; j < lastIndex; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;

                        }

                    }
                }
                for (int i = 0; i < lastIndex; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }



    }

        static void Main(string[] args)
        {
            Da<int> darray = new Da<int>(5);
            darray.add(5);
            darray.add(30);
            darray.add(1);
            darray.add(180);
            darray.add(-1);
            darray.add(6);

            Console.WriteLine("-----------------------length, storage---------");
            Console.WriteLine(darray.getLength());
            Console.WriteLine(darray.getStorage());

            Console.WriteLine("--------------------printing---------");
            darray.print();

            // Other operations omitted for simplicity...
        }
    }
}
