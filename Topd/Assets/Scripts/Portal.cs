using UnityEngine;
using Unity.Cinemachine;

public class Portal : MonoBehaviour
{
    public Transform moveposition;
    public Collider2D mapboundary;
    public CinemachineConfiner2D Confiner;
    public Animator SceneTransitAnimator;


    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player")) // Tag가 Player일때만
        {
            Confiner.BoundingShape2D = mapboundary;
            collider.transform.position = moveposition.position;

            SceneTransitAnimator.SetTrigger("Show");
        }
    }
}
