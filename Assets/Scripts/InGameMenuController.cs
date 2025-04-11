using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuWindow;
    public bool menuToggle = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        menuToggle = !menuToggle;
        menuWindow.SetActive(menuToggle);
    }

    public void SettingsButton(GameObject settingsWindow)
    {
        ToggleMenu();
        settingsWindow.SetActive(true);
    }

    public void BackButton(GameObject closeWindow)
    {
        closeWindow.SetActive(false);
        ToggleMenu();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void QuitButton()
    {
        Application.Quit();
    }

}
