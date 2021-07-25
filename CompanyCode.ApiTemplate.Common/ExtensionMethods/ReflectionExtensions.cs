using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CompanyCode.ApiTemplate.Common.ExtensionMethods
{
    public static class ReflectionExtensions
    {
        public static Dictionary<string, object> GetProperties<TDerived, TBase>()
        {
            return Assembly
                .GetAssembly(typeof(TDerived))
                ?.GetTypes()
                .OrderBy(x => x.IsSubclassOf(typeof(TBase)))
                .SelectMany(x => x.GetProperties())
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                //.ToDictionary(x => x.Name, x => (object)x.Name);
                .ToDictionary(x => x.Name, x => x.GetValue(x.Name));
        }

        public static object GetPropertyValue(this object T, string propName) =>
            T.GetType()
                .GetProperty(propName) == null ? null : T.GetType()
                .GetProperty(propName)
                ?.GetValue(T, null);
    }
}