using UnityEngine;

public class DoggoGetPoints : MonoBehaviour
{
    public ScoreController MyScoreController;
    public Object CollisionParticles;
    public GameObject DoggoController;
    public GameObject HumanController;

    // Start is called before the first frame update
    void Start()
    {
        MyScoreController = FindObjectOfType<ScoreController>();
        CollisionParticles = Resources.Load("Prefab/ParticleSystem");
        DoggoController = GameObject.Find("ThirdPersonDoggoController");
        HumanController = GameObject.Find("ThirdPersonHumanController");
    }


    void OnCollisionEnter(Collision collision)
    {
        if (DoggoController != null)
        {
            if (collision.transform == DoggoController.transform)
            {
                ContactPoint contact = collision.contacts[0];
                Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
                Vector3 position = contact.point;
                Instantiate(CollisionParticles, position, rotation);
                MyScoreController.DoggoScore++;

            }
        }

    }
}
