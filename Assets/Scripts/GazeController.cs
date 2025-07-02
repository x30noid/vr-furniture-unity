using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeController : MonoBehaviour
{
    public GameObject SlimBike;
    public GameObject MediumBike;
    public GameObject RacingBike;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SlimBikeActivate()
    {
        SlimBike.SetActive(true);
    }

    public void SlimBikeDeactivate()
    {
        SlimBike.SetActive(false);
    }

    public void MediumBikeActivate()
    {
        MediumBike.SetActive(true);
    }

    public void MediumBikeDeactivate()
    {
        MediumBike.SetActive(false);
    }

    public void RacingBikeActivate()
    {
        RacingBike.SetActive(true);
    }

    public void RacingBikeDeactivate()
    {
        RacingBike.SetActive(false);
    }

}
