// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using System;
using System.Collections.Generic;
using System.Linq;

namespace JDS.OrgManager.Common
{
    public class Result
    {
        #region Public Properties + Indexers

        public string[] Errors { get; } = new string[0];

        public bool Succeeded { get; }

        #endregion

        #region Internal Constructors

        internal Result(bool succeeded, IEnumerable<string> errors = null)
        {
            Succeeded = succeeded;
            Errors = (errors ?? Enumerable.Empty<string>()).ToArray();
        }

        #endregion

        #region Public Methods

        public static Result Failure(IEnumerable<string> errors)
        {
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }
            return new Result(false, errors);
        }

        public static Result Success() => new Result(true);

        #endregion
    }
}