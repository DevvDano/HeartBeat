using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject[] menuWindows;
    public void ToggleWindow(GameObject targetWindow)
    {
        for (int i = 0; i < menuWindows.Length; i++)
        {
            menuWindows[i].SetActive(menuWindows[i] == targetWindow);
        }

    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton(GameObject closeWindow)
    {
        closeWindow.SetActive(false);
    }
}
