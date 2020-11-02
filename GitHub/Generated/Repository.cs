using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Repository
        : IRepository
    {
        public Repository(
            global::Demo.ILabel label)
        {
            Label = label;
        }

        public global::Demo.ILabel Label { get; }
    }
}
