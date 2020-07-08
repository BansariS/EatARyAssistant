
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOnChangeOne : MonoBehaviour
{
   public void changehumantoar(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
