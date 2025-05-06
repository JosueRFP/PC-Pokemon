using UnityEngine;

public abstract class Move : MonoBehaviour
{
    [SerializeField] Mode mode;
    [SerializeField] Type type;
    [SerializeField] int ppDamege;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
        
    int tempPP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tempPP = pp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
