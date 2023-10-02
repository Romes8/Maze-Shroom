using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;
using TMPro;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    // Start is called before the first frame update

    object mushroom_colour;

    string selected_recipe_name = "";
    List<string> selected_recipe_content = new List<string>();
    List<string> picked_content = new List<string>();

    public TextMeshProUGUI text;
    public GameObject win;
    public GameObject lose;
    public AudioClip winMusic;

    public Sprite PoisonPotionSprite;
    public Sprite LovePotionSprite;
    public Sprite GrowthPotionSprite;
    public Sprite StrengthPotionSprite;
    public Sprite HastePotionSprite;
    public Image PotionToChange;


    void Start()
    {
        //pick any of the recipes and save it to the array.

        //get random number

        // List of string arrays
        Dictionary<string, string[]> Recipes = new Dictionary<string, string[]>();


        // Create and populate string arrays
        string[] RedPotion = { "red", "red", "blue" };
        string[] BrokenHandPotion = { "red", "blue" };
        string[] PoisonPotion = { "poison", "poison", "desert", "frozen"};
        string[] LovePotion = { "glitter", "glitter", "crystal", "store" };
        string[] GrowthPotion = { "bog", "bog", "forest", "store" };
        string[] StrengthPotion = { "lava", "lava", "bog", "frozen" };
        string[] HastePotion = { "desert", "desert", "crystal", "forest" };

        // Add string arrays to the list
        Recipes.Add("Poison Potion", PoisonPotion);
        Recipes.Add("Love Potion", LovePotion);
        Recipes.Add("Growth Potion", GrowthPotion);
        Recipes.Add("Strength Potion", StrengthPotion);
        Recipes.Add("Haste Potion", HastePotion);

        // Randomly select an array from the list
        System.Random random = new System.Random();
        int randomIndex = random.Next(0, Recipes.Count);


        selected_recipe_name = Recipes.Keys.ToArray()[randomIndex];
        text.text = selected_recipe_name;
        string[] selectedrecipe = Recipes[selected_recipe_name];

        if (selected_recipe_name.Equals("Poison Potion"))
        {
            PotionToChange.sprite = PoisonPotionSprite;
        }
        else if (selected_recipe_name.Equals("Love Potion"))
        {
            PotionToChange.sprite = LovePotionSprite;
        }
        else if (selected_recipe_name.Equals("Growth Potion"))
        {
            PotionToChange.sprite = GrowthPotionSprite;
        }
        else if (selected_recipe_name.Equals("Strength Potion"))
        {
            PotionToChange.sprite = StrengthPotionSprite;
        }
        else
        {
            PotionToChange.sprite = HastePotionSprite;
        }

            // Convert the string array to a list of strings
            selected_recipe_content = new List<string>(selectedrecipe);

        print("Picked potion is:");
        print(selected_recipe_name);

        print("Recipe materials: ");

        for (int i = 0; i < selected_recipe_content.Count; i++)
        {
            print(selected_recipe_content[i]);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mushroom")) // Assuming you have a "Mushroom" tag for mushrooms
        {
            // Handle collision with mushroom here (e.g., destroy the mushroom)
            print("Colided with mushroom");

            //get the colour of the mushroom
            mushroom_colour = Variables.Object(collision.gameObject).Get("mushroom-colour");

            //add to inventory
            picked_content.Add(mushroom_colour.ToString());

            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        //when player is in the house compare the arrays. if correct than win the game. 

        if (other.CompareTag("home"))
        {
            print("Player is at home");
            print("Picked content. ");
            print(picked_content.Count);

            print("Selected. ");
            print(selected_recipe_content.Count);


            bool areEqual = AreListsEqualIgnoringOrder(picked_content, selected_recipe_content);

            if (areEqual)
            {
                //PLAYER WON THE GAME
                print("YOU MADE YOUR FIRST POTION NAMED:");
                print(selected_recipe_name.ToUpper());

                //redirect to the end screen
                GetComponent<AudioSource>().clip = winMusic;
                GetComponent<AudioSource>().loop = false;
                GetComponent<AudioSource>().Play();
                win.SetActive(true);
            }
            else
            {
                lose.SetActive(true);
            }


        }
    }

    static bool AreListsEqualIgnoringOrder<T>(List<T> list1, List<T> list2)
    {
        // Check if the lists have the same elements, regardless of order
        return list1.OrderBy(x => x).SequenceEqual(list2.OrderBy(x => x));
    }
}
