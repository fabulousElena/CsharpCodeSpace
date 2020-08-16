#region License

/*
 * Copyright � 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region Imports
using System;
using System.Reflection;
using Spring.Aop.Framework;
#endregion

namespace Spring.Aop.Framework
{
    /// <summary>
    /// Simple after returning advice example that we can use for counting checks.
    /// </summary>
    /// <author>Rod Johnson</author>
    /// <author>Bruno Baia (.NET)</author>
    [Serializable]
    public class CountingAfterReturningAdvice : MethodCounter, IAfterReturningAdvice
    {
        public void AfterReturning(object returnValue, MethodInfo method, object[] args, object target)
        {
            Count(method);
        }
    }
}