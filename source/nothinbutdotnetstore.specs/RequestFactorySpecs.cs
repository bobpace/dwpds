 using System.Web;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.specs.utility;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  public class RequestFactorySpecs
  {
    public abstract class concern : Observes<ICreateRequests,
                                      RequestFactory>
    {

    }

    [Subject(typeof(RequestFactory))]
    public class when_creating_a_request : concern
    {
      Establish c = () =>
      {
        the_current_context = depends.on(ObjectFactory.web.create_http_context());
      };

      Because b = () =>
        result = sut.create_request_from(the_current_context);

      It should_return_request_information = () =>
        result.ShouldBeOfType<RequestInformation>();

      static HttpContext the_current_context;
      static IContainRequestInformation result;
    }
  }
}
