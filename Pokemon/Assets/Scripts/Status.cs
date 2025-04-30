using UnityEngine;

[System.Serializable]
public class Attributes 
{
    [SerializeField] int life, speed, level;
}

public abstract class Status : MonoBehaviour
{
    [SerializeField] Attributes attributes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}