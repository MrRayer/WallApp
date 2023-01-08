namespace WebApplication1.Models
{
    public class UserPost
    {
        public int id { get; set; }
        public string PostUser { get; set; }
        public DateTime PostTime { get; set; }
        public string PostContents { get; set; }

        public UserPost()
        {

        }
    }
}
