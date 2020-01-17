using System;

namespace DataBase.model{

    public class PersonDao{

        public PersonDao(){
            Console.WriteLine("PersonDao被实例");
        }

        public override string ToString(){
            return "我是PersonDao";
        }
    }
}
