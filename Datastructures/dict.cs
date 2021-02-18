using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class DictionaryCrud
    {
        public IDictionary<int, string> dictionaryCreate()
        {
            IDictionary<int, string> student = new Dictionary<int, string>();
            student.Add(1, "Ammu");
            student.Add(2, "Appu");
            student.Add(3, "Duggu");
            student.Add(4, "Cheeku");
            student.Add(5, "Shimpu");

            foreach (var s in student)
                Console.WriteLine("{0} : {1}",s.Key, s.Value);
            
            return student;

        }

        public void dictionaryAccess(IDictionary<int, string> student)
        {

            //Accessing items in a dictionary

            Console.WriteLine(student[2]);

            //using ContainsKey()
            if(student.ContainsKey(1))
                Console.WriteLine(student[1]);

            // using TryGetvalue()
            if(student.TryGetValue(3, out string result))
                Console.WriteLine(result);

        }
            
        public void dictionaryRemove(IDictionary<int, string> student)
        {
            //removing items from a dictionary
            student.Remove(2);

            foreach (var s in student)
                Console.WriteLine("{0} : {1}",s.Key, s.Value);
        }
   
    }
}