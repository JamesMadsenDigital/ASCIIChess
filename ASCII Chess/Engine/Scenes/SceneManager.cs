using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine.SceneManagement
{
    /// <summary>
    /// Manages switching to and from scenes.
    /// </summary>
    internal static class SceneManager
    {
        // The scene that is current active and rendering.
        public static Scene activeScene = new DefaultScene();

        /// <summary>
        /// Loads a new scene.
        /// </summary>
        /// <param name="scene"></param>
        public static void LoadScene(Scene scene)
        {
            activeScene = scene;

            // Initialize all objects in the scene.
            foreach(SceneObject sceneObject in activeScene.objects)
                sceneObject.Initialize();

        }
    }
}
