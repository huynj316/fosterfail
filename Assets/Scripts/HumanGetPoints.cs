using UnityEngine;

public class HumanGetPoints : MonoBehaviour
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
        HumanController = GameObject.Find("ThirdPersonHumanController");
    }


    void OnCollisionEnter(Collision collision)
    {

        if (HumanController != null)
        {
            if (collision.transform == HumanController.transform)
            {
                ContactPoint contact = collision.contacts[0];
                Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
                Vector3 position = contact.point;
                Instantiate(CollisionParticles, position, rotation);
                MyScoreController.HumanScore++;

            }
        }
    }
}
