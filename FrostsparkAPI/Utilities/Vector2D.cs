using System;
using System.Collections.Generic;

namespace Frostspark.API.Utilities
{
    public struct Vector2D<T> : IEquatable<Vector2D<T>>
    {
        public readonly T X;
        public readonly T Y;

        public Vector2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2D<T> d && Equals(d);
        }

        public bool Equals(Vector2D<T> other)
        {
            return EqualityComparer<T>.Default.Equals(X, other.X) &&
                   EqualityComparer<T>.Default.Equals(Y, other.Y);
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(X);
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(Y);
            return hashCode;
        }

        public static bool operator ==(Vector2D<T> left, Vector2D<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2D<T> left, Vector2D<T> right)
        {
            return !(left == right);
        }
    }
}
