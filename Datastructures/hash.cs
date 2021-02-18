using System;
using System.Collections;

namespace Datastructures
{
    public class  hash
    {
        public Hashtable hashCreate()
        {
            Hashtable student = new Hashtable();
            student.Add(1, "Reshma");
            student.Add(2, "Rahul");
            student.Add(3, "Pooja");
            student.Add(4, "Roshni");
            student.Add(5, "Rohit");

            foreach(DictionaryEntry st in student)
                Console.WriteLine("Key: {0}, Value: {1}", st.Key, st.Value);

            return student;
        }

        public void hashremove(Hashtable student)
        {
            student.Remove(5);
            Console.WriteLine("After removal-----");
            foreach(DictionaryEntry st in student)
                Console.WriteLine("Key: {0}, Value: {1}", st.Key, st.Value);
        }
    }
}