using System;

namespace EcoParkAnimalManagementSystem.AnimalsGen;

public class Animal
{
    private string name;
    private int age; 
    private Gendertype gender;
    private CategoryType category;

    public Animal()
    {
        name = string.Empty;
        age = 0; // Fix: assign a default integer value
        gender = new Gendertype(); // Fix: assign a default instance
        category = new CategoryType(); // Fix: assign a default instance
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Gendertype Gender
    {
        get { return gender; }
        set { gender = value; }
    }
    public CategoryType Category
    {
        get { return category; }
        set { category = value; }
    }

    public override string ToString()
    {
        return $"Name: {name}, Age  : {age}, Gender: {gender}, Category: {category}";
    }
}

public class Gendertype
{
}