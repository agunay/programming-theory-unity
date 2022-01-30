using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    private Vector3 torqueDirection = new Vector3(0.5f, 0.5f, 0.0f);
    private float torque = 10.0f;

    // POLYMORPHISM
    protected override void Twirl()
    {
        rb.AddTorque(torqueDirection * torque, ForceMode.Impulse);
        rb.AddForce(Vector3.up * tossUpForce * 2.0f);
    }
}
