using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public Rigidbody rb;
    public Material material;

    protected float tossUpForce = 100.0f;
    private float topLimit = 5.0f;
    private bool isSelected = false;

    private Color activeColour = new Color(0.8100575f, 0.03301889f, 1.0f);
    private Color inactiveColour = new Color(0.3110375f, 0.3109203f, 0.4811321f);

    private void Start()
    {
        material.SetColor("_Color", inactiveColour);
    }

    private void Update()
    {
        if (transform.position.y > topLimit)
        {
            transform.position.Set(transform.position.x, topLimit, transform.position.z);
        }
        else if (transform.position.y < 1.0f)
        {
            rb.AddForce(Vector3.up * tossUpForce / 2, ForceMode.Acceleration);
        }
    }

    public void HandleClick()
    {
        if (rb)
        {
            Shape[] shapes = FindObjectsOfType<Shape>();
            foreach(Shape shape in shapes)
            {
                if (shape.tag == MainManager.selectedShapeTag)
                {
                    Debug.Log(shape.tag);
                    Debug.Log(MainManager.selectedShapeTag);
                    shape.isSelected = true;
                } else
                {
                    shape.isSelected = false;
                }
                shape.TogglePhysics();
            }
        }
    }

    private void TogglePhysics()
    {
        if (isSelected)
        {
            rb.isKinematic = false;
            Twirl();
            ChangeColour(activeColour);
        } else
        {
            rb.isKinematic = true;
            ChangeColour(inactiveColour);
        }
    }

    private void ChangeColour(Color newColour)
    {
        material.SetColor("_Color", newColour);
    }

    protected abstract void Twirl();
}
