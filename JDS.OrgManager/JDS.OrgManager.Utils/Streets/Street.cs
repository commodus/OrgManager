// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
namespace JDS.OrgManager.Utils.Streets
{
    public class Street
    {
        #region Public Properties + Indexers

        public string Direction { get; set; }

        public string FullName { get; set; }

        public int MaxAddress { get; set; }

        public int MinAddress { get; set; }

        public string Name { get; set; }

        public string Suffix { get; set; }

        public string SuffixDirection { get; set; }

        #endregion

        #region Public Methods

        public override string ToString() => $"{Direction} {Name} {Suffix} ({MinAddress}-{MaxAddress})";

        #endregion
    }
}