using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet : MonoBehaviour
{
    MapButtons mapButtonsScript;

    float changeSpeed = 2.0f;

    //origin and maximum planet scale value
    float baseScale = 1.0f;
    float maxScale = 1.3f;
    float scaleChangeMultiplyier = 0.03f;

    bool scaleUp = false;
    bool scaleDown = false;

    [Header("Which level will this planet load")]
    [SerializeField] int levelNumber;

    private void Start()
    {
        mapButtonsScript = FindObjectOfType<MapButtons>().GetComponent<MapButtons>();
    }

    private void Update()
    {
        if(mapButtonsScript.topMenuOpen == false)
        {
            ScalePlus(scaleUp);
            ScaleMinus(scaleDown);
        }
    }

    private void OnMouseDown()
    {
        if (mapButtonsScript.topMenuOpen == false)
        {
            SceneManager.LoadScene(levelNumber + 1);
        }
    }

    private void OnMouseOver()
    {
        if (mapButtonsScript.topMenuOpen == false)
        {
            scaleUp = true;
            scaleDown = false;
        } 
    }

    private void OnMouseExit()
    {
        if (mapButtonsScript.topMenuOpen == false)
        {
            scaleUp = false;
            scaleDown = true;
        }
    }

    void ScalePlus(bool canScale)
    {
        if (!canScale)
            return;

        if (transform.localScale.x <= maxScale)
        {
            transform.localScale = new Vector3
           (
               Mathf.Lerp(transform.localScale.x, transform.localScale.x + scaleChangeMultiplyier, changeSpeed),
               Mathf.Lerp(transform.localScale.y, transform.localScale.y + scaleChangeMultiplyier, changeSpeed),
               Mathf.Lerp(transform.localScale.z, transform.localScale.z + scaleChangeMultiplyier, changeSpeed)
           );
        }
    }

    void ScaleMinus(bool canScale)
    {
        if (!canScale)
            return;

        if (transform.localScale.x >= baseScale)
        {
            transform.localScale = new Vector3
           (
               Mathf.Lerp(transform.localScale.x, transform.localScale.x - scaleChangeMultiplyier, changeSpeed),
               Mathf.Lerp(transform.localScale.y, transform.localScale.y - scaleChangeMultiplyier, changeSpeed),
               Mathf.Lerp(transform.localScale.z, transform.localScale.z - scaleChangeMultiplyier, changeSpeed)
           );
        }
    }







}
