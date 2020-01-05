using System;

namespace FileHelpers.Events
{
    /// <summary>
    /// Event args to signal engine failures
    /// </summary>
    public abstract class FileHelpersEventArgs : EventArgs
    {
        /// <summary>
        /// Define an event message for an engine
        /// </summary>
        /// <param name="lineNumber">Line number error occurred</param>
        protected FileHelpersEventArgs(int lineNumber)
        {
            LineNumber = lineNumber;
        }

        /// <summary>The current line number.</summary>
        public int LineNumber { get; private set; }
    }
}