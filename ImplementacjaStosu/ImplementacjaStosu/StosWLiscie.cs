﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Stos;

namespace ImplementacjaStosu
{
    class StosWLiscie<T> : IStos<T>
    {

        private class Wezel
        {
            public T dane;
            public Wezel nastepnik;

            public Wezel(T e, Wezel nastepnik)
            {
                dane = e;
                this.nastepnik = nastepnik;
            }
        }

        private Wezel szczyt;

        public void Push(T e)
        {
            szczyt = new Wezel(e, szczyt);
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : szczyt.dane;
        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();

            szczyt = szczyt.nastepnik;
            return szczyt.dane;
        }

        public int Count => Count+1;
        public void TrimExcess()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty => szczyt == null;
        public void Clear() => szczyt = null;

        public T this[int index] => throw new NotImplementedException();

        public T[] ToArray()
        {
            T[] temp = new T[Count + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = szczyt.dane;
                szczyt = szczyt.nastepnik;
            }
            return temp;
        }
    }
}
