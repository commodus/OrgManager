// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Application.Abstractions.Models;
using Newtonsoft.Json;

namespace JDS.OrgManager.Application.Models
{
    public abstract class ViewModel : IViewModel
    {
        #region Public Methods

        public override string ToString() => JsonConvert.SerializeObject(this);

        #endregion
    }
}