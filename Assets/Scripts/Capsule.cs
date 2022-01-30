using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
    private Vector3 torqueDirection = Vector3.right;
    private float torque = 500.0f;

    // POLYMORPHISM
    protected override void Twirl()
    {
        rb.AddRelativeTorque(torqueDirection * torque, ForceMode.Impulse);
        rb.AddForce(Vector3.up * tossUpForce * 2.0f);
    }
}
