using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class controls the combat between elements.
/// </summary>
public class Combat : MonoBehaviour
{
    [Tooltip("Element represented by this item")]
    public Element element;

    [Tooltip("Event that we want to run when this element wins")]
    public UnityEvent winningEvent;

    public StringVariable ICEBERG_NAME;

    private void OnTriggerEnter2D(Collider2D collision){

        Combat combat = collision.gameObject.GetComponent<Combat>();
        if (combat != null){
            if (combat.element.defeatedElements.Contains(element)){
                
                // Invokes the Event associated with the winning element, so all the listeners can be activated
                combat.winningEvent.Invoke();

                // Destroy the losing Element
                Destroy(gameObject);

            }

            // iceberg can't destroyed or destroy other elements, but we run its event to play its sound and give feedback to the player
            if (combat.element.name == ICEBERG_NAME.Value)
            {
                combat.winningEvent.Invoke();
            }
        }
    }
}