using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
		 * (Christopher Green)
		 * (EnemyDataBase.cs)
		 * (Assignment 10)
		 * (This is the script that creates and utilizes the Dictionary)
*/

public class EnemyDatabase : MonoBehaviour
{

    public Dictionary<string, Enemy> enemies = new Dictionary<string, Enemy>();

    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy("Frank", 20f, "Blue");
        Enemy enemy3 = new Enemy("Bill", 30f, "Orange");

        enemies.Add("Default Enemy", enemy1);
        enemies.Add("Enemy Frank", enemy2);
        enemies.Add("Enemy Bill", enemy3);

        if (enemies.ContainsKey("Enemy Frank"))
        {
            enemies.Remove("Enemy Frank");
        }

        foreach (var enemy in enemies)
        {
            Debug.Log(enemy.Key + enemy.ToString());
        }
    }
}
