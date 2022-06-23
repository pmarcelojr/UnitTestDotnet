using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class TestCollectionOrderer : ITestCollectionOrderer
    {
        // Order os testes para executar sequencialmente / precisa adicionar um assemblie information, ver aula 21 do curso
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(x => x.DisplayName);
        }
    }
}
