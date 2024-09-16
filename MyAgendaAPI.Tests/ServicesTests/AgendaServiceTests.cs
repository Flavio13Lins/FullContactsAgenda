using Xunit;
using Moq;
using MyAgendaAPI.Data;
using MyAgendaAPI.Services;
using MyAgendaAPI.Repositories;
using MyAgendaAPI.Models;
using System.Collections.Generic;

namespace MyAgendaAPI.Tests.ServicesTests
{
    public class ContactTests
    {

        // Simple tests examples of constructors
        [Fact]
        public void ContactTestsOne()
        {
            Contact cTemp = new Contact(Id: 1, Name: "Teste Meu Nome", Email: "meunometeste@email.com", Phone: "+55-12-4569-7890" );
            
            Assert.NotEqual(null, cTemp);

        }

        [Fact]
        public void ContactTestsNoArgs()
        {
            Contact cTemp = new Contact();
            
            Assert.NotEqual(null, cTemp);

        }

    }
}
