using Microsoft.Practices.Unity;
using TestApplication.Types;

namespace TestApplication.Unity
{
    public class RegisterTypeNonGenericFromToExtraArguments
    {
        public RegisterTypeNonGenericFromToExtraArguments()
        {
            var container = new UnityContainer();
            container.RegisterType(typeof(ICommon), typeof(CommonImpl1), "somename", new InjectionMethod("foo"));
        }
    }
}