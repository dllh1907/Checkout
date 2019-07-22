namespace Checkout.Utilities
{
    public static class CommonHelper
    {
        public static string GetUserIP()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipList = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}