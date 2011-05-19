 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{   
  public class UrlParserSpecs
  {
    public abstract class concern : Observes<ICanParseUrlPaths,
                                      UrlParser>
    {
        
    }

    [Subject(typeof(UrlParser))]
    public class when_give_a_url : concern
    {
      Establish c = () =>
      {
        url = "/departments/1.denver";
      };

      Because b = () =>
        result = sut.get_id_from_url(url);

      It can_extract_id_parameter_from_url = () =>
        result.ShouldEqual(1.ToString());

      static string url;
      static string result;
    }
  }
}
