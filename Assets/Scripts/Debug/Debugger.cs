using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Debugging
{
    /// <summary>
    /// Holds helper functions for debugging in editor or debug builds.
    /// </summary>
    public static class Debugger
    {
        #region LogHelpers
        /// <summary>
        /// Logs message only if its debug parameter is set to true.
        /// </summary>
        /// <param name="msg">Message that will be logged.</param>
        /// <param name="debug">Whether the function should run. (Allows for easily toggling off debug logging per script).</param>
        public static void Log(object msg, bool debug)
        {
            if (debug && Debug.isDebugBuild)
            {
                Debug.Log(msg);
            }
        }
        /// <summary>
        /// Logs message only if its debug parameter is set to true.
        /// </summary>
        /// <param name="msg">Message that will be logged.</param>
        /// <param name="debug">Whether the function should run. (Allows for easily toggling off debug logging per script).</param>
        public static void LogWarning(object msg, bool debug)
        {
            if(debug && Debug.isDebugBuild)
            {
                Debug.LogWarning(msg);
            }
        }
        /// <summary>
        /// Logs message only if its debug parameter is set to true.
        /// </summary>
        /// <param name="msg">Message that will be logged.</param>
        /// <param name="debug">Whether the function should run. (Allows for easily toggling off debug logging per script).</param>
        public static void LogError(object msg, bool debug)
        {
            if(debug && Debug.isDebugBuild)
            {
                Debug.LogError(msg);
            }
        }

        #endregion LogHeleprs
        #region AssertHelpers
        /// <summary>
        /// Asserts condition only if its debug parameter is set to true.
        /// </summary>
        /// <param name="cond">Condition that will be evaluated.</param>
        /// <param name="debug">Whether the function should run. (Allows for easily toggling off debug logging per script).</param>
        public static void Assert(bool cond, bool debug)
        {
            if(debug && Debug.isDebugBuild)
            {
                Debug.Assert(cond);
            }
        }
        /// <summary>
        /// Asserts condition only if its debug parameter is set to true.
        /// </summary>
        /// <param name="cond">Condition that will be evaluated.</param>
        /// <param name="msg">Message that will be logged to the Unity console.</param>
        /// <param name="debug">Whether the function should run. (Allows for easily toggling off debug logging per script).</param>
        public static void Assert(bool cond, object msg, bool debug)
        {
            if(debug && Debug.isDebugBuild)
            {
                Debug.Assert(cond, msg);
            }
        }
        #endregion AssertHelpers
        #region CollectionHelpers
        /// <summary>
        /// Logs the contents of a collection if its debug parameter is set to true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list whose contents are being logged.</param>
        /// <param name="debug">Whether the fucntion should run. (Allows for easily toggling off debug logging per script.)</param>
        public static void LogCollection<T>(List<T> list, bool debug)
        {
            if(debug && Debug.isDebugBuild)
            {
                object msg = null;
                foreach(var obj in list)
                {
                    msg += obj.ToString();
                }
                Debug.Log(msg);
            }
        }
        #endregion CollectionHelpers
    }
}









