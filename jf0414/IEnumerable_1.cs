using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace jf0414
{
    class IEnumerable_1
    {
        static void Main(string[] args)
        {
            charlist mycharlist = new charlist("hellow world");
            foreach (var c in mycharlist)
            {
                Console.Write(c);
            }
            Console.ReadLine();
        }
    }
    class charlist: IEnumerable
    {
        public string TargetStr { get; set; }

        public charlist(string str)
        {
            this.TargetStr = str;
        }
        public IEnumerator GetEnumerator()
        {
            for (int index=this.TargetStr.Length; index >0; index--)
            {
                yield return this.TargetStr[index - 1];
            }
        }
    }
    class CharIterator: IEnumerator
    {
        public string TargetStr { get; set; }
        public int position { get; set; }

        public CharIterator(string targetStr)
        {
            this.TargetStr = targetStr;
            this.position = this.TargetStr.Length;
        }

        public object Current
        {
            get
            {
                if (this.position == -1 || this.position == this.TargetStr.Length)
                {
                    throw new InvalidOperationException();
                }
                return this.TargetStr[this.position];
            }
        }

        public bool MoveNext()
        {
            if (this.position != -1)
            {
                this.position--;
            }
            return this.position > -1;
        }

        public void Reset()
        {
            this.position = this.TargetStr.Length;
        }
    }
}
