// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlServerAdministratorOperationSource : IOperationSource<PostgreSqlServerAdministratorResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlServerAdministratorOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlServerAdministratorResource IOperationSource<PostgreSqlServerAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlServerAdministratorData>(response.Content);
            return new PostgreSqlServerAdministratorResource(_client, data);
        }

        async ValueTask<PostgreSqlServerAdministratorResource> IOperationSource<PostgreSqlServerAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PostgreSqlServerAdministratorData>(response.Content);
            return await Task.FromResult(new PostgreSqlServerAdministratorResource(_client, data)).ConfigureAwait(false);
        }
    }
}
