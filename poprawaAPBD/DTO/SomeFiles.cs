using poprawaAPBD.Models;

namespace poprawaAPBD.DTO
{
    public class SomeFiles
    {
        public int FileID { get; set; }
        public int TeamID { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }

        public virtual Team Team { get; set; }
    }
}
