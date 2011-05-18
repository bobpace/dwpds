using System;
using System.Collections.Generic;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.application.catalogbrowsing.stubs;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  [Subject(typeof(StubRepository))]
  public class StubRepositorySpecs
  {
    public abstract class concern : Observes<ICanGetYouAStubButNotForFree ,
                                      StubRepository>
    {
    }

    public class when_asked_for_a_stub : concern
    {
      Establish c = () =>
      {
        stubs_lookup = depends.on<IDictionary<Type, Type>>();
      };

      Because b = () =>
        result = sut.GetStub<ICanFindDetailsInTheStore>();

      It can_return_the_stub_asked_for = () =>
        result.ShouldBeOfType<StubStoreCatalog>();

      static object stubs_lookup;
      static ICanFindDetailsInTheStore result;
    }
  }
}