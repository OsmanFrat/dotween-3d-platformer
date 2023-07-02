using UnityEngine;
using UnityEngine.SceneManagement;
public class GamePanelsScript : MonoBehaviour
{
    public bool paused;
    public bool isGameActive;
    public GameObject mainMenu;
    public GameObject pausePanel;
    public GameObject lvlCompletePanel;
    private void Start() 
    {
        Time.timeScale = 1;
        paused = false;
    }

    private void Update()
    {
        if(!lvlCompletePanel.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ChangePaused();
            }
        }
       
    }
    //Every time this object is activated, the functions inside it run again.

    public void Continue()
    {
        pausePanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    void ChangePaused()
    {
        
        if (!paused)
        {
            paused = true;
            pausePanel.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //savedVolume = AudioListener.volume;
            //AudioListener.volume = 0;
            Time.timeScale = 0;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            paused = false;
            pausePanel.SetActive(false);
            //AudioListener.volume = savedVolume;
            Time.timeScale = 1;

        }
    }

    public void Play()
    {
        mainMenu.SetActive(false);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
//730