using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("gameplay");
    }

    public void howTo()
    {
        SceneManager.LoadScene("howto");
    }

    public void intro()
    {
        SceneManager.LoadScene("intro");
    }
    public void end()
    {
        SceneManager.LoadScene("endofgame");
    }
}