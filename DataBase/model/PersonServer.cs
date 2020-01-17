using System;

namespace DataBase.model {

    public class PersonServer{

        public PersonServer(){
            Console.WriteLine("PersonServer被实例");
        }

        public override string ToString(){
            return "我是PersonServer";
        }
    }
}
