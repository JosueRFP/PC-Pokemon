using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Monster : MonoBehaviour
{
    EnemyStatus enemyStatus;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        enemyStatus = GetComponent<EnemyStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CallBattle();
    }
    void CallBattle()
    {
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        GameController.instance.Enemy = enemyStatus.GetTroops();
        GameController.instance.OnBattleCall.Invoke();
    }
}
