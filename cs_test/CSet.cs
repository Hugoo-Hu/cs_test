using System;
using System.Collections.Generic;
using System.Text;

namespace cs_test
{
    public class CSet<T>
    {
        private List<T> m_setlist;

        public CSet()
        {
            m_setlist = new List<T>();
        }

        public void add(T item)
        {
            if (!m_setlist.Contains(item))
            {
                m_setlist.Add(item);
                m_setlist.Sort();
            }
        }

        public T this[int index]
        {
            get { return m_setlist[index]; }
            set { m_setlist[index] = value; }
        }

        public void remove(T item)
        { 
            }
    
    }
}
