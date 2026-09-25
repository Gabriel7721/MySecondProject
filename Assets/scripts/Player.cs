using UnityEngine;

public class Player : MonoBehaviour
{
    public int potioncarry = 15;
    public int level = 10;
    public string gender = "male";
    void Start()
    {
        Debug.Log("Player started!");
        Debug.Log("Player level: " + level);
        Debug.Log("Player gender: " + gender);
        Debug.Log("Player potion carry: " + potioncarry);
    }

    void Update()
    {

    }
}
