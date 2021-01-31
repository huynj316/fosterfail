using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoAnim : MonoBehaviour
{
    public Animator anim;
    private float IdleTimer = 0f;
    private float Speed = 0f;
    private Vector3 LastPosition = Vector3.zero;
    public float MinRunSpeed = 0.002f;
    public string CurrentState = "Idle";
    public string TargetState = "Idle";
    public float DistanceToGround = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, DistanceToGround + 0.1f);

        if (IsGrounded == false)
        {
            TargetState = "Jump Loop";
            IdleTimer = 0f;
        }
        else if (Speed >= MinRunSpeed)
        {
            TargetState = "Run Forward";
            IdleTimer = 0f;
            
        } else {
            TargetState = "Idle";
            IdleTimer += Time.deltaTime;
        }
        
        if (IdleTimer > 10f)
        {
            TargetState = "Sleep Loop";
        }
        else if (IdleTimer > 5f)
        {
            TargetState = "Sit";
        }

        TriggerAnim(TargetState);
    }

    void FixedUpdate()
    {
        Speed = (transform.position - LastPosition).magnitude;
        LastPosition = transform.position;
    }

    void TriggerAnim(string animName)
    {
        if (animName != CurrentState)
        {
            anim.SetTrigger(animName);
            CurrentState = animName;
        }
    }
}
