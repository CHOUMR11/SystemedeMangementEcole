﻿using SchoolManagementSystem.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repositories
{
    public interface IAlertRepository : IGenericRepository<Alert>
    {
        Task CreateAlertAsync(Alert alert);
        Task<List<Alert>> GetActiveAlertsAsync();
        Task<Alert> GetAlertByIdAsync(int id);
        Task MarkAsResolvedAsync(int id);
        Task<List<Alert>> GetAlertsByEmployeeIdAsync(int employeeId); 

    }
}
