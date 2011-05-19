using System.Web;

namespace nothinbutdotnetstore.web.core
{
  public class RequestFactory : ICreateRequests
  {
    public IContainRequestInformation create_request_from(HttpContext context)
    {
      return new RequestInformation(context.Request);
    }
  }
}