using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Monster : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        GameController.instance.OnBattleCall.Invoke();
    }
}
