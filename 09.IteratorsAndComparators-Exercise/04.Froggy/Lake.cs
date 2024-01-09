using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        public List<T> Stones { get; private set; }
        public Lake(T[] stones)
        {
            Stones = new List<T>(stones);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Stones[i];
                }
            }

            for (int i = Stones.Count - 1; i >= 0; i--)
            {
                if(i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
