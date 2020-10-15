using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_and_Repository.Initial
{
    public interface ICompanyRepository
    {
        CompanyModel GetCompanyByName(string name);
    }

    public class CompanyRepository : ICompanyRepository
    {
        private readonly ICompanyDataContext companyContext;

        public CompanyRepository(ICompanyDataContext companyContext)
        {
            this.companyContext = companyContext;
        }

        public CompanyModel GetCompanyByName(string name)
        {
            using (var ctx = companyContext.NewContext())
            {
                var company = ctx.Company.First(s => s.Name == name);
                return company;
            }
        }
    }
}