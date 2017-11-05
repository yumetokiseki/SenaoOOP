namespace SenaoOOP
{
    public class DirectoryHandler : AbstractHandler
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
                result = this.CopyToDirectory(candidate, target);
            }
            return result;
        }

        /// <summary>
        /// 檔案內容移至目錄
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        /// <returns>檔案內容</returns>
        private byte[] CopyToDirectory(Candidate candidate, byte[] target)
        {
            if (!string.IsNullOrEmpty(candidate.Config.Dir))
            {
                System.IO.File.WriteAllBytes(candidate.Config.Dir + candidate.Name + candidate.Config.Ext, target);
            }

            return target;
        }
    }
}