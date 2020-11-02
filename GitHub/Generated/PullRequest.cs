using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class PullRequest
        : IPullRequest
    {
        public PullRequest(
            string permalink, 
            global::Demo.IActor author, 
            System.DateTimeOffset createdAt)
        {
            Permalink = permalink;
            Author = author;
            CreatedAt = createdAt;
        }

        public string Permalink { get; }

        public global::Demo.IActor Author { get; }

        public System.DateTimeOffset CreatedAt { get; }
    }
}
