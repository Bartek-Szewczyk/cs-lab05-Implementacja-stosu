﻿using System;
using System.Collections.Generic;
using System.Text;
using Stos;

namespace ImplementacjaStosu
{
    class StosWLiscie<T>:IStos<T>
    {
        public void Push(T value)
        {
            throw new NotImplementedException();
        }

        public T Peek { get; }
        public T Pop()
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public void TrimExcess()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T this[int index] => throw new NotImplementedException();

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}