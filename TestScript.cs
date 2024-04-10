using UnityEngine;

public class TestScript : MonoBehaviour
{
    public int my_int = 15;
    public float my_float = 1.037f;
    public string my_string = "Hello World";

    private char my_char = 'c';

    private Vector2 my_vec2 = new Vector2(12, 8);
    public Vector3 my_vec3 = new Vector3(4.6f, 10.2f, 13.5f);

    public int[] my_array = { 1, 3, 7, 6, 65, 77, 112 };


    void Start()
    {
        // for (var i = 0; i < 10; i++)
        // {
        //     Debug.Log(i);
        // }

        // int i = 0;
        // while (i < 10)
        // {
        //     Debug.Log(i);
        //     i++;
        // }

        int i = 0;
        do
        {
            Debug.Log(i);
            i++;
        } while (i < 10);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            my_int += 1;
            Debug.Log("My int is at: " + my_int.ToString());

            // if (my_int > 20)
            // {
            //     Debug.Log("My Int is greater than 20!");
            // }


            // if (my_int % 2 == 0)
            // {
            //     Debug.Log("My Int is even");
            // }
            // else
            // {
            //     Debug.Log("My Int is odd");
            // }

            // if (my_int == 16)
            // {
            //     Debug.Log("A");
            // }
            // else if (my_int == 18)
            // {
            //     Debug.Log("B");
            // }
            // else if (my_int == 20)
            // {
            //     Debug.Log("C");
            // }
            // else
            // {
            //     Debug.Log("D");
            // }

            switch (my_int)
            {
                case 16:
                    Debug.Log("A");
                    break;
                case 17:
                    Debug.Log("B");
                    break;
                case 18:
                case 19:
                    Debug.Log("D");
                    break;
                default:
                    Debug.Log("Default.");
                    break;
            }
        }
    }
}

public class Fruit
{
    public string name;
    public int price;

    public void SayFruitName()
    {
        Debug.Log(name);
    }

    public void SayFruitPrice()
    {
        Debug.Log("This fruit costs " + GetPrice() + " dollars.");
    }

    private string GetPrice()
    {
        return price.ToString();
    }
}