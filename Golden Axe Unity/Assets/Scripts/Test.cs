using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        // тут проверка для системы уровней будет писаться и другие тесты.
        LevelSystem levelSystem = new LevelSystem();
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(50);
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(60);
        Debug.Log(levelSystem.GetLevelNumber());
    }
}
