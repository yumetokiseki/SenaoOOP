using SenaoOOP.Model;

namespace SenaoOOP
{
    public class Candidate
    {
        public Candidate(Config config)
        {
            this.Config = config;
        }

        public Config Config { get; private set; }

        public string FileDateTime { get; private set; }

        public string Name { get; private set; }

        public string ProcessName { get; private set; }

        public string Size { get; private set; }
    }
}