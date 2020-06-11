using System;
using System.Xml.Linq;


namespace R5T.T0005
{
    public static class XElementExtensions
    {
        public static GeneralXElement AsGeneralXElement(this XElement xElement)
        {
            var generalElement = new GeneralXElement(xElement);
            return generalElement;
        }
    }
}
