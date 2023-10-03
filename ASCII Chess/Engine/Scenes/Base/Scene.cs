using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ASCIIEngine.SceneManagement;

namespace ASCIIEngine
{
    // A game scene that contains 
    internal abstract class Scene
    {
        // ID used for getting scene from SceneManager.
        public string id = "";

        // Objects that are in the scene.
        public List<SceneObject> objects;

        /// <summary>
        /// Default constructor for a new scene instance.
        /// </summary>
        public Scene()
        {
            id = "NewScene";
            objects = new List<SceneObject>();
        }

        /// <summary>
        /// Constructor a new scene instance with objects.
        /// </summary>
        public Scene(string id, List<SceneObject> objects)
        {
            this.id = id;
            this.objects = objects;
        }

        /// <summary>
        /// Template constructor for creating a new scene instance.
        /// </summary>
        public Scene(Scene scene)
        {
            id = scene.id;
            objects = scene.objects;
        }
    }
}
