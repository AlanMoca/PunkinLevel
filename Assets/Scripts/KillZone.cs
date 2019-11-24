using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter( Collider other )
    {
        if ( other.gameObject.GetComponent<Mover>() )
            SceneManager.LoadScene( 0 );
    }

    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }
}
