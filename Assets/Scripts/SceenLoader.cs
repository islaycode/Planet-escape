using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("LoadFirstScene", 2f);
	}
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
