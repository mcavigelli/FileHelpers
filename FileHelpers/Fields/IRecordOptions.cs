namespace FileHelpers.Fields
{
    internal interface IRecordOptions
    {
        int FieldCount { get; }
        FieldBaseCollection Fields { get; }
    }
}