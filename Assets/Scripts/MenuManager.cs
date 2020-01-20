using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menuBotton;
    public GameObject panel;
    
    public void ActivePanelCredit()
    {
        menuBotton.SetActive(false);
        panel.SetActive(true);
    }

    public void DisableMenu()
    {
        menuBotton.SetActive(true);
        panel.SetActive(false);
    }

    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
