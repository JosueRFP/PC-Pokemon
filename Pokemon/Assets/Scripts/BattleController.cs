using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Battle"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
