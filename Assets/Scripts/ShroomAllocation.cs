using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroomAllocation : MonoBehaviour
{
    public GameObject storeShroom;
    public GameObject forestShroom;
    public GameObject poisonShroom;
    public GameObject iceShroom;
    public GameObject desertShroom;
    public GameObject bogShroom;
    public GameObject glitterShroom;
    public GameObject lavaShroom;
    public GameObject crystalShroom;

    // Start is called before the first frame update
    void Start()
    {
        //allocate store shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(storeShroom, new Vector3(-44.5f, 42, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-18.8f, 41.8f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(storeShroom, new Vector3(-44.5f, 42, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-39.2f, 14.5f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(storeShroom, new Vector3(-44.5f, 42, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-23.9f, 14.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(storeShroom, new Vector3(-18.8f, 41.8f, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-39.2f, 14.5f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(storeShroom, new Vector3(-18.8f, 41.8f, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-23.9f, 14.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(storeShroom, new Vector3(-39.2f, 14.5f, 0), Quaternion.identity);
                Instantiate(storeShroom, new Vector3(-23.9f, 14.5f, 0), Quaternion.identity);
                break;
        }
        //allocate forest shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(forestShroom, new Vector3(-6, 35.5f, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(-7, 42, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(forestShroom, new Vector3(-6, 35.5f, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(3.7f, 18.5f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(forestShroom, new Vector3(-6, 35.5f, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(-10.7f, 15.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(forestShroom, new Vector3(-7, 42, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(3.7f, 18.5f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(forestShroom, new Vector3(-7, 42, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(-10.7f, 15.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(forestShroom, new Vector3(3.7f, 18.5f, 0), Quaternion.identity);
                Instantiate(forestShroom, new Vector3(-10.7f, 15.5f, 0), Quaternion.identity);
                break;
        }
        //allocate poison shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(poisonShroom, new Vector3(22.5f, 40.8f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(35.6f, 41.8f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(poisonShroom, new Vector3(22.5f, 40.8f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(36.6f, 32.3f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(poisonShroom, new Vector3(22.5f, 40.8f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(19.7f, 22.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(poisonShroom, new Vector3(35.6f, 41.8f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(36.6f, 32.3f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(poisonShroom, new Vector3(35.6f, 41.8f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(19.7f, 22.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(poisonShroom, new Vector3(36.6f, 32.3f, 0), Quaternion.identity);
                Instantiate(poisonShroom, new Vector3(19.7f, 22.5f, 0), Quaternion.identity);
                break;
        }
        //allocate ice shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(iceShroom, new Vector3(-39, -0.8f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-43.2f, -14.4f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(iceShroom, new Vector3(-39, -0.8f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-18.6f, 4.5f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(iceShroom, new Vector3(-39, -0.8f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-18.5f, -15.7f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(iceShroom, new Vector3(-43.2f, -14.4f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-18.6f, 4.5f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(iceShroom, new Vector3(-43.2f, -14.4f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-18.5f, -15.7f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(iceShroom, new Vector3(-18.6f, 4.5f, 0), Quaternion.identity);
                Instantiate(iceShroom, new Vector3(-18.5f, -15.7f, 0), Quaternion.identity);
                break;
        }
        //allocate desert shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(desertShroom, new Vector3(-12.3f, 6.8f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(13.2f, 7.8f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(desertShroom, new Vector3(-12.3f, 6.8f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(8, -7.9f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(desertShroom, new Vector3(-12.3f, 6.8f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(-7.1f, -14.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(desertShroom, new Vector3(13.2f, 7.8f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(8, -7.9f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(desertShroom, new Vector3(13.2f, 7.8f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(-7.1f, -14.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(desertShroom, new Vector3(8, -7.9f, 0), Quaternion.identity);
                Instantiate(desertShroom, new Vector3(-7.1f, -14.5f, 0), Quaternion.identity);
                break;
        }
        //allocate bog shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(bogShroom, new Vector3(24.9f, 7.7f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(21.7f, -15.7f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(bogShroom, new Vector3(24.9f, 7.7f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(44.3f, 11.1f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(bogShroom, new Vector3(24.9f, 7.7f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(43, -17.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(bogShroom, new Vector3(21.7f, -15.7f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(44.3f, 11.1f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(bogShroom, new Vector3(21.7f, -15.7f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(43, -17.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(bogShroom, new Vector3(44.3f, 11.1f, 0), Quaternion.identity);
                Instantiate(bogShroom, new Vector3(43, -17.5f, 0), Quaternion.identity);
                break;
        }
        //allocate glitter shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(glitterShroom, new Vector3(-44.6f, -23, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-43.4f, -46.5f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(glitterShroom, new Vector3(-44.6f, -23, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-21.8f, -45.7f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(glitterShroom, new Vector3(-44.6f, -23, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-16.8f, -39.1f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(glitterShroom, new Vector3(-43.4f, -46.5f, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-21.8f, -45.7f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(glitterShroom, new Vector3(-43.4f, -46.5f, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-16.8f, -39.1f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(glitterShroom, new Vector3(-21.8f, -45.7f, 0), Quaternion.identity);
                Instantiate(glitterShroom, new Vector3(-16.8f, -39.1f, 0), Quaternion.identity);
                break;
        }
        //allocate lava shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(lavaShroom, new Vector3(-10, -24.2f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(-5.6f, -19.1f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(lavaShroom, new Vector3(-10, -24.2f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(-2.6f, -46.4f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(lavaShroom, new Vector3(-10, -24.2f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(12, -22.4f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(lavaShroom, new Vector3(-5.6f, -19.1f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(-2.6f, -46.4f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(lavaShroom, new Vector3(-5.6f, -19.1f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(12, -22.4f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(lavaShroom, new Vector3(-2.6f, -46.4f, 0), Quaternion.identity);
                Instantiate(lavaShroom, new Vector3(12, -22.4f, 0), Quaternion.identity);
                break;
        }
        //allocate crystal shrooms
        switch (Random.Range(1, 7))
        {
            case 1:
                Instantiate(crystalShroom, new Vector3(28.3f, -46.4f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(39.2f, -46.2f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(crystalShroom, new Vector3(28.3f, -46.4f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(37.4f, -22.6f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(crystalShroom, new Vector3(28.3f, -46.4f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(43.2f, -22.5f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(crystalShroom, new Vector3(39.2f, -46.2f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(37.4f, -22.6f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(crystalShroom, new Vector3(39.2f, -46.2f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(43.2f, -22.5f, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(crystalShroom, new Vector3(37.4f, -22.6f, 0), Quaternion.identity);
                Instantiate(crystalShroom, new Vector3(43.2f, -22.5f, 0), Quaternion.identity);
                break;
        }
    }
}
