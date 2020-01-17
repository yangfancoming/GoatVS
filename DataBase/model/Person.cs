using System;

namespace DataBase.model {

    public class Person{

        public Person(){
            Console.WriteLine("Person被实例");
        }

        public override string ToString(){
            return "我是Person";
        }

        ~Person(){
            Console.WriteLine("Person被销毁");
        }
    }
}
