using ASCIIEngine;
using ASCIIEngine.Animation;
using ASCIIEngine.Input;
using ASCIIEngine.Rendering;
using ASCIIEngine.SceneManagement;
using ASCII_Chess.Scenes;

// Load first scene.
SceneManager.LoadScene(new SplashScreenScene());


// Initialize console output.
ConsoleOutput.InitializeOutput();



// Rendering, animation, and input loop.
while (true)
{
    // Get last-pressed key.
    InputManager.SetKey(Console.ReadKey().Key);

    // Update objects and scenes.

    // Render scene objects.

    // Render UI.

    // Clear input.
    InputManager.Clear();
   
}



