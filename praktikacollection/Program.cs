using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikacollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            general a = new general();
            a.add();
            a.get();
            a.leinght();
            a.delete();
            Console.WriteLine("----------------------------------------------");
            generaltwo b = new generaltwo();
            b.add();
            b.get();
            b.leinght();
            b.delete();
            Console.WriteLine("----------------------------------------------");
            st qw = new st();
            qw.add();
            qw.get();
            qw.leinght();
            qw.delete();
            Console.WriteLine("----------------------------------------------");
            qu ew = new qu();
            ew.add();
            ew.get();
            qw.leinght();
            qw.delete();
        }
    }

    class general
    {
        ArrayList a = new ArrayList();
        public List<string> b = new List<string>();
        public Stack<double> qw = new Stack<double>();
        public Queue<int> we = new Queue<int>();

        public virtual void add()
        {
            a.Add(3434);
            a.Add("aaaa");
            a.Add(3.23);
            a.Add("ГЫЛЕНТ");
            a.Add("КАБЯКОВ");
        }

        public virtual void delete()
        {
            a.Clear();
        }

        public virtual void get()
        {
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
        }

        public virtual void leinght()
        {
            Console.WriteLine(a.Count);
        }
    }

        class generaltwo : general
        {
        public override void add()
            {
                b.Add("hello");
                b.Add("world");
                b.Add("Danil");
            }

            public override void delete()
            {
                b.Clear();
            }

            public override void get()
            {
                Console.WriteLine(b[0]);
                Console.WriteLine(b[1]);
                Console.WriteLine(b[2]);
            }

            public override void leinght()
            {
                Console.WriteLine(b.Count);
            }
        }

    
        class st: general
        {
        public override void add()
            {
                qw.Push(1.3);
                qw.Push(1.4);
                qw.Push(1.5);
                qw.Push(1.6);
            }

            public override void delete()
            {
                 qw.Pop();
            }
            public override void get()
            {
                Console.WriteLine(qw.Peek());
            }
            public override void leinght()
            {
               Console.WriteLine( qw.Count());
            }
        }
        class qu:general
        {

            public override void add()
            {
                we.Enqueue(1);
                we.Enqueue(2);
                we.Enqueue(3);
                we.Enqueue(4);
            }

            public override void delete ()
            {
                we.Clear();
            }

            public override void get()
            {
                Console.WriteLine(we.Peek());
            }

            public override void leinght()
            {
                Console.WriteLine(we.Count());
            }
        }
 }

