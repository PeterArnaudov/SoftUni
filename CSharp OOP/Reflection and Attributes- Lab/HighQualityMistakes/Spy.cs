using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] requestedFields)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);
        FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        var classInstance = Activator.CreateInstance(type);

        sb.AppendLine($"Class under investigation: {className}");

        foreach (var field in fields.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);

        var fields = type.GetFields();
        foreach (var field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
        {
            if (!method.IsPublic)
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
        }

        foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
        {
            if (!method.IsPrivate)
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
        }

        return sb.ToString().TrimEnd();
    }
}
