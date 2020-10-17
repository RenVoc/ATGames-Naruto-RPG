using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem {
    private int level; // Уровень.
    private int experience; // Опыт.
    private int experienceToNextLevel; // Опыт до следующего уровня.

    public LevelSystem() {
        // Обнуляем переменные, до следующего уровня надо 100 опыта накопить.
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
        return level; // Для отрисовки уровня возвращаем уровень (цифру) в функцию для ее вывода в интерфейсе юнити.
    }
}
