using System;

namespace Rhino.Mocks.Impl.RemotingMock
{
    using System;
    using System.Reflection;
    using Castle.DynamicProxy;

    /// <summary>
    /// Implementation of IInvocation based on remoting proxy
    /// </summary>
    /// <remarks>Some methods are marked NotSupported since they either don't make sense
    /// for remoting proxies, or they are never called by Rhino Mocks</remarks>
    internal class RemotingInvocation : IInvocation
    {
        public RemotingInvocation(object realProxy, object message)
        {
            throw new PlatformNotSupportedException("Remoting is not supported in .NET 5.0");
        }

        public object[] Arguments
        {
            get { return null; }
        }

        public Type[] GenericArguments
        {
            get
            {
                return null;
            }
        }

        public object GetArgumentValue(int index)
        {
            throw new NotSupportedException();
        }

        public MethodInfo GetConcreteMethod()
        {
            return null;
        }

        public MethodInfo GetConcreteMethodInvocationTarget()
        {
            throw new NotSupportedException();
        }

        public object InvocationTarget
        {
            get { throw new NotSupportedException(); }
        }

        public MethodInfo Method
        {
            get { return GetConcreteMethod(); }
        }

        public MethodInfo MethodInvocationTarget
        {
            get { throw new NotSupportedException(); }
        }

        public void Proceed()
        {
            throw new InvalidOperationException("Proceed() is not applicable to remoting mocks.");
        }

        public IInvocationProceedInfo CaptureProceedInfo()
        {
            throw new NotImplementedException();
        }

        public object Proxy
        {
            get { return null; }
        }

        public object ReturnValue
        {
            get;
            set;
        }

        public void SetArgumentValue(int index, object value)
        {
            throw new NotSupportedException();
        }

        public Type TargetType
        {
            get { throw new NotSupportedException(); }
        }
    }
}
