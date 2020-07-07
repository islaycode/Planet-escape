﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        DeathSquence();
    }
    private void DeathSquence()
    {
        print("Player Died");
        SendMessage("OnPlayerDeath");
    }
}
