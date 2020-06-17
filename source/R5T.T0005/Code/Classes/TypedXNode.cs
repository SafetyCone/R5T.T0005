using System;
using System.Xml.Linq;

using R5T.Amphipolis;


namespace R5T.T0005
{
    public class TypedXNode : Typed<XNode>
    {
        public TypedXNode(XNode value)
            : base(value)
        {
        }
    }
}
