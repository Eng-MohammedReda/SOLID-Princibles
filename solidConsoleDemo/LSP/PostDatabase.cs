namespace solidConsoleDemo.LSP
{
    public class PostDatabase
    {
        public string Add(string post){
            return "Original Post: " + post;
        }

         public string AddTagPost(string post){
            return "Tag post: " + post;
        }

        public string AddMentionPost(string post){
            return "Mention post: " + post;
        }

        public string AddLinkPost(string post){
            return "Link post: " + post;
        } 
    }
}