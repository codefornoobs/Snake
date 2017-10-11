using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public GameObject ItemToPick;

    public float MinHeight,
        MaxHeight,
        MinWidth,
        MaxWidth;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateNewItem()
    {
        float randomX = Random.Range(MinHeight, MaxHeight);
        float randomY = Random.Range(MinWidth, MaxWidth);

        transform.position = new Vector3(randomX, randomY, 0);

        Instantiate(ItemToPick, transform.position, transform.rotation);
    }
}
