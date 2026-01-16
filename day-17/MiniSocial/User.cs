using System.Text.RegularExpressions;
namespace MiniSocialMedia
{
    public partial class User : IPostable, IComparable<User>
    {
        public string Username { get; init; }
        public string Email { get; init; }
        private List<Post> _posts = new();
        private readonly HashSet<string> _following = new(StringComparer.OrdinalIgnoreCase);
        public event Action<Post>? OnNewPost;
        public User(string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException(nameof(username));
            }
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                throw new SocialException("Invalid email format");
            }
            Username = username.Trim();
            Email = email.Trim().ToLower();
        }
        public void Follow(string username)
        {
            if (string.Equals(Username, username, StringComparison.OrdinalIgnoreCase))
            {
                throw new SocialException("Cannot follow yourself");
            }
            _following.Add(username);
        }
        public bool IsFollowing(string username) => _following.Contains(username);
        public void AddPost(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Post content cannot be empty");
            }
            if (content.Length > 280)
            {
                throw new SocialException("Post too long (max 280 characters)");
            }
            string cleanedContent = content.Trim();
            var post = new Post(this, cleanedContent);
            _posts.Add(post);
            OnNewPost?.Invoke(post);
        }
        public IReadOnlyList<Post> GetPosts()
        {
            return _posts.AsReadOnly();
        }
        public int CompareTo(User other)
        {
            if (other == null) return 1;
            return string.Compare(this.Username, other.Username, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return $"@{this.Username}";
        }
        public string GetDisplayName()
        {
            return $"User: {this.Username} <{this.Email}>";
        }
        public IReadOnlyCollection<string> GetFollowingNames()
        {
            return _following;
        }
    }
}