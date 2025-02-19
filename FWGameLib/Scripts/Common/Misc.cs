using System;
using UnityEngine;

namespace FWGameLib.Common
{
    public static class Misc
    {
        public static bool IsInLayerMask(this GameObject obj, LayerMask mask) => (mask.value & (1 << obj.layer)) != 0;
        public static bool IsInLayerMask(int layer, LayerMask mask) => (mask.value & (1 << layer)) != 0;

        /// <summary>
        /// Checks if a GameObject has been destroyed.
        /// https://discussions.unity.com/t/how-to-detect-if-a-gameobject-has-been-destroyed/2385/4
        /// </summary>
        /// <param name="gameObject">GameObject reference to check for destructedness</param>
        /// <returns>If the game object has been marked as destroyed by UnityEngine</returns>
        public static bool IsDestroyed(this GameObject gameObject)
        {
            // UnityEngine overloads the == operator for the GameObject type
            // and returns null when the object has been destroyed, but
            // actually the object is still there but has not been cleaned up yet
            // if we test both we can determine if the object has been destroyed.
            return gameObject == null && !ReferenceEquals(gameObject, null);
        }

        /// <summary>
        /// Conditionally execute the true or false action based on the passed variable
        /// </summary>
        /// <param name="condition">The bool controlling which action to execute</param>
        /// <param name="trueAction">A callback executed for a true value</param>
        /// <param name="falseAction">A callback executed for a false value</param>
        /// <returns></returns>
        public static void Conditionally(bool condition, Action trueAction, Action falseAction)
        {
            if (condition)
            {
                trueAction();
            }
            else
            {
                falseAction();
            }
        }
    }
}