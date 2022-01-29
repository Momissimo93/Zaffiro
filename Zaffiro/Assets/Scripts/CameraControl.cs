using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] float interpolationSpeed = 5f;
    [SerializeField] Vector2 offset;

    private Camera cam;
    private float verExtent;
    private float horExtent;
    private float leftB;
    private float rightB;
    private float topB;
    private float bottomB;
    private enum TypeOfCharacter { Human, Bunny, Bird };
    private TypeOfCharacter typeOfChar;
    private MainCharacter mainCharacter;

    private Bounds sceneBounds;

    void Start()
    {
        mainCharacter = FindObjectOfType<MainCharacter>();
        cam = GetComponent<Camera>();

        Collider2D[] sceneColliders2D = FindObjectsOfType<Collider2D>();

        foreach (Collider2D coll in sceneColliders2D)
        {
            sceneBounds.Encapsulate(coll.bounds);
        }

        GetExtents();
        GetBounds();
    }
    // Update is called once per frame
    void Update()
    {
        if (mainCharacter)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(Mathf.Clamp(mainCharacter.trans.position.x, leftB, rightB) + offset.x, Mathf.Clamp(mainCharacter.trans.position.y, bottomB, topB) + offset.y, transform.position.z), Time.deltaTime * interpolationSpeed);
        }
    }

    void GetExtents()
    {
        if (GetComponent<Camera>())
        {
            verExtent = GetComponent<Camera>().orthographicSize;
            horExtent = verExtent * GetComponent<Camera>().aspect;
        }
    }

    void GetBounds()
    {
        if (GetComponent<Camera>())
        {

            leftB = sceneBounds.min.x + horExtent - offset.x;
            rightB = sceneBounds.max.x - horExtent - offset.x;

            bottomB = sceneBounds.min.y + verExtent - offset.y;
            topB = sceneBounds.max.y - verExtent - offset.y;
        }
    }
}
