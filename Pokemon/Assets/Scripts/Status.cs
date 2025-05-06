using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attributes 
{
    [SerializeField] string name;
    [SerializeField] int life, speed, level, physicalAttk, specialAttk, physicalDef, specialDef;
    [SerializeField] string[] starterMoves;

    public string[] StarterMoves { get => starterMoves;}

    public bool TakeDamege(int damage)
    {
        life -= damage;
        return life <= 0;
        
    }
}

public abstract class Status : MonoBehaviour
{
    [SerializeField] List<Attributes> attributes = new List<Attributes>();
        Transform moves;

    public Attributes[] GetTroops()
    {
        return attributes.ToArray();
    }
    protected  void Start()
    {
        moves = transform.GetChild(0);
        foreach (Attributes move in attributes)
        {
            foreach(string item in move.StarterMoves)
            {// Instancia cada golpe de cada pokemon que existe na lista
                Instantiate(GameController.instance.GetAttack(item), moves);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}