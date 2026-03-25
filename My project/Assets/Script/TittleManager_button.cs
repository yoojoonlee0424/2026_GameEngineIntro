using UnityEngine;
using UnityEngine.SceneManagement;

public class TittleManager_button : MonoBehaviour
{

    public GameObject help;
    public void ButtonLog()
    {
        Debug.Log("1");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void CloseGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }



    public void OpenHelp()
    {
        help.SetActive(true);
    }

    public void CloseHelp()
    {
        help.SetActive(false);
    }



    public void Start() // 도움말 숨기기
    {
        help.SetActive(false);
    }
}
