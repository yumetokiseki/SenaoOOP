namespace SenaoOOP
{
    public class FileHandler : AbstractHandler
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

            if (target == null)
            {
                result = this.ConvertFileToByteArray(candidate);
            }
            else
            {
                this.ConvertByteArrayToFile(candidate, target);
            }

            return result;
        }

        /// <summary>
        /// 寫出檔案內容
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        private void ConvertByteArrayToFile(Candidate candidate, byte[] target)
        {
            System.IO.File.WriteAllBytes(candidate.Config.Location + candidate.Name + candidate.Config.Ext, target);
        }

        /// <summary>
        /// 讀取檔案內容
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <returns>檔案內容</returns>
        private byte[] ConvertFileToByteArray(Candidate candidate)
        {
            byte[] result = null;
            result = System.IO.File.ReadAllBytes(candidate.Config.Location + candidate.Name + candidate.Config.Ext);
            return result;
        }
    }
}