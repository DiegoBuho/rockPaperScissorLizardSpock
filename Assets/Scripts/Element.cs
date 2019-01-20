using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class manages each new element. Use this to create a new element and define it.
/// </summary>
[CreateAssetMenu(fileName = "New Element", menuName = "Element")]
public class Element : ScriptableObject
{
    [Tooltip("The elements that are defeated BY this element.")]
    public List<Element> defeatedElements = new List<Element>();

    [Tooltip("The image that will be rendered on screen to represent this element.")]
    public Sprite elementImage;    
}
