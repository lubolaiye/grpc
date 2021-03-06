#region Copyright notice and license

// Copyright 2015 gRPC authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Threading.Tasks;

namespace Grpc.Core.Utils
{
    /// <summary>
    /// Utility methods for task parallel library.
    /// </summary>
    public static class TaskUtils
    {
        /// <summary>
        /// Framework independent equivalent of <c>Task.CompletedTask</c>.
        /// </summary>
        public static Task CompletedTask
        {
            get
            {
#if NETSTANDARD1_5 || NETSTANDARD2_0
                return Task.CompletedTask;
#else
                return Task.FromResult<object>(null);  // for .NET45, emulate the functionality
#endif
            }
        }
    }
}
