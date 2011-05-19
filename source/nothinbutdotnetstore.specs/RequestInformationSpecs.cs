 using System.Web;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.specs.utility;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
  public class RequestInformationSpecs
  {
    public abstract class concern : Observes<IContainRequestInformation,
                                      RequestInformation>
    {
        
    }

    [Subject(typeof(IContainRequestInformation))]
    public class when_getting_the_url : concern
    {
      Establish c = () =>
      {
        request = depends.on(ObjectFactory.web.create_http_context().Request);
      };

      Because b = () =>
        url = sut.get_url();

      It should_match_context_url = () =>
        url.ShouldEqual("/blah.aspx");

      static string url;
      static HttpRequest request;
    }

    private class OurModel
    {
    }
  }
}
