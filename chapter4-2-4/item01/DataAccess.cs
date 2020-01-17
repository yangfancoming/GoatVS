namespace item01 {

    class DataAccess {
        public static IPerson CreatePersonDao() {
            return new Person();
        }
    }
}
