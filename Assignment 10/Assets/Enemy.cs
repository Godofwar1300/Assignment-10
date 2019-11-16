using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * (Christopher Green)
		 * (Enemy.cs)
		 * (Assignment 10)
		 * (This script is responsible for creating the variables that the dictionary will use.)
*/


public class Enemy
{

    public string name { get; set; }
    public float speed { get; set; }
    static public int count { get; set; }
    public string color { get; set; }

    public Enemy()
    {
        name = "Jerry";
        speed = 10f;
        count++;
        color = "Green";
    }

    public Enemy(string name, float speed, string color)
    {
        this.name = name;
        this.speed = speed;
        count++;
        this.color = color;
    }

    public override string ToString()
    {
        return name;
    }

}
