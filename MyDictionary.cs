using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMyDictionary
{
  class MyDictionary<Key,Value>
  {
        Key[] years;
        Value[] teams;

        public MyDictionary()
        {
            years = new Key[0];
            teams = new Value[0];
        }

        public void Add(Key yıl , Value takım )
        {
            Key[] TempArray = years;
            years = new Key[years.Length + 1];
            for (int i = 0; i <years.Length ; i++)
            {
                years[i] = TempArray[i];
            }
            years[years.Length - 1] = yıl;



            Value[] TempArrayy = teams;
            teams = new Value[teams.Length + 1];
            for (int x = 0; x <teams.Length ; x++)
            {
                teams[x] = TempArrayy[x];
            }
            teams[teams.Length- 1] = takım;

            Console.WriteLine(years[years.Length-1]+" " + teams[teams.Length-1]);
        }

       
        



  }
}
