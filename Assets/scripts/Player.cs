using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 10;
    public string gender = "male";
    public int height = 1280;
    void Start()
    {
        Debug.Log("Player started!");
        Debug.Log("Player level: " + level);
        Debug.Log("Player gender: " + gender);
        Debug.Log("Player height: " + height);
    }

    void Update()
    {

    }
}
