using UnityEngine;

public class EnemyBattle : MonoBehaviour
{
    Attributes[] status;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        status = GameController.instance.Enemy;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}