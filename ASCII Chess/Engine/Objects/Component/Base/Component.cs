using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine
{
    internal abstract class Component
    {
        // Should the component update?
        public bool enabled = true;

        /// <summary>
        /// Called when the scene this component is a part of first loads.
        /// </summary>
        public abstract void OnSceneLoad();

        /// <summary>
        /// Called once per frame if the component is enabled.
        /// </summary>
        public abstract void OnSceneUpdate();
    }
}
