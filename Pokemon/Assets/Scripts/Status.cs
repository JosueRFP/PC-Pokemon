using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attributes 
{
    [SerializeField] string name;
    [SerializeField] int life, speed, level, physicalAttk, specialAttk, physicalDef, specialDef;

    public bool TakeDamege(int damage)
    {
        life -= damage;
        return life <= 0;
        
    }
}

public abstract class Status : MonoBehaviour
{
    [SerializeField] List<Attributes> attributes = new List<Attributes>();

    public Attributes[] GetTroops()
    {
        return attributes.ToArray();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}