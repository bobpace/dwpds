using System;
using System.Web;

namespace nothinbutdotnetstore.web.core
{
  public class RequestInformation : IContainRequestInformation
  {
    readonly HttpRequest request;

    public RequestInformation(HttpRequest request)
    {
      this.request = request;
    }

    public InputModel map<InputModel>()
    {
      //TODO: how is a request information going to get us a model?
      return default(InputModel);
    }

    public string get_url()
    {
      return request.Url.PathAndQuery;
    }
  }
}