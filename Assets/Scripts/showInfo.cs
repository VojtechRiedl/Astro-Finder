using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class showInfo : MonoBehaviour
{
    [Header("Planet Type")]
    [SerializeField]  //[SerializeField]
    private TextMeshProUGUI planetName;
    [SerializeField]
    private TextMeshProUGUI planetDesc;
    [SerializeField]
    private TextMeshProUGUI Stats;
    [SerializeField]
    private string requires;
    [SerializeField]
    private string contains;
    [SerializeField]
    private string threatlevel;
    [SerializeField]
    private string cycle;
    [SerializeField]
    private Sprite nahledak;
    [SerializeField]
    private Image image;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickShow()
    {

        Debug.Log("ao");
        planetName.text = "Toxic";
        planetDesc.text = "Toxicka planeta. Poprvé nalezena roku 4025";
        Stats.text = "Requires: " + requires + "\nContains: " + contains + "\nThreat level: " + threatlevel + "\nCycle: " + cycle;
        image.sprite = nahledak;
    }
}
