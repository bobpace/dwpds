using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.web.core
{
  public class StubRepository : ICanGetYouAStubButNotForFree
  {
    readonly IDictionary<Type, Type> stub_lookup;

    public StubRepository(IDictionary<Type, Type> stub_lookup)
    {
      this.stub_lookup = stub_lookup;
    }

    public WhatStub GetStub<WhatStub>() where WhatStub : class
    {
      var stub = stub_lookup[typeof (WhatStub)] as WhatStub;
      return stub;
    }
  }
}