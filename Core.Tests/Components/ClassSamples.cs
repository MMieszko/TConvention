using System;
using System.Threading.Tasks;

namespace Core.Tests.Components
{
    public class PublicClass
    {
        public void VoidMethod() { }
        public static void StaticVoidMethod() { }
        public async Task AsyncTaskMethod() { await Task.Delay(1); }
        private object PrivateReturnObjectMethod() { return new object(); }
        protected int ProtectedReturnIntMethod() { return new int(); }
        internal string InternalReturnStringMethod() { return new string("asd"); }
        private static string StaticPrivateReturnsString() => "";
    }

    internal class InternalClass
    {

    }

    public abstract class PublicAbstractClass
    {
        public Task<string> PublicReturnTaskOfString()
        {
            return null;
        }

        public string FullPublicString524607662 { get; set; }
        public string PublicPrivateSetString84507304 { get; private set; }
        public string PublicProtectedSetString656379277 { get; protected set; }
        public string PublicReadonlyString1000452764 { get; }
        public static string FullyPublicStatic { get; set; }
        protected abstract bool AbstractProtectedReadonly382249969 { get; }
    }

    public sealed class PublicSealedClass
    {
        private int _privateInt;
        private const int PrivateConstInt = default;
        public int PublicInt;
        protected string ProtectedString;
        internal object InternalObject;
        public static int PublicStaticInt;
        private readonly int PrivateReadonlyInt;
    }

    public partial class PublicPartialClass
    {

    }

    public partial class PublicPartialClass
    {

    }

    public class PublicStandaloneClass
    {
        static PublicStandaloneClass()
        {

        }

        internal PublicStandaloneClass(object param1)
        {

        }

        public PublicStandaloneClass(object param1, object param2)
        {

        }

        private PublicStandaloneClass()
        {

        }
    }

    public class PublicInheritFromStandaloneClass : PublicStandaloneClass
    {
        internal PublicInheritFromStandaloneClass(object param1) : base(param1)
        {
        }

        public PublicInheritFromStandaloneClass(object param1, object param2) : base(param1, param2)
        {
        }
    }

    public interface IPublicStandaloneInterface
    {

    }

    public class PublicClassImplementsStandaloneInterface : IPublicStandaloneInterface
    {

    }

    public class TestAttribute : Attribute
    {
        public void M1() { }
        public Task M2() { return Task.CompletedTask; }

        public Task<int> M3()
        {
            return Task.FromResult(1);
        }

        private string M4()
        {
            return "4";
        }
    }

    [TestAttribute]
    public class PublicClassWithTestAttribute
    {

    }
}