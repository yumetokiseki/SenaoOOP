namespace SenaoOOP.Interface
{
    public interface Handler
    {
        /// <summary>
        /// 執行操作
        /// </summary>
        /// <param name="candidate">candidate</param>
        /// <param name="target">檔案內容</param>
        /// <returns>檔案內容</returns>
        byte[] Perform(Candidate candidate, byte[] target);
    }
}