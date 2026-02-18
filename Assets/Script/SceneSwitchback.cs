using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchback : MonoBehaviour
{
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Blades");
        }
    }
}
