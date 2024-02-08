using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warband : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyHidden();
        Humanoid orc = new Orc();
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
