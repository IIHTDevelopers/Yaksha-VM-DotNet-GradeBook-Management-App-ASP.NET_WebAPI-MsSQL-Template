using GradebookManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GradebookManagementApp.DAL.Services.Repository
{
    public class GradebookRepository : IGradebookRepository
    {
        private readonly DatabaseContext _dbContext;
        public GradebookRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Grade> AddGrades(Grade grade)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteGradeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Grade> GetGradebook()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Grade> GetGradeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Grade> UpdateGradebook(Grade model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}