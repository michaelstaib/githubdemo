using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace Demo
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetPullRequestsResultParser
        : JsonResultParserBase<IGetPullRequests>
    {
        private readonly IValueSerializer _intSerializer;
        private readonly IValueSerializer _uRISerializer;
        private readonly IValueSerializer _dateTimeSerializer;
        private readonly IValueSerializer _stringSerializer;

        public GetPullRequestsResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _intSerializer = serializerResolver.Get("Int");
            _uRISerializer = serializerResolver.Get("URI");
            _dateTimeSerializer = serializerResolver.Get("DateTime");
            _stringSerializer = serializerResolver.Get("String");
        }

        protected override IGetPullRequests ParserData(JsonElement data)
        {
            return new GetPullRequests
            (
                ParseGetPullRequestsRepository(data, "repository")
            );

        }

        private global::Demo.IRepository ParseGetPullRequestsRepository(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Repository
            (
                ParseGetPullRequestsRepositoryLabel(obj, "label")
            );
        }

        private global::Demo.ILabel ParseGetPullRequestsRepositoryLabel(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Label
            (
                ParseGetPullRequestsRepositoryLabelPullRequests(obj, "pullRequests")
            );
        }

        private global::Demo.IPullRequestConnection ParseGetPullRequestsRepositoryLabelPullRequests(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            return new PullRequestConnection
            (
                DeserializeInt(obj, "totalCount"),
                ParseGetPullRequestsRepositoryLabelPullRequestsNodes(obj, "nodes")
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Demo.IPullRequest> ParseGetPullRequestsRepositoryLabelPullRequestsNodes(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new global::Demo.IPullRequest[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new PullRequest
                (
                    DeserializeURI(element, "permalink"),
                    ParseGetPullRequestsRepositoryLabelPullRequestsNodesAuthor(element, "author"),
                    DeserializeDateTime(element, "createdAt")
                );

            }

            return list;
        }

        private global::Demo.IActor ParseGetPullRequestsRepositoryLabelPullRequestsNodesAuthor(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Actor
            (
                DeserializeString(obj, "login"),
                DeserializeURI(obj, "avatarUrl"),
                DeserializeURI(obj, "url")
            );
        }

        private int DeserializeInt(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (int)_intSerializer.Deserialize(value.GetInt32());
        }
        private string DeserializeURI(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_uRISerializer.Deserialize(value.GetString());
        }

        private System.DateTimeOffset DeserializeDateTime(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (System.DateTimeOffset)_dateTimeSerializer.Deserialize(value.GetString());
        }
        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
