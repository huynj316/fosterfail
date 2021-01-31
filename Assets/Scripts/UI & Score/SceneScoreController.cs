using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScoreController : MonoBehaviour
{
    public List<GameObject> interactableDObjs = new List<GameObject>();
    public List<GameObject> interactableHObjs = new List<GameObject>();
    //private DoggoGetPoints doggoGetPoints; 
    // Start is called before the first frame update
    void Start()
    {
        //doggo point setup
        GameObject[] dInteractables = interactableDObjs.ToArray();

        dInteractables = GameObject.FindGameObjectsWithTag("dog");

        foreach (GameObject obj in dInteractables)
        {
            Debug.Log("obj" + obj.name);
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<DoggoGetPoints>();

        }

        //human point setup
        GameObject[] hInteractables = interactableHObjs.ToArray();

        hInteractables = GameObject.FindGameObjectsWithTag("human");

        foreach (GameObject obj in hInteractables)
        {
            Debug.Log("obj" + obj.name);
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<HumanGetPoints>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
