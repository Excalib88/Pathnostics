using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Pathnostics.Web.Extensions;

public static class EnumExtensions
{
    public static KeyValuePair<string, string> GetDisplayNamePair(this Enum? enumValue)
    {
        return new KeyValuePair<string,string>(enumValue!.ToString(), enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName()!);
    }

    public static Dictionary<string, string> GetDisplayNamePairs<T>() where T: Enum
    {
        var dict = new Dictionary<string, string>();

        foreach (var enumValue in Enum.GetValues(typeof(T)))
        {
            var enumType = enumValue is T type ? type : default;
            var displayName = enumType.GetDisplayNamePair();
            dict.Add(displayName.Key,displayName.Value);
        }

        return dict;
    }
}