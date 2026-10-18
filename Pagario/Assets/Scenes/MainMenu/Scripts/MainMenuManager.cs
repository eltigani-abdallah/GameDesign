using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartBtn()
    {
        Debug.Log("clicked Start...");
        SceneManager.LoadScene("Gameplay");
    }
    public void CustomizeBtn()
    {
        Debug.Log("clicked Customize...");
    }
    public void SettingsBtn()
    {
        Debug.Log("clicked Settings...");
    }
}
