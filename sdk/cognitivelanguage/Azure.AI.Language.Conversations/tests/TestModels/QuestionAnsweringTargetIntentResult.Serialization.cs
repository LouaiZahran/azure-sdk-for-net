// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class QuestionAnsweringTargetIntentResult
    {
        internal static QuestionAnsweringTargetIntentResult DeserializeQuestionAnsweringTargetIntentResult(JsonElement element)
        {
            Optional<AnswersResult> result = default;
            TargetProjectKind targetProjectKind = default;
            Optional<string> apiVersion = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    result = AnswersResult.DeserializeAnswersResult(property.Value);
                    continue;
                }
                if (property.NameEquals("targetProjectKind"))
                {
                    targetProjectKind = new TargetProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new QuestionAnsweringTargetIntentResult(targetProjectKind, apiVersion.Value, confidenceScore, result.Value);
        }
    }
}
