using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPvorbereitung
{
    class Data
    {
        //Declare two Lists for Data Storage
        public List<string> Datanames
        {
            get
            {
                List<string> list = new List<string>();
                list.Add("Kostenstelle1");
                list.Add("Kostenstelle2");
                list.Add("Kostenstelle3");
                return list;
            }
        } 
        public List<long> LongData {
            get
            {
                List<long> list = new List<long>();
                list.Add(1523155742);
                list.Add(5878545852);
                list.Add(121422158);
                return list;
            }
            
        
        }


    }
}
