using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_and_Repository.Initial
{
    public interface IPersonRepository
    {
        PersonModel GetPersonByName(string name);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly IPersonDataContext personContext;

        public PersonRepository(IPersonDataContext personContext)
        {
            this.personContext = personContext;
        }

        public PersonModel GetPersonByName(string name)
        {
            using (var ctx = personContext.NewContext())
            {
                var person = ctx.People.First(s => s.Name == name);
                return person;
            }
        }
    }
}