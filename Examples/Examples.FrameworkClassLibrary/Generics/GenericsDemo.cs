using System;
using System.Linq;

namespace Examples.FrameworkClassLibrary.Generics
{
    /// <summary>
    /// generic type demo:
    /// imprve the reuse code, type safe, good perfermance,when using valuetype no need to boxing
    /// </summary>
    public class GenericsDemo
    {

        #region Generic in delegate
        private delegate T Join<T>(T a, T b);
        #endregion
        public static void Demo()
        {
            var genericStringArr = new MyGenericArray<string>(5);
            genericStringArr.SetItem("Zhangsan", 0);
            genericStringArr.SetItem("Wangmeimei", 1);
            genericStringArr.SetItem("Li Lei", 2);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("array list {0}", genericStringArr.GetItem(i));

            }

            var genericIntArr = new MyGenericArray<int>(5);
            genericIntArr.SetItem(1, 0);
            for (int i = 0; i < 3; i++)
            {
                genericIntArr.SetItem(5 * i, 0);
                Console.WriteLine("array list {0}", genericIntArr.GetItem(i));
            }

            MyDic<int, Student> dics = new MyDic<int, Student>(2);
            dics.Add(1, new Student { Name = "Zhangsan" });
            dics.Add(2, new Student { Name = "Li si" });
            //dics.Add(3, new Student { Name = "Li si" });

            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine("a:{0},b:{1}", a, b);

            Join<string> d = ( firstName, lastName) => { return firstName + lastName; };
            Console.WriteLine(d("Lei", "Li"));

        }

        #region generic in Method
        private static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        #endregion
    }

    #region basic generic Type:only one type
    class MyGenericArray<T>
    {
        private T[] arr;

        public MyGenericArray(int length)
        {
            arr = new T[length];
        }

        public void SetItem(T value, int index)
        {
            arr[index] = value;
        }

        public T GetItem(int index)
        {
            return arr[index];
        }
    }
    #endregion

    #region multiply generic types,like Dictionary
    class MyDic<TKey, TValue> where TValue : class
                              where TKey : struct
    {
        MyDic<TKey, TValue>[] Items;
        TValue[] values;
        TKey[] keys;
        public MyDic(int length)
        {
            Items = new MyDic<TKey, TValue>[length];
            values = new TValue[length];
            keys = new TKey[length];
        }

        public void Add(TKey key, TValue val)
        {
            int i = 0;
            for (i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    values[i] = val;
                    return;
                }
            }

            for (i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(default(TKey)))
                {
                    keys[i] = key;
                    values[i] = val;
                    return;
                }
            }

            if (i >= keys.Length)
            {
                throw new Exception("the dic exceed the max of length:" + keys.Length);
            }

        }

    }

    class Student
    {
        public string Name { get; set; }
    }
    #endregion

}
