using System;
using developwithpassion.specifications;
using nothinbutdotnetstore.infrastructure.container;
using nothinbutdotnetstore.infrastructure.container.stubs;

namespace nothinbutdotnetstore.specs.utility
{
  public class SharedBehaviours
  {
    public static ObservationPair scaffold_container_returned<Dependency>(Dependency dependency)
    {
      return new ObservationPair(() =>
      {
        Container.gateway_resolver = () => new StubContainer();
      }, () =>
      {

      });
    }
  }
}