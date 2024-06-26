// Copyright 2024 Confluent Inc.
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

using System.Threading.Tasks;

namespace Confluent.SchemaRegistry
{
    /// <summary>
    ///     A rule action   
    /// </summary>
    public interface IRuleAction : IRuleBase
    {
        /// <summary>
        ///     Run the rule action based on the rule context
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        Task Run(RuleContext ctx, object message, RuleException exception = null);
    }
}
