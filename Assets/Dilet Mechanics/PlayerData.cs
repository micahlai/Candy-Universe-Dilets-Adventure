using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData {

    public int health;
    public bool water;
    public bool thunder;
    public bool fire;
    public bool ice;
    public bool rock;
    public bool nan;
    public bool start;
    public bool inDungeon;
    public float[] position;
    
    public PlayerData (Ouch player)
    {
        water = player.water;
        thunder = player.thunder;
        fire = player.fire;
        ice = player.ice;
        rock = player.rock;
        nan = player.nan;
        start = player.start;
        inDungeon = player.inDungeon;
        health = player.health;
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}
