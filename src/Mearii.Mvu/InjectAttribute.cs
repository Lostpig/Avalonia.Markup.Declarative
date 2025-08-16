using System;

namespace Mearii.Mvu;

/// <summary>
/// Used by Mvu component base to inject services into components
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class InjectAttribute : Attribute
{
}
