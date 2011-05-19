using System.Web;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core
{
  public class RequestFactory : ICreateRequests
  {
    readonly ICanFindDetailsInTheStore store_catalog;

    public RequestFactory(ICanFindDetailsInTheStore store_catalog)
    {
      this.store_catalog = store_catalog;
    }

    public IContainRequestInformation create_request_from(HttpContext context)
    {
      return new RequestInformation(context.Request, store_catalog);
    }
  }
}