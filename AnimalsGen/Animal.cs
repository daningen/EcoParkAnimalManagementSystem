using System;

namespace EcoParkAnimalManagementSystem.AnimalsGen;

//base class - not to be instatiated
public abstract class Animal
{
    private string name;
    private int age; 
    private GenderType gender;
    private CategoryType category;

    //to prohibit creating new Animal
    protected Animal()
    {
        name = string.Empty;
        age = 0; // Fix: assign a default integer value
        gender = GenderType.Unknown; // Fix: assign a default value
        category = CategoryType.Unknown; // Fix: assign a default instance
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

    public GenderType Gender
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

public class GenderType
{
}