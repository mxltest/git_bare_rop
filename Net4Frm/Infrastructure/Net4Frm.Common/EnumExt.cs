using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System
{
    public static class EnumExt
    {
        public static string GetDescription(this Enum sourceEnum)
        {
            object enumValue = (object)sourceEnum;
            Type type = sourceEnum.GetType();
            return type.GetEnumDescription(enumValue);

        }

        public static string GetEnumDescription(this Type enumType, object enumValue)
        {
            try
            {
                FieldInfo fieldInfo = enumType.GetField(Enum.GetName(enumType, enumValue));
                var attributions = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                return attributions.Length > 0 ? attributions[0].Description : Enum.GetName(enumType, enumValue);
            }
            catch (Exception)
            {
                return enumValue == null ? "NULL" : enumValue.ToString();
            }
        }

        public static string GetEnumName(this Type enumType, object enumValue)
        {
            try
            {
                return Enum.GetName(enumType, enumValue);
            }
            catch (Exception)
            {
                return "UNKNOWN";
            }
        }
    }
}
