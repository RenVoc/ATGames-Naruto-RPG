using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem {
    private int level; // уровень.
    private int experience; // опыт.
    private int experienceToNextLevel; // опыт до следующего уровня.

    public LevelSystem() {
        // обнуляем переменные, до следующего уровня надо 100 опыта накопить
        level = 0;
        experience = 0;
        experienceToNextLevel = 100;
    }

    public void AddExperience(int amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            level++;
            experience -= experienceToNextLevel;
        }
    }

    public int GetLevelNumber()
    {
        return level; // для отрисовки уровня возвращаем уровень (цифру) в функцию для ее вывода в интерфейсе юнити.
    }
}
