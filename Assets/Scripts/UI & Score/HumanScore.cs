using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanScore : MonoBehaviour
{

    public GameObject human;
    private Collider humanCollider;
    // Start is called before the first frame update
    void Start()
    {
        humanCollider = human.GetComponent<Collider>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
