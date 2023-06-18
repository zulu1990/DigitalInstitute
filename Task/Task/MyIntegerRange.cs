using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MyIntegerRange :IEnumerable<int>
    {
        private int _startInt;
        private int _endInt;

        public MyIntegerRange(int start, int end)
        {
            _startInt = start;
            _endInt = end;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //return new MyIntegerRangeEnumerator(this);
            for (int i = _startInt; i <= _endInt; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return new MyIntegerRangeEnumerator(this);
            for (int i = _startInt; i <= _endInt; i++)
            {
                yield return i;
            }

        }

        private class MyIntegerRangeEnumerator : IEnumerator<int>
        {
            private int _start;
            private int _end;
            private int _current;

            public int Current => _current;

            object IEnumerator.Current => _current;

            public MyIntegerRangeEnumerator(MyIntegerRange range)
            {
                _start = range._startInt-1;
                _end = range._endInt;

                _current = _start;
            }

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if(_current < _end)
                {
                    _current++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _current = _start;
            }
        }
    }
}
