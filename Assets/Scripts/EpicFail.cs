using UnityEngine;
using UnityEngine.SceneManagement;

public class EpicFail : MonoBehaviour
{
    GameManager sammy;

    // Start is called before the first frame update
    void Start()
    {
        sammy = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            // write something to the Console just to make 
            // sure this function is being called
            Debug.Log("there went HexBoi");


            sammy.numLivesLeft--;


            if (sammy.numLivesLeft < 0) {

                SceneManager.LoadScene("GameOver");

            } else {
                // use SceneManager to load the CURRENT scene again (a reset)
                // the LoadScene function just wants a NUMBER of the scene to load
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
