using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Actor
        : IActor
    {
        public Actor(
            string login, 
            string avatarUrl, 
            string url)
        {
            Login = login;
            AvatarUrl = avatarUrl;
            Url = url;
        }

        public string Login { get; }

        public string AvatarUrl { get; }

        public string Url { get; }
    }
}
