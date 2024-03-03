using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Çanakkale");
            sehirler.Add("Samsun");
            sehirler.Add("Yalova");
            sehirler.Add("Edirne");

            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Balıkesir");
            sehirler2.Add("Diyarbakır");
            sehirler2.Add("Malatya");
            sehirler2.Add("İzmir");
            sehirler2.Add("Giresun");
            sehirler2.Add("Antalya");
            sehirler2.Add("Tekirdağ");

            Console.WriteLine(sehirler2.Count);
            Console.ReadLine();
        }
    }

    class MyList<TKey>   //Generic class
    {
        TKey[] _array;
        TKey[] _tempArray;

        public MyList()
        {
            _array = new TKey[0];
        }

        public void Add(TKey key)
        {
            _tempArray = _array;
            _array = new TKey[_array.Length + 1];
            for (int i =0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = key;
        }

        public int Count
        {
            get{ return _array.Length;}
        }
    }
}
