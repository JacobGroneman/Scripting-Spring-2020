using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class TankShoot1 : MonoBehaviour
{
    public GameObject shellPrefab, shellSpawnPosition, target, parent;
    private float _velocity = 15f;
    private float _turnSpeed = 2f;
    private bool _canShoot = true;

    void Update()
    {
        Vector3 direction = (target.transform.position - parent.transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        parent.transform.rotation = 
            Quaternion.Slerp(parent.transform.rotation, lookRotation, Time.time * _turnSpeed);

        float? angle = RotateTurret();

        if (angle != null && Vector3.Angle(direction, parent.transform.forward) < 10)
            Fire();
    }

    void CanShootAgain()
    {
        _canShoot = true;
    }
    
    void Fire()
    {
        if (_canShoot)
        {
            GameObject shell =
                Instantiate(shellPrefab, shellSpawnPosition.transform.position, 
                    shellSpawnPosition.transform.rotation);

            shell.GetComponent<Rigidbody>().velocity = _velocity * this.transform.forward;
            _canShoot = false;
            Invoke("CanShootAgain", 0.02f);
        }
    }

    float? RotateTurret()
    {
        float? angle = CalculateAngle(true);
        if (angle != null)
        {
            this.transform.localEulerAngles = new Vector3(360f - (float)angle, 0f, 0f);
        }
        return angle;
    }
    
    
    float? CalculateAngle(bool low)
    {
        Vector3 targetDirection = (target.transform.position - this.transform.position);
        float y = targetDirection.y;
        targetDirection.y = 0f;
        float x = targetDirection.magnitude;
        float _gravity = 9.81f;
        float _velocitySqr = _velocity * _velocity;
        
        float floatUnderSqrRt = (_velocitySqr * _velocitySqr) - _gravity
                                * (_gravity * x * x + 2 * y * _velocitySqr);

        if (floatUnderSqrRt >= 0f)
        {
            float root = Mathf.Sqrt(floatUnderSqrRt);
            float highAngle = _velocitySqr + root;
            float lowAngle = _velocitySqr - root;

            if (low)
                return (Mathf.Atan2(lowAngle, _gravity * x) * Mathf.Rad2Deg);
            else
                return Mathf.Atan2(highAngle, _gravity * x) * Mathf.Rad2Deg);
            
        }
        else
            return null;
    }
}*/
