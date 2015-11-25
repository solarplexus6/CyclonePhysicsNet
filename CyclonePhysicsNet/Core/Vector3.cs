using System;

namespace CyclonePhysicsNet.Core
{
    /// <summary>
    ///     Holds a vector in three dimensions.
    /// </summary>
    public struct Vector3
    {
        #region Private fields

        /// <summary>
        ///     Holds the value along the x axis.
        /// </summary>
        public readonly Real X;

        /// <summary>
        ///     Holds the value along the y axis.
        /// </summary>
        public readonly Real Y;

        /// <summary>
        ///     Holds the value along the z axis.
        /// </summary>
        public readonly Real Z;

        #endregion
        #region Ctors

        /// <summary>
        ///     The explicit constructor creates a vector with the given components
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(Real x, Real y, Real z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion
        #region Public methods

        public Vector3 Invert()
        {
            return new Vector3(-X, -Y, -Z);
        }

        #endregion
    }
}