﻿using System;

public class Person
{
    private string name;

    private int age;

    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    {
    }
    
    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("Age cannot be negative or more than 100");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid Email");
            }

            this.email = value;
        }
    }

    public override string ToString()
    {
        if (this.Email == null)
        {
            string ressult = string.Format("Name: {0}, Age : {1}", this.Name, this.Age);
            return ressult;
        }

        string result = string.Format("Name: {0}, Age : {1}, Email: {2}", this.Name, this.Age, this.Email);
        return result;
    }
}