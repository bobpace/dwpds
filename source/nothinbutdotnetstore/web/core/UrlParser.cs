using System;

namespace nothinbutdotnetstore.web.core
{
  public class UrlParser : ICanParseUrlPaths
  {
    public string get_id_from_url(string url)
    {
      var tokens = url.Split(new char[] {'/'});
      return tokens[2].Replace(".denver", string.Empty);
    }
  }
}