using UnityEngine;
using UnityEngine.Events;

public class Filter : MonoBehaviour
{
    [SerializeField]private float forceImpulse = 1;
    [SerializeField]private float force = 1;
    [SerializeField]private Vector2 dirictionMove;

    public UnityEvent addImpulseEvent;
    public UnityEvent addForceEvent;

    public UnityEvent takeObjectAEvent;
    public UnityEvent takeObjectBEvent;

    private Rigidbody2D rb;




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectA>())
            takeObjectAEvent?.Invoke();

        if (collision.gameObject.GetComponent<ObjectB>())
            takeObjectBEvent?.Invoke();
    }
}
