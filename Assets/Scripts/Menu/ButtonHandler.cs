using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public CanvasGroup settingsPanel;
    
    

    public Button startButton;

    public Button settingsButton;

    public Button quitButton;

    public Button confirmSettingsButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        settingsPanel.alpha = 0f;
        settingsPanel.interactable = false;
        settingsPanel.blocksRaycasts = false;
    }
    public void StartClick()
    {
        // Currently kind of 
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void QuitClick()
    {
        
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif

        Application.Quit();
    }

    public void SettingsClick()
    {
        settingsPanel.alpha = 1;
        settingsPanel.interactable = true;
        settingsPanel.blocksRaycasts = true;
    }

    public void ConfirmSettingsClick()
    {
        settingsPanel.alpha = 0;
        settingsPanel.interactable = false;
        settingsPanel.blocksRaycasts = false;
    }
}
