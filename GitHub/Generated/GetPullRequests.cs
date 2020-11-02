using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetPullRequests
        : IGetPullRequests
    {
        public GetPullRequests(
            global::Demo.IRepository repository)
        {
            Repository = repository;
        }

        public global::Demo.IRepository Repository { get; }
    }
}
