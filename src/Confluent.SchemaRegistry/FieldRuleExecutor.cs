// Copyright 2022 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Confluent.SchemaRegistry
{
    public abstract class FieldRuleExecutor : IRuleExecutor
    {
        public abstract void Configure(IEnumerable<KeyValuePair<string, string>> config,
            ISchemaRegistryClient client = null);
        
        public abstract string Type();

        public abstract IFieldTransform NewTransform(RuleContext ctx);

        public async Task<object> Transform(RuleContext ctx, object message)
        {
            using (IFieldTransform transform = NewTransform(ctx))
            {
                return await ctx.FieldTransformer.Invoke(ctx, transform, message)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
        }

        public abstract void Dispose();
    }
}
