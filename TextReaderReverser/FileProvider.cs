using System;
using System.IO;
using System.Threading.Tasks;

namespace TextReaderReverser
{
    public class FileProvider
    {
        public FileProvider()
        {
        }

        public string Root { get; }

        private static readonly char[] PathSeparators = { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };

        public Task<Stream> GetReadStreamAsync(string filename)
        {
            if (string.IsNullOrEmpty(filename)) throw new ArgumentNullException(nameof(filename));

            // Relative paths starting with leading slashes are okay
            filename = filename.TrimStart(PathSeparators);

            var fullPath = Path.Combine(Root, filename);

            var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            if (stream == null || !stream.CanRead)
                throw new FileNotFoundException($"Cannot read file '{fullPath}'");

            return Task.FromResult((Stream)stream);
        }
    }
}
