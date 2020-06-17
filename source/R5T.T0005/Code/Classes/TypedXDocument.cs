using System;
using System.Xml.Linq;

using R5T.Amphipolis;


namespace R5T.T0005
{
    public abstract class TypedXDocument : Typed<XDocument>
    {
        public TypedXDocument(XDocument value)
            : base(value)
        {
        }
    }
}
