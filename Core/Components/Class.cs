using System;
using System.Linq;
using System.Reflection;
using Core.Modifiers;

namespace Core.Components
{
    public class Class : Component<Type, ClassModifier>
    {
        public Class(Type memberInfo)
            : base(memberInfo)
        {
        }

        public static implicit operator Class(Type info) => new Class(info);
        public static explicit operator Type(Class info) => info.MemberInfo;

        public bool Inherit<T>()
            where T : class
        {
            return this.Inherit(typeof(T));
        }

        public bool Inherit(Type type)
        {
            return type.IsAssignableFrom(this.MemberInfo);
        }

        public bool Implements<T>()
            where T : class
        {
            return this.Implements(typeof(T));
        }

        public bool Implements(Type type)
        {
            return type.IsAssignableFrom(MemberInfo);
        }
        
        protected override bool Is(Enum @enum)
        {
            switch (@enum)
            {
                case ClassModifier.Abstract:
                    return this.MemberInfo.IsAbstract;
                case ClassModifier.Internal:
                    return this.MemberInfo.GetTypeInfo().IsNestedFamANDAssem;
                case ClassModifier.Partial:
                    //TODO:
                    return false;
                case ClassModifier.Sealed:
                    return this.MemberInfo.IsSealed;
                case ClassModifier.Public:
                    return this.MemberInfo.IsPublic;
                default:
                    return false;

            }
        }

        public Method[] GetMethods()
        {
            //return this.MemberInfo.GetDeclaringMethods();

            var @publicStatic = this.MemberInfo.GetMethods(BindingFlags.Public | BindingFlags.Static);
            var @public = this.MemberInfo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public2 = this.MemberInfo.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public3 = this.MemberInfo.GetMethods(BindingFlags.NonPublic | BindingFlags.Static);


            return @publicStatic.Concat(@public).Concat(@public2).Concat(@public3).Select(x => (Method)x).ToArray();

            //return null;
        }

        public Field[] GetFields()
        {
            //return this.MemberInfo.GetDeclaringMethods();

            var @publicStatic = this.MemberInfo.GetFields(BindingFlags.Public | BindingFlags.Static);
            var @public = this.MemberInfo.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public2 = this.MemberInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public3 = this.MemberInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Static);


            return @publicStatic.Concat(@public).Concat(@public2).Concat(@public3).Select(x => (Field)x).ToArray();

            //return null;
        }
        
        public Property[] GetProperties()
        {
            //return this.MemberInfo.GetDeclaringMethods();

            var @publicStatic = this.MemberInfo.GetProperties(BindingFlags.Public | BindingFlags.Static);
            var @public = this.MemberInfo.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public2 = this.MemberInfo.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public3 = this.MemberInfo.GetProperties(BindingFlags.NonPublic | BindingFlags.Static);


            return @publicStatic.Concat(@public).Concat(@public2).Concat(@public3).Select(x => (Property)x).ToArray();

            //return null;
        }

        public Constructor[] GetConstructors()
        {
            var @publicStatic = this.MemberInfo.GetConstructors(BindingFlags.Public | BindingFlags.Static);
            var @public = this.MemberInfo.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public2 = this.MemberInfo.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var @public3 = this.MemberInfo.GetConstructors(BindingFlags.NonPublic | BindingFlags.Static);


            return @publicStatic.Concat(@public).Concat(@public2).Concat(@public3).Select(x => (Constructor)x).ToArray();
        }

        public override string ToString()
        {
            return this.MemberInfo.Name;
        }
    }
}