using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 10;
    public string gender = "male";
    public int HP = "100";
    void Start()
    {
        Debug.Log("Player started!");
        Debug.Log("Player level: " + level);
        Debug.Log("Player gender: " + gender);
        Debug.Log("HP: " + HP);
    }

    void Update()
    {

    }
}
