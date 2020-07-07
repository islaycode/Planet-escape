using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In seconds")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")] [SerializeField] GameObject deathFx;

    void OnTriggerEnter(Collider other)
    {
        DeathSquence();
        deathFx.SetActive(true);
        Invoke("ReloadLevel", levelLoadDelay);
    }
    private void DeathSquence()
    {
        print("Player Died");
        SendMessage("OnPlayerDeath");
    }
    private void ReloadLevel() // string reference
    {
        SceneManager.LoadScene(1);
    }
}
