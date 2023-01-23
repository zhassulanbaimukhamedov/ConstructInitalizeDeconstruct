class PersonDeconst
{
    string name;
    int age;
    public PersonDeconst(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Deconstruct(out string nameOut, out int ageOut)
    {
        nameOut = name;
        ageOut = age;
    }
}
