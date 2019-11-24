using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    [SerializeField] private RectTransform winnerPanel;
    [SerializeField] private RectTransform backGround;
    [SerializeField] private GameObject[] objectsToDisable;
    //[SerializeField] private Transform childObjectsToDisable;

    private void OnTriggerEnter( Collider other )
    {
        if ( other.gameObject.GetComponent<Mover>() )
        {
            winnerPanel.gameObject.SetActive( true );
            //backGround.gameObject.SetActive( false );
            //other.gameObject.SetActive( false );

            for ( int i = 0; i < objectsToDisable.Length; i++ )
            {
                objectsToDisable[i].SetActive( false );
            }

            //for ( int i = 0; i < childObjectsToDisable.childCount; i++ )
            //{
            //    childObjectsToDisable.GetChild( i ).gameObject.SetActive( false );
            //}

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene( 0 );
    }

}
