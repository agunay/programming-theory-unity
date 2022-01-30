using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    private Vector3 torqueDirection = new Vector3(1.0f, 1.0f, 0.0f);
    private float torque = 1000.0f;

    // POLYMORPHISM
    protected override void Twirl()
    {
        rb.AddTorque(torqueDirection * torque, ForceMode.Impulse);
        rb.AddForce(Vector3.up * tossUpForce * 2.0f);
    }
}
