using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class PrimitiveTypesDictionary : MonoBehaviour
{
    public  Dictionary<string, int> people = new Dictionary<string, int>();
    public Dictionary<long, string> books = new Dictionary<long, string>();

    void Start()
    {
        people.Add("John", 26);
        people.Add("James", 55);
        people.Add("Rachael", 31);
        people.Add("Yin", 34);
        
        books.Add(0670813028, "IT");
        books.Add(9781338267105, "Harry Potter: A Journey Through a History of Magic");
        books.Add(1338216236, "Captain Underpants and the Wrath of the Wicked Wedgie Woman: Color Edition");
        books.Add(0763680907, "The Miraculous Journey of Edward Tulane");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var rachaelAge = people["Rachael"];
            UnityEngine.Debug.Log("Rachael is " + rachaelAge + " years old.");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            UnityEngine.Debug.Log(books[0670813028]);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            foreach (KeyValuePair<long, string> book in books)
            {
                UnityEngine.Debug.Log("Book: " + books.Values);
            }
        }
    }
}
