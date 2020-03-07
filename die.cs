using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour {



    void OnCollisionEnter2D(Collision2D collision)
    {

        //if Peach jumps on red cloud
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                SceneManager.LoadScene("Menu_Lost");
            }


        }

    }
}
