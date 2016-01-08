using System;
using System.Reflection;

public static class GetPropertyHelper
    {
        public static PropertyInfo GetProperty(this Type type, string propertyName)
        {
            return type.GetTypeInfo().GetDeclaredProperty(propertyName);
        }
    }
