﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pet
{
    [SerializeField]
    private string name;
    [SerializeField]
    private Health health;

    public void Walk()
    {

    }

    public void Eat(Food food)
    {
        health.PutInHungry(food.GetNutrionalValor());
    }

    public void Drink(Food food)
    {
        health.PutInThirst(food.GetNutrionalValor());
    }

    public void Pee()
    {
        health.PutInPee(0);
    }

    public void Poop()
    {
        health.PutInPoop(0);
    }

    public void Play()
    {

    }
}
