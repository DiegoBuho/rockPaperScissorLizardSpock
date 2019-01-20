using UnityEngine;

/// <summary>
/// Manages the data that must be used to represent this element to the player (i.e. the image)
/// </summary>
[ExecuteInEditMode]
public class ElementDisplay : MonoBehaviour {
    
    public Element element;

    void Awake() {
        if (element != null)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = element.elementImage;
        }
    }

}
