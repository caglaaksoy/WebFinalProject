namespace WebFinalProje.Utilities
{
    public class Session
    {
        public static void SetUserSession(HttpContext httpContext, string userEmail)
        {
            httpContext.Session.SetString("UserEmail", userEmail);
        }

        public static string GetUserSession(HttpContext httpContext)
        {
            return httpContext.Session.GetString("UserEmail");
        }
    }
}
