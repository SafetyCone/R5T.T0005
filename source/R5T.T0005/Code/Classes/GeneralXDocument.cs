using System;
using System.Xml.Linq;


namespace R5T.T0005
{
    /// <summary>
    /// A general <see cref="TypedXDocument"/> type for use there is no specific <see cref="XDocument"/> type.
    /// </summary>
    public class GeneralXDocument : TypedXDocument
    {
        public GeneralXDocument(XDocument value)
            : base(value)
        {
        }
    }
}
