using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleCoreMvcApplication.Models;

namespace PeopleCoreMvcApplication.Repositories
{
    public interface IPeopleRepository
    {
        IList<Person> GetPeople();

        Task<IList<Person>> GetPeopleAsync();

        Person GetPersonById(Guid id);

        Task<Person> GetPersonByIdAsync(Guid id);

        int InsertPerson(Person person);

        Task<int> InsertPersonAsync(Person person);

        int UpdatePerson(Person person);

        Task<int> UpdatePersonAsync(Person person);

        int DeletePerson(Guid id);

        Task<int> DeletePersonAsync(Guid id);

    }
}