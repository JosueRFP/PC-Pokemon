using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public enum GameStates
{
    WORLD, BATTLE
}
public class GameController : MonoBehaviour
{
    public static GameController instance;
    [SerializeField] GameStates _gameStates = GameStates.WORLD;

    public UnityEvent OnBattleCall, OnBattleEnd;
    public GameStates State { get => _gameStates; set => _gameStates = value; }
    
    [SerializeField] AllyStatus player;
    Attributes[] enemy;

    public AllyStatus Player { get => player; set => player = value; }
    public Attributes[] Enemy { get => enemy; set => enemy = value; }


    [Header("References")]
    [SerializeField] GameObject[] attacks;


    public GameObject GetAttack(string name)
    {
        foreach(var att in attacks)
        {
            if (att.name.Equals(name))
            {
                return att;
            }

        }
        return null;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {// Aciono uma chamada de para quando o evento é acionado
        OnBattleCall.AddListener(SetBattleMode);
        OnBattleEnd.AddListener(SetGameMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetBattleMode()
    {
        _gameStates = GameStates.BATTLE;
    }
    void SetGameMode() 
    {
        _gameStates = GameStates.WORLD;
    }
}
