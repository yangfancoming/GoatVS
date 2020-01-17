using System;

namespace item01 {

    class Person : IPerson {
        public void Save(){
            Console.WriteLine("保存 Person");
        }
    }
}
