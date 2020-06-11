using System;
using System.Xml.Linq;

using R5T.Magyar.Xml;


namespace R5T.T0005
{
    public static class TypedXElementExtensions
    {
        public static string GetChildValue(this TypedXElement typedXElement, string childName)
        {
            var output = typedXElement.Value.GetChildValue(childName);
            return output;
        }

        public static bool HasChild(this TypedXElement typedXElement, string childName, out XElement child)
        {
            var hasChild = typedXElement.Value.HasChild(childName, out child);
            return hasChild;
        }
    }
}
