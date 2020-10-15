using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_and_Repository.Initial
{
    public class CompanyLogic : ICompanyLogic
    {
        private readonly IPersonRepository personRepo;
        private readonly ICompanyRepository companyRepo;

        public CompanyLogic(IPersonRepository personRepo, ICompanyRepository companyRepo)
        {
            this.personRepo = personRepo;
            this.companyRepo = companyRepo;
        }

        public PersonModel GetPersonByName(string name)
        {
            return personRepo.GetPersonByName(name);
        }

        public CompanyModel GetCompanyByName(string name)
        {
            return companyRepo.GetCompanyByName(name);
        }
    }
}