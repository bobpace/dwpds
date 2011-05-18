namespace nothinbutdotnetstore.web.core
{
  public interface ICanGetYouAStubButNotForFree
  {
    WhatStub GetStub<WhatStub>() where WhatStub : class;
  }
}