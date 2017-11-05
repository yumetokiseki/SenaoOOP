using System.IO;
using System.IO.Compression;

namespace SenaoOOP
{
    public class ZipHandler : AbstractHandler
    {
        /// <summary>
        /// 執行操作
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        /// <returns>檔案內容</returns>
        public override byte[] Perform(Candidate candidate, byte[] target)
        {
            byte[] result = target;
            base.Perform(candidate, target);

            if (target != null)
            {
                result = this.ZipData(candidate, target);
            }

            return result;
        }

        /// <summary>
        /// 檔案壓縮
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        /// <returns>檔案內容</returns>
        private byte[] ZipData(Candidate candidate, byte[] target)
        {
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(target, 0, target.Length);
            }
            return output.ToArray();
        }
    }
}