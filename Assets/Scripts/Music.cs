using UnityEngine;

public class Music : MonoBehaviour {

    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<Music>().Length; // counting  number of music players in our game
        if (numMusicPlayer >1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
       
    }
}
