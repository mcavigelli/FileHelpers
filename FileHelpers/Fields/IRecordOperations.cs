using FileHelpers.Core;

namespace FileHelpers.Fields
{
    internal interface IRecordOperations
    {
        IRecordOperations Clone(IRecordInfo res);
        string RecordToString(object record);
        object[] RecordToValues(object record);

        object CreateRecord();

        /// <summary>
        /// Extract fields from record and assign values to the object
        /// </summary>
        /// <param name="record">Object to assign to</param>
        /// <param name="line">Line of data</param>
        /// <param name="values">Array of values extracted</param>
        /// <returns>true if we processed the line and updated object</returns>
        bool StringToRecord(object record, LineInfo line, object[] values);

        string RecordValuesToString(object[] lastRecordValues);
    }
}