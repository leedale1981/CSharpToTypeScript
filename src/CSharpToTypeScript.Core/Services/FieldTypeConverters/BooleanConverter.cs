using System.Collections.Generic;
using CSharpToTypeScript.Core.Models.FieldTypes;

namespace CSharpToTypeScript.Core.Services.FieldTypeConverters
{
    public class BooleanConverter : BasicTypeConverterBase<Boolean>
    {
        protected override IEnumerable<string> ConvertibleFrom { get; } = new List<string>
        {
            "Boolean", "bool"
        };
    }
}