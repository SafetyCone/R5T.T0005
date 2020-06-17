using System;
using System.Xml.Linq;


namespace R5T.T0005
{
    /// <summary>
    /// A general <see cref="TypedXNode"/> type for use there is no specific <see cref="XNode"/> type.
    /// </summary>
    public class GeneralXNode : TypedXNode
    {
        public GeneralXNode(XNode value)
            : base(value)
        {
        }
    }
}
