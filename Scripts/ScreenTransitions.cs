using System.Collections.Generic;
using UnityEngine;

public class ScreenTransitions : MonoBehaviour
{
    public static ScreenTransitions instance { get; private set; }

    public List<TransitionAnimator> animators;

    private Dictionary<string, Animator> animatorsByName = new Dictionary<string, Animator>();

    private void Start()
    {
        if (!instance)
            return;

        foreach (var animator in animators)
            animatorsByName[animator.name] = animator.animator;

        instance = this;
    }

    public void PlayStart(string name)
    {
        if (animatorsByName.ContainsKey(name))
            animatorsByName[name].SetTrigger("Start");
    }

    public void PlayEnd(string name)
    {
        if (animatorsByName.ContainsKey(name))
            animatorsByName[name].SetTrigger("End");
    }
}

[System.Serializable]
public class TransitionAnimator
{
    public string name;
    public Animator animator;
}
