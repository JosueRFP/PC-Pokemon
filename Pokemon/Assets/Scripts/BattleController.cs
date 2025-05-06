using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public enum Mode
{
    Physical, Special, Status
}

public enum Type
{
    Normal, Fire, Water, Ghost
}

[System.Serializable]
public class Attack
{
    [SerializeField] string name;
}

public class BattleController : MonoBehaviour
{
    public static BattleController instance; 
    public UnityEvent OnCharacterEnterEnd;
  
    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Battle"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunAway()
    {
        GameController.instance.OnBattleEnd.Invoke();
        SceneManager.UnloadSceneAsync("Battle");
    }
}
