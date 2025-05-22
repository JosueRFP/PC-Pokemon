using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public abstract class Monster : MonoBehaviour
{
    EnemyStatus enemyStatus;
    NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        enemyStatus = GetComponent<EnemyStatus>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //CallBattle();
        collision.GetComponent<PlayerMov>().FacesMonster();
        agent.SetDestination(collision.transform.position);
    }
    void CallBattle()
    {
        SceneManager.LoadScene("Battle", LoadSceneMode.Additive);
        GameController.instance.Enemy = enemyStatus.GetTroops();
        GameController.instance.OnBattleCall.Invoke();
    }
}
