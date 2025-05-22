using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 movement;
    Rigidbody2D rb;
    bool isLocked;

    public bool IsLocked { get => isLocked; }

    public void FacesMonster()
    {
        isLocked = true;
        rb.linearVelocity = Vector2.zero;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        GameController.instance.OnBattleCall.AddListener(InitializedBattle);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLocked)
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (GameController.instance.State.Equals(GameStates.BATTLE))
              return;
        
        rb.linearVelocity = movement * speed;
    }

    void InitializedBattle()
    {
        rb.linearVelocity = Vector2.zero;
    }
}
