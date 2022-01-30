using UnityEngine;

public class MainManager : MonoBehaviour
{
    // ENCAPSULATION
    public static string selectedShapeTag { get; private set; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleHit();
        }
    }

    // ABSTRACTION
    private void HandleHit()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                Shape shape;
                GameObject gameObj = GameObject.FindWithTag(hit.collider.tag);
                if (gameObj)
                {
                    shape = gameObj.GetComponent<Shape>();
                    if (shape)
                    {
                        selectedShapeTag = hit.collider.tag;
                        shape.HandleClick();
                    }
                }
            }
        }
    }
}
