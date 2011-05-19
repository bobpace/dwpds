using System.Web;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.web.application.catalogbrowsing.stubs;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.core
{
  public class RawHandler : IHttpHandler
  {
    IProcessIncomingRequests front_controller;
    ICreateRequests request_factory;

    public RawHandler()
      : this(new FrontController(),
        new RequestFactory(Stub.with<StubStoreCatalog>()))
    {
    }

    public RawHandler(IProcessIncomingRequests front_controller, ICreateRequests request_factory)
    {
      this.front_controller = front_controller;
      this.request_factory = request_factory;
    }

    public void ProcessRequest(HttpContext context)
    {
      front_controller.process(request_factory.create_request_from(context));
    }

    public bool IsReusable
    {
      get { return true; }
    }
  }
}