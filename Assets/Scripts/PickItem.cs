using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
	private ItemGenerator _itemGenerator;
	// Use this for initialization
	void Awake ()
	{
		_itemGenerator = FindObjectOfType<ItemGenerator>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		ScoreManager.updateScore(1);
		_itemGenerator.GenerateNewItem();
		Destroy(gameObject);
	}
}

