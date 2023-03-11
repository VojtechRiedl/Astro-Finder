using UnityEngine;

public class Resources : MonoBehaviour
{
    [SerializeField]
    private int iron;
    [SerializeField]
    private int copper;
    [SerializeField] 
    private int ignium;
    [SerializeField]
    private int iridium;
    [SerializeField] 
    private int sensium;
    [SerializeField] 
    private int uranium;


    public int GetIron()
    {
        return iron;
    }
    public int GetCopper() 
    { 
        return copper;
    }
    public int GetIgnium()
    {
        return ignium;
    }
    public int GetIridium()
    {
        return iridium;
    }
    public int GetSensium() 
    {
        return sensium;
    }
    public int GetUranium()
    {
        return uranium;
    }

    public void AddIron(int value)
    {
        iron += value;
    }
    public void AddCopper(int value)
    {
        copper += value;
    }
    public void AddIgnium(int value)
    {
        ignium += value;
    }
    public void AddIridium(int value)
    {
        iridium += value;
    }
    public void AddSensium(int value)
    {
        sensium += value;
    }
    public void AddUranium(int value)
    {
        uranium += value;
    }
}
