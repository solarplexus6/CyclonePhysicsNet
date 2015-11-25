namespace CyclonePhysicsNet.Core
{
    /// <summary>
    ///     A wrapper around float or double
    /// </summary>
    public struct Real
    {
        // A struct's fields should not be exposed
        #region Private fields

        private readonly double _value;

        #endregion

        // As we are using implicit conversions we can keep the constructor private
        #region Properties

        public static Real Inifinity
        {
            get { return double.PositiveInfinity; }
        }

        #endregion
        #region Ctors

        private Real(double value)
        {
            _value = value;
        }

        #endregion
        /// <summary>
        ///     Implicitly converts a <see cref="double" /> to a Record.
        /// </summary>
        /// <param name="value">The <see cref="double" /> to convert.</param>
        /// <returns>A new Record with the specified value.</returns>
        public static implicit operator Real(double value)
        {
            return new Real(value);
        }

        /// <summary>
        ///     Implicitly converts a Record to a <see cref="double" />.
        /// </summary>
        /// <param name="record">The Record to convert.</param>
        /// <returns>
        ///     A <see cref="System.Int32" /> that is the specified Record's value.
        /// </returns>
        public static implicit operator double(Real record)
        {
            return record._value;
        }
    }
}