using System.IO;

namespace CidFileChangeTracker
{
    public class FileWatched
    {
        public FileInfo File { get; set; }
        public string Signature { get; set; }

        public FileWatched(string Signature, FileInfo File)
        {
            this.Signature = Signature;
            this.File = File;
        }

    }
}
