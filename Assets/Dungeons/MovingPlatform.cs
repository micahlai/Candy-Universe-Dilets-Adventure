using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public float Move;
    [Tooltip("0 = x, 1 = y, 2 = z")]
    public int direction;
    public Transform platform;
    public float speed;
    private float startPos;
    void Start()
    {
        
        StartCoroutine(move());
    }
    IEnumerator move()
    {
        while (1 == 1)
        {
            if (direction == 0)
            {
                startPos = platform.position.x;
            }
            else if (direction == 1)
            {
                startPos = platform.position.y;
            }
            else
            {
                startPos = platform.position.z;
            }

            if (direction == 0)
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(i + startPos, platform.transform.position.y, platform.transform.position.z);
                    
                }
            }
            else if (direction == 1)
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(platform.transform.position.x, i + startPos, platform.transform.position.z);
                }
                
            }
            else
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(platform.transform.position.z, platform.transform.position.y, i + startPos);
                }
            }
            yield return new WaitForSeconds(1);

            if (direction == 0)
            {
                startPos = platform.position.x;
            }
            else if (direction == 1)
            {
                startPos = platform.position.y;
            }
            else
            {
                startPos = platform.position.z;
            }
            if (direction == 0)
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(i + startPos, platform.transform.position.y, platform.transform.position.z);

                }
            }
            else if (direction == 1)
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(platform.transform.position.x, i + startPos, platform.transform.position.z);
                }

            }
            else
            {
                for (float i = Move; i >= Move; i += Time.deltaTime / speed)
                {
                    platform.transform.position = new Vector3(platform.transform.position.z, platform.transform.position.y, i + startPos);
                }

            }
            yield return new WaitForSeconds(1);
        }
        yield return null;
    }
}
