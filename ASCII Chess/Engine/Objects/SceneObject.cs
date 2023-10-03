using ASCIIEngine.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine
{
    internal class SceneObject
    {
        // The name of the object in the scene. Should be unique.
        public string name;

        // Is the scene object active and rendering?
        public bool active = true;

        // Components that are attached to the object.
        public List<Component> components;

        // Renderer that draws scene objects.
        public Renderer? renderer = null;

        /// <summary>
        /// Updates the object if it is active.
        /// </summary>
        public void UpdateObject()
        {
            if (!active)
                return;

            foreach(Component component in components)
                if (component.enabled)
                    component.OnSceneUpdate();
        }

        /// <summary>
        /// Initializes the scene object and all of its components.
        /// </summary>
        public void Initialize()
        {
            foreach(Component component in components)
                component.OnSceneLoad();
        }
    }
}
