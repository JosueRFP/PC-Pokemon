using UnityEngine;

public class PlayerBattle : MonoBehaviour
{
    Attributes[] status;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        status = GameController.instance.Player.GetTroops(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterFinish()
    {
        BattleController.instance.OnCharacterEnterEnd.Invoke();
    }
}
