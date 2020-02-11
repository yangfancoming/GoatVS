namespace chapter9_2_2.model {


    public class FileUpload {
        //
        public int? id;

        //
        public string fileFullPath ;

        public FileUpload(string fileFullPath) {
            this.fileFullPath = fileFullPath;
        }
    }
}