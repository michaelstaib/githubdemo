using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IGitHubClient
    {
        Task<IOperationResult<global::Demo.IGetPullRequests>> GetPullRequestsAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::Demo.IGetPullRequests>> GetPullRequestsAsync(
            GetPullRequestsOperation operation,
            CancellationToken cancellationToken = default);
    }
}
