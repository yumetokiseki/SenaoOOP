using System.Text;

namespace SenaoOOP
{
    public class EncodeHandler : AbstractHandler
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
                result = this.EncodeData(candidate, target);
            }

            return result;
        }

        /// <summary>
        /// 將編碼從 ascii 轉成 unicode
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        /// <returns>檔案內容</returns>
        private byte[] EncodeData(Candidate candidate, byte[] target)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            return Encoding.Convert(ascii, unicode, target);
        }
    }
}