using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherScript : MonoBehaviour
{
    public ParticleSystem LightningParticleSystem;
    public ParticleSystem RainParticleSystem;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Random.Range(0, 1000) > 995)
        {
            ParticleSystem lightningParticleSystem = Instantiate(LightningParticleSystem);
            lightningParticleSystem.Stop();
            lightningParticleSystem.Clear();
            if(!lightningParticleSystem.isPlaying)
            {
                lightningParticleSystem.gameObject.transform.position.Set(Random.Range(-1000f, 1000f), 50, Random.Range(-1000f, 1000f));
                lightningParticleSystem.Play();
            }
        }
        ParticleSystem[] ps = GameObject.FindObjectsOfType<ParticleSystem>();
        foreach(var p in ps)
        {
            if(p.name.Contains("Lightning Particle System"))
            {
                if (!p.isPlaying)
                {
                    Destroy(p);
                }
            }
            else if(p.name.Contains("Sparks Particle System"))
            {
                if(!p.isPlaying)
                {
                    Destroy(p);
                }
            }
        }
	}
}
