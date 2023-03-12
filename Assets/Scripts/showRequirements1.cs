using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showRequirements : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI dela_Text;
    [SerializeField]
    private TextMeshProUGUI potrebuje_Text;
    [SerializeField]
    private string dela;
    [SerializeField]
    private string potrebuje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickShowReq()
    {
        dela_Text.text = dela;
        potrebuje_Text.text = potrebuje;
    }
}
