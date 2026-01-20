using UnityEngine;

public class ArtefactCleaner : MonoBehaviour
{
    [SerializeField] private Material clearMaterial;
    [SerializeField] private MeshRenderer artefactRenderer;

    public void Clear()
    {
        if (artefactRenderer != null && clearMaterial != null)
        {
            artefactRenderer.material = clearMaterial;
        }
    }
    
    
}
