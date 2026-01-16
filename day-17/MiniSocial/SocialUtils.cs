namespace MiniSocialMedia
{
    public static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime pastTime)
        {
            var time = DateTime.UtcNow - pastTime;
            if(time.TotalMinutes < 1) return "just now";
            if(time.TotalMinutes < 60) return $"{(int)time.TotalMinutes} min ago";
            if(time.TotalMinutes < 24) return $"{(int)time.TotalHours} h ago";
            return pastTime.ToString("MMM dd");
        }
    }
}