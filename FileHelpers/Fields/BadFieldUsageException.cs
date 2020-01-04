using FileHelpers.Core;

namespace FileHelpers.Fields
{
    internal class BadFieldUsageException : BadUsageException
    {
        public BadFieldUsageException(LineInfo line, string message)
            :base(line.ForwardReader.LineNumber, line.mCurrentPos, message)
        {

        }
    }
}