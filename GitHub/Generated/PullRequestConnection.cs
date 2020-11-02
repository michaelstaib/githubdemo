using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class PullRequestConnection
        : IPullRequestConnection
    {
        public PullRequestConnection(
            int totalCount, 
            global::System.Collections.Generic.IReadOnlyList<global::Demo.IPullRequest> nodes)
        {
            TotalCount = totalCount;
            Nodes = nodes;
        }

        public int TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Demo.IPullRequest> Nodes { get; }
    }
}
