using UnityEngine;

public class ChangeMaterialOnHover : MonoBehaviour
{
    public Material defaultMaterial;  // Material when not hovered or selected
    public Material hoverMaterial;    // Material when hovered
    public Material selectMaterial;   // Material when selected

    private static ChangeMaterialOnHover previouslySelected = null;  // Track previously selected object
    private MeshRenderer meshRenderer;
    private bool isSelected = false; // Track if the object is currently selected

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        // Set default material initially
        if (defaultMaterial != null)
        {
            meshRenderer.material = defaultMaterial;
        }
    }

    public void ChangeHoverEnter()
    {
        if (!isSelected) // Only change if not selected
        {
            meshRenderer.material = hoverMaterial;
        }
    }

    public void ChangeHoverExit()
    {
        if (!isSelected) // Only change if not selected
        {
            meshRenderer.material = defaultMaterial;
        }
    }

    public void ChangeSelectEnter()
    {
        // Reset previous selection (if any)
        if (previouslySelected != null && previouslySelected != this)
        {
            previouslySelected.ResetToDefault();
        }

        isSelected = true;
        meshRenderer.material = selectMaterial;
        previouslySelected = this;
    }

    public void ChangeSelectExit()
    {
        ResetToDefault();
    }

    private void ResetToDefault()
    {
        isSelected = false;
        meshRenderer.material = defaultMaterial;
    }
}
