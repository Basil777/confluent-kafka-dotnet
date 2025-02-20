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

using System.Collections.Generic;
using System.Threading;

namespace Confluent.SchemaRegistry
{
    /// <summary>
    ///     A rule registry.
    /// </summary>
    public class RuleRegistry
    {
        private readonly SemaphoreSlim ruleExecutorsMutex = new SemaphoreSlim(1);
        private readonly SemaphoreSlim ruleActionsMutex = new SemaphoreSlim(1);
        private readonly SemaphoreSlim ruleOverridesMutex = new SemaphoreSlim(1);

        private IDictionary<string, IRuleExecutor> ruleExecutors = new Dictionary<string, IRuleExecutor>();
        private IDictionary<string, IRuleAction> ruleActions = new Dictionary<string, IRuleAction>();
        private IDictionary<string, RuleOverride> ruleOverrides = new Dictionary<string, RuleOverride>();

        private static readonly RuleRegistry GLOBAL_INSTANCE = new RuleRegistry();

        public static RuleRegistry GlobalInstance => GLOBAL_INSTANCE;

        public void RegisterExecutor(IRuleExecutor executor)
        {
            ruleExecutorsMutex.Wait();
            try
            {
                if (!ruleExecutors.ContainsKey(executor.Type()))
                {
                    ruleExecutors.Add(executor.Type(), executor);
                }
            }
            finally
            {
                ruleExecutorsMutex.Release();
            }
        }

        public bool TryGetExecutor(string name, out IRuleExecutor executor)
        {
            ruleExecutorsMutex.Wait();
            try
            {
                return ruleExecutors.TryGetValue(name, out executor);
            }
            finally
            {
                ruleExecutorsMutex.Release();
            }
        }

        public List<IRuleExecutor> GetExecutors()
        {
            ruleExecutorsMutex.Wait();
            try
            {
                return new List<IRuleExecutor>(ruleExecutors.Values);
            }
            finally
            {
                ruleExecutorsMutex.Release();
            }
        }

        public void RegisterAction(IRuleAction action)
        {
            ruleActionsMutex.Wait();
            try
            {
                if (!ruleActions.ContainsKey(action.Type()))
                {
                    ruleActions.Add(action.Type(), action);
                }
            }
            finally
            {
                ruleActionsMutex.Release();
            }
        }

        public bool TryGetAction(string name, out IRuleAction action)
        {
            ruleActionsMutex.Wait();
            try
            {
                return ruleActions.TryGetValue(name, out action);
            }
            finally
            {
                ruleActionsMutex.Release();
            }
        }

        public List<IRuleAction> GetActions()
        {
            ruleActionsMutex.Wait();
            try
            {
                return new List<IRuleAction>(ruleActions.Values);
            }
            finally
            {
                ruleActionsMutex.Release();
            }
        }

        public void RegisterOverride(RuleOverride ruleOverride)
        {
            ruleOverridesMutex.Wait();
            try
            {
                if (!ruleOverrides.ContainsKey(ruleOverride.Type))
                {
                    ruleOverrides.Add(ruleOverride.Type, ruleOverride);
                }
            }
            finally
            {
                ruleOverridesMutex.Release();
            }
        }

        public bool TryGetOverride(string name, out RuleOverride ruleOverride)
        {
            ruleOverridesMutex.Wait();
            try
            {
                return ruleOverrides.TryGetValue(name, out ruleOverride);
            }
            finally
            {
                ruleOverridesMutex.Release();
            }
        }

        public List<RuleOverride> GetOverrides()
        {
            ruleOverridesMutex.Wait();
            try
            {
                return new List<RuleOverride>(ruleOverrides.Values);
            }
            finally
            {
                ruleOverridesMutex.Release();
            }
        }

        public static void RegisterRuleExecutor(IRuleExecutor executor)
        {
            GlobalInstance.RegisterExecutor(executor);
        }

        public static void RegisterRuleAction(IRuleAction action)
        {
            GlobalInstance.RegisterAction(action);
        }

        public static void RegisterRuleOverride(RuleOverride ruleOverride)
        {
            GlobalInstance.RegisterOverride(ruleOverride);
        }
    }
}
