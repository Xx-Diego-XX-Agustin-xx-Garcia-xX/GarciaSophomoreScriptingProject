using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatic : MonoBehaviour
{
    public static int playerCount = 0;
    void Start()
    {
        playerCount++;
    }
}
