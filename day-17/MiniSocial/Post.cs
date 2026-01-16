using System.Text;
using System.Text.RegularExpressions;

namespace MiniSocialMedia
{
    public class Post
    {
        public User Author{get; init;}
        public string Content{get; init;}
        public DateTime CreatedAt{get; } = DateTime.UtcNow;
        public Post(User author, string content)
        {
            if(author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }
            Author = author;
            Content = content;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{Author} . {CreatedAt:MMM dd HH:mm}");
            sb.AppendLine();

            sb.Append(Content);

            var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");

            if(hashtags.Count > 0)
            {
                sb.AppendLine();
                sb.Append("Tags: ");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }
            return sb.ToString();
        }
    }
}