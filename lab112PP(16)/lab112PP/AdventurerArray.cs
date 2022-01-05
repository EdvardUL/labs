using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace lab112PP
{
    [Serializable]
    class AdventureArray : IList, ICloneable, IComparable
    {
        public delegate void AdventurerArrHandler(object o, MyClassEventArgs s);
        public event AdventurerArrHandler Adding;
        public event AdventurerArrHandler RemoveArr;
        private object[] _contents = new object[7];
        private int _count;
        public AdventureArray()
        {
            _count = 0;
        }
        public int Add(object value)
        {
            Adding = abc;
            Adding(this, new MyClassEventArgs("Элемент добавлен в список"));
            if (_count < _contents.Length)
            {
                _contents[_count] = value;
                _count++;

                return (_count - 1);
            }

            return -1;
        }
        public void Clear()
        {
            _count = 0;
        }
        public bool Contains(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, object value)
        {
            if ((_count + 1 <= _contents.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _contents[i] = _contents[i - 1];
                }
                _contents[index] = value;
            }
        }
        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        public void Remove(object value)
        {
            RemoveArr = abc;
            RemoveAt(IndexOf(value));
            Adding(this, new MyClassEventArgs("Элемент удален"));
        }
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _contents[i] = _contents[i + 1];
                }
                _count--;
            }
        }
        public object this[int index]
        {
            get
            {
                return _contents[index];
            }
            set
            {
                _contents[index] = value;
            }
        }
        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_contents[i], index++);
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
        public void PrintContents()
        {
            Console.WriteLine($"List has a capacity of {_contents.Length} and currently has {_count} elements.");
            Console.Write("List contents:\n");
            for (int i = 0; i < Count; i++)
            {
                Console.Write($" {_contents[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            return _count.CompareTo(obj);
        }
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
}