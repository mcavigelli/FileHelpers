namespace FileHelpers.Events
{
    // ----  Read Operations  ----
    /// <summary>
    /// Called in read operations just before the record string is translated to a record.
    /// </summary>
    /// <param name="e">The event data.</param>
    public delegate void BeforeReadHandler<T>(BeforeReadEventArgs<T> e) where T : class;

    /// <summary>
    /// Called in read operations just after the record was created from a record string.
    /// </summary>
    /// <param name="e">The event data.</param>
    public delegate void AfterReadHandler<T>(AfterReadEventArgs<T> e) where T : class;


    // ----  Write Operations  ----

    /// <summary>
    /// Called in write operations just before the record is converted to a string to write it.
    /// </summary>
    /// <param name="e">The event data.</param>
    public delegate void BeforeWriteHandler<T>(BeforeWriteEventArgs<T> e) where T : class;

    /// <summary>
    /// Called in write operations just after the record was converted to a string.
    /// </summary>
    /// <param name="e">The event data.</param>
    public delegate void AfterWriteHandler<T>(AfterWriteEventArgs<T> e) where T : class;
}