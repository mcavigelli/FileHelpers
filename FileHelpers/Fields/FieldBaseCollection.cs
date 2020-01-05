using System.Collections.Generic;

namespace FileHelpers.Fields
{
    /// <summary>An amount of <seealso cref="FieldBase"/>.</summary>
    public sealed class FieldBaseCollection
        : List<FieldBase>
    {
        internal FieldBaseCollection(FieldBase[] fields)
            : base(fields) {}
    }
}