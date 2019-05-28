using PeopleCoreMvcApplication.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleCoreMvcApplication.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly IConfiguration _config;

        public PeopleRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public IList<Person> GetPeople()
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "SELECT * FROM People";
                conn.Open();
                var result = conn.Query<Person>(sql);
                return result.ToList();
            }
        }

        public async Task<IList<Person>> GetPeopleAsync()
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "SELECT * FROM People";
                conn.Open();
                var result = await conn.QueryAsync<Person>(sql);
                return result.ToList();
            }
        }

        public Person GetPersonById(Guid id)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "SELECT * FROM People WHERE Id=@Id";
                conn.Open();
                var result = conn.Query<Person>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<Person> GetPersonByIdAsync(Guid id)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "SELECT * FROM People WHERE Id=@Id";
                conn.Open();
                var result = await conn.QueryAsync<Person>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public int InsertPerson(Person person)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "INSERT INTO People (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                conn.Open();
                return conn.Execute(sql, new { person.Name, person.Phone, person.Email });
            }
        }

        public async Task<int> InsertPersonAsync(Person person)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "INSERT INTO People (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                conn.Open();
                return await conn.ExecuteAsync(sql, new { person.Name, person.Phone, person.Email });
            }
        }

        public int UpdatePerson(Person person)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "UPDATE People SET Name = @Name, Phone = @Phone, Email = @Email WHERE Id = @Id";
                conn.Open();
                return conn.Execute(sql, new { person.Name, person.Phone, person.Email, person.Id });
            }
        }

        public async Task<int> UpdatePersonAsync(Person person)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "UPDATE People SET Name = @Name, Phone = @Phone, Email = @Email WHERE Id = @Id";
                conn.Open();
                return await conn.ExecuteAsync(sql, new { person.Name, person.Phone, person.Email, person.Id });
            }
        }

        public int DeletePerson(Guid id)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "DELETE FROM People WHERE Id = @Id";
                conn.Open();
                return conn.Execute(sql, new { id });
            }
        }

        public async Task<int> DeletePersonAsync(Guid id)
        {
            using (IDbConnection conn = Connection)
            {
                string sql = "DELETE FROM People WHERE Id = @Id";
                conn.Open();
                return await conn.ExecuteAsync(sql, new { id });
            }
        }
    }
}
