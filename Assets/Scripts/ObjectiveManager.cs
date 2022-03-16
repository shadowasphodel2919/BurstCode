using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public AudioClip m_click;
    public Text m_objective;
    string m_text;
    public GameObject m_player;
    private ColliderManager m_colliderManager;
    public Material m_material;
    string m_curr;
    // Start is called before the first frame update
    void Start()
    {
        
        m_colliderManager = m_player.GetComponent<ColliderManager>();
        m_text = "Did you think this was about a link list or an array? No, why don’t you go look for Target A.";
        m_curr = m_colliderManager.m_curr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        m_curr = m_colliderManager.m_curr;
        Debug.Log(m_curr);
        string s = m_colliderManager.retText();
        m_text = s;
        m_objective.text = m_text;
        if(this.name != m_curr)
        {
            m_objective.text = "I'm not who you are looking for!";
        }
        else
        {
            Debug.Log(m_material.color);
        }
        AudioSource.PlayClipAtPoint(m_click, this.gameObject.transform.position);
        /*string name = (this.name);
        if (name == "Sphere_A")
        {
            m_objective.text = "This is going to be fun, I guarantee. Look around until you get to Target B.";
        }
        if (name == "Cube_B")
        {
            m_objective.text = "Two steps in, it’s not that bad, you’ll agree. Go look for Target C.";
        }
        if (name == "Sphere_C")
        {
            m_objective.text = "There’s too many words that I need to rhyme you see, go on ahead, look for Target D.";
        }
        if (name == "Cube_D")
        {
            m_objective.text = "Is this getting boring? Making you drowsy? I promise there’s only one more step after Target E.";
        }
        if (name == "Capsule_E")
        {
            m_objective.text = "I can’t think of anything that rhymes with F, you know where to go now, don’t you?";
        }
        if (name == "Capsule_F")
        {
            m_objective.text = "With this, we’re done. After putting you through this, is it okay for me to ask if you’ve had good fun?";
        }*/
    }
}
