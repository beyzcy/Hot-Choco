using System.Collections;
using UnityEngine;

public class WlakKrampuz : MonoBehaviour
{
    private float minX = 4.685f;
    private float maxX = 5.996f;
    private float speed = 2f;
    private bool movingRight = false;

    private void Start()
    {
        StartCoroutine(MainMenuAnim());
    }

    IEnumerator MainMenuAnim()
    {
        while (true)
        {
            if (movingRight)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);

                if (transform.position.x >= maxX)
                {
                    movingRight = false;
                }
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);

                if (transform.position.x <= minX)
                {
                    movingRight = true;
                }
            }

            yield return null;
        }
    }
}