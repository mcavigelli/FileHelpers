namespace FileHelpers.Core
{
    internal interface IForwardReader
    {
        string ReadNextLine();
        int LineNumber { get; }
    }
}