using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IPullRequestConnection
    {
        int TotalCount { get; }

        global::System.Collections.Generic.IReadOnlyList<global::Demo.IPullRequest> Nodes { get; }
    }
}
