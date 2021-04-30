using System;
using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{
    
    public class FieldProblem_ikriv42
    {
        public class D : MarshalByRefObject
        {
            public D()
            {
            }
        }

       [Fact]
       public void GenerateMock_Works_With_MarshalByRef()
       {
           MockRepository.GenerateMock<D>();
       }

        [Fact]
        public void GenerateStub_Works_With_MarshalByRef()
        {
            MockRepository.GenerateStub<D>();
        }
    }
}