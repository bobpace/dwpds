using System;
using System.Web;
using nothinbutdotnetstore.web.application.catalogbrowsing;

namespace nothinbutdotnetstore.web.core
{
  public class RequestInformation : IContainRequestInformation
  {
    readonly HttpRequest request;
    ICanFindDetailsInTheStore store_catalog;

    public RequestInformation(HttpRequest request, ICanFindDetailsInTheStore store_catalog)
    {
      this.request = request;
      this.store_catalog = store_catalog;
    }

    public InputModel map<InputModel>()
    {
      //TODO: how is a request information going to get us a model?)
      return default(InputModel);
    }

    public string get_url()
    {
      return request.Url.PathAndQuery;
    }
  }
}