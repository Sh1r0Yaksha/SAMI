namespace SAMI.Data
{
    internal class Mod
    {
        public string id { get; set; }
        public int nexusId { get; set; }
        public string name { get; set; }
        public string repo { get; set; }

        public string author
        {
            get
            {
                string[] authoreName = repo.Split('/');
                return authoreName[0];
            }
        }
    }
}
