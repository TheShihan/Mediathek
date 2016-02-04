namespace BusinessLogic.Common
{

    /// <summary>
    /// The type of a user
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Administrator user
        /// </summary>
        Administrator,
        /// <summary>
        /// End user (customer)
        /// </summary>
        Customer
    }

    /// <summary>
    /// Form modes
    /// </summary>
    public enum FormMode
    {
        /// <summary>
        /// Use the form as selector
        /// </summary>
        Selector,
        /// <summary>
        /// Use the form as manager
        /// </summary>
        Manager
    }

}