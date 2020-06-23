namespace eGaraz.Enums
{
    /// <summary>
    /// Entity status in the database
    /// </summary>
    public enum EntityStatus
    {
        /// <summary>
        /// All entities that don't have property(column) "Deleted" set to true
        /// </summary>
        Existing,

        /// <summary>
        /// All entities that have property(column) "Deleted" set to true
        /// </summary>
        Deleted,

        /// <summary>
        /// All entities independently from "Deleted" property(column)
        /// </summary>
        All
    }
}

