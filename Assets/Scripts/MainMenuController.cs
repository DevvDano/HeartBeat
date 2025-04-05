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

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuWindows[i].SetActive(false);
            }
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
