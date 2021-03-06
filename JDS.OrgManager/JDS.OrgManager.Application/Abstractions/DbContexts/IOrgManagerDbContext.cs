// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Application.Common.Currencies;
using JDS.OrgManager.Application.Common.Employees;
using JDS.OrgManager.Application.Common.PaidTimeOffPolicies;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace JDS.OrgManager.Application.Abstractions.DbContexts
{
    public interface IOrgManagerDbContext
    {
        #region Public Properties + Indexers

        public DbSet<CurrencyEntity> Currencies { get; }

        public DbSet<EmployeeManagerEntity> EmployeeManagers { get; }

        public DbSet<EmployeeEntity> Employees { get; }

        public bool HasChanges { get; }

        public DbSet<PaidTimeOffPolicyEntity> PaidTimeOffPolicies { get; }

        #endregion

        #region Public Methods

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion
    }
}