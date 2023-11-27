using GradebookManagementApp.DAL.Interrfaces;
using GradebookManagementApp.DAL.Services.Repository;
using GradebookManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GradebookManagementApp.DAL.Services
{
    public class GradebookService : IGradebookService
    {
        private readonly IGradebookRepository _repository;

        public GradebookService(IGradebookRepository repository)
        {
            _repository = repository;
        }

        public Task<Grade> AddGrades(Grade grade)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteGradeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Grade> GetGradebook()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Grade> GetGradeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Grade> UpdateGradebook(Grade model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}