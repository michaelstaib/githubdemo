using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Label
        : ILabel
    {
        public Label(
            global::Demo.IPullRequestConnection pullRequests)
        {
            PullRequests = pullRequests;
        }

        public global::Demo.IPullRequestConnection PullRequests { get; }
    }
}
