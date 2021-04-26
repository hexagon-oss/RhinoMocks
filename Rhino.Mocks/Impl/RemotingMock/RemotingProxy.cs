namespace Rhino.Mocks.Impl.RemotingMock
{
    using System;
    using System.Reflection;
    using Castle.DynamicProxy;
    using Rhino.Mocks.Interfaces;

    internal class RemotingProxy
    {
        private readonly IInterceptor _interceptor;
        private readonly IMockedObject _mockedObject;

        public RemotingProxy(Type type, IInterceptor interceptor, IMockedObject mockedObject)
        {
            _interceptor = interceptor;
            _mockedObject = mockedObject;
            throw new PlatformNotSupportedException("Remoting is not supported in .NET 5.0");
        }

        public IMockedObject MockedObject
        {
            get { return _mockedObject; }
        }

        public object GetTransparentProxy()
        {
            return null;
        }
    }
}
