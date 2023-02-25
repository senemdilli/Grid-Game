using UnityEngine;
using UnityEngine.SceneManagement;

public class RefreshButton : MonoBehaviour
{
    public void RefreshScene()
    {
        SceneManager.LoadScene(1);
        print("The button is working.");
    }
}
