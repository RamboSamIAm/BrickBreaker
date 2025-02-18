using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    protected Vector3 aMovDir = Vector3.zero;
    [SerializeField, Range(1, 20)] protected float movSpeed = 1f;
    // [SerializeField, Range(10, 29)] protected float maxSpeed = 25f;

    private void FixedUpdate()
    {
        MovePaddle();
    }

    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        aMovDir.x = av2.x;
        aMoveDir.z = av2.y;
    }

    public void MovePaddle()
    {
        if (aMovDir.magnitude > maxSpeed)
        {
            return;
        } 
        else
        {
            transform.Translate(aMovDir * movSpeed * Time.deltaTime);
        }
    }
}
