using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTest : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }
}


/*

Old Video Time:

5:13

Current Video Time:

[ONGOING]

*/