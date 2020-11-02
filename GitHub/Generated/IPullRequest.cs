using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IPullRequest
    {
        string Permalink { get; }

        global::Demo.IActor Author { get; }

        System.DateTimeOffset CreatedAt { get; }
    }
}
