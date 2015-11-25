using System;
using CyclonePhysicsNet.Core;

namespace CyclonePhysicsNet
{
    /// <summary>
    ///     A particle is the simplest object that can be simulated in the
    ///     physics system.
    ///     It has position data (no orientation data), along with
    ///     velocity. It can be integrated forward through time, and have
    ///     linear forces, and impulses applied to it. The particle manages
    ///     its state and allows access through a set of methods.
    /// </summary>
    internal class Particle
    {
        #region Private fields

        /// <summary>
        ///     Holds the acceleration of the particle. This value
        ///     can be used to set acceleration due to gravity (its primary
        ///     use), or any other constant acceleration.
        /// </summary>
        protected Vector3 _acceleration;

        /// <summary>
        ///     Holds the amount of damping applied to linear
        ///     motion. Damping is required to remove energy added
        ///     through numerical instability in the integrator.
        /// </summary>
        protected Real _damping;

        /// <summary>
        ///     Holds the linear position of the particle in
        ///     world space.
        /// </summary>
        protected Vector3 _position;

        /// <summary>
        ///     Holds the linear velocity of the particle in
        ///     world space.
        /// </summary>
        protected Vector3 _velocity;

        private Real _inverseMass;

        #endregion
        #region Properties

        public Real InverseMass
        {
            get { return _inverseMass; }
            set { _inverseMass = value; }
        }

        public Real Mass
        {
            get
            {
                if (_inverseMass == 0)
                {
                    return Real.Inifinity;
                }
                return 1.0/_inverseMass;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _inverseMass = (1.0)/value;
            }
        }

        #endregion
    }
}