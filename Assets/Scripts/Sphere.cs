using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    protected override void Twirl()
    {
        rb.AddForce(Vector3.down * 5.0f, ForceMode.Impulse);
    }
}
