using UnityEngine;
using UnityEngine.UI;

public class SkyboxChanger : MonoBehaviour
{
    public Material[] skyboxes; // Array de materiais de skybox
    public Text instructionText; // Referência ao componente de texto da UI
    private int currentSkyboxIndex = 0;

    void Start()
    {
        UpdateInstructionText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSkybox();
            UpdateInstructionText();
        }
    }

    void ChangeSkybox()
    {
        currentSkyboxIndex++;
        if (currentSkyboxIndex >= skyboxes.Length)
        {
            currentSkyboxIndex = 0; // Volta ao primeiro skybox se ultrapassar o último
        }

        RenderSettings.skybox = skyboxes[currentSkyboxIndex];
        DynamicGI.UpdateEnvironment(); // Atualiza a iluminação global
    }

    void UpdateInstructionText()
    {
        if (currentSkyboxIndex == 0)
        {
            instructionText.text = "Pressione E para trocar para anoitecer";
        }
        else
        {
            instructionText.text = "Pressione E para trocar para amanhecer";
        }
    }
}
