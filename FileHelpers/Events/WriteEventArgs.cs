using System.ComponentModel;

namespace FileHelpers.Events
{
    /// <summary>Base class of <see cref="BeforeWriteEventArgs{T}"/> and <see cref="AfterWriteEventArgs{T}"/></summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class WriteEventArgs
        : FileHelpersEventArgs
    {
        /// <summary>
        /// Write events are based on this
        /// </summary>
        /// <param name="lineNumber">Record number</param>
        internal WriteEventArgs(int lineNumber)
            : base(lineNumber)
        {
        }

    }
}