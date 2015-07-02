using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;

namespace CodeWisard_data_format
{
    class Deflate : API
    {
        /// <summary>
        /// Start a file deflation but I do recomend using the apropriate api method for such task.
        /// </summary>
        /// <param name="filename">The name of the archive</param>
        /// <param name="files">An array of strings with treated paths to the files to add. But </param>
        /// <returns></returns>
        protected static bool Deflate(string filename, string[] files, bool recurse)
        {
            Stream rawOutStream = File.Create(filename);
            Stream outStream = new GZipOutputStream(rawOutStream);
            TarArchive compressionHandle = TarArchive.CreateOutputTarArchive(outStream);
            if (AddFilesToTar(compressionHandle, files, recurse))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// A
        /// </summary>
        /// <param name="archiveHandler"></param>
        /// <param name="files"></param>
        /// <param name="recurse"></param>
        /// <returns></returns>
        private static bool AddFilesToTar(TarArchive archiveHandler, string[] files, bool recurse)
        {
            for (int i = 0; i < files.Length; i++)
            {
                TarEntry entry = TarEntry.CreateEntryFromFile(files[i]);
                archiveHandler.WriteEntry(entry, recurse);
            }
        }
    }
}
