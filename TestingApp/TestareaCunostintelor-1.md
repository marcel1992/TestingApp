# Testarea cunostintelor - 1

## 1. Este corect codul de mai jos?

```csharp
int i = 0;
short j = 0;

i = 2;
j = i;

Console.WriteLine($"i are valoarea {i} si j are valoarea {j}");

```

## 2. Care din variantele de mai jos sunt corecte?

### a.

```csharp
List<int> result = null;
List<int> source = new List<int>(){1,2,3,4,5};

foreach(int id in source)
{
    result.Add(id);
}
```

### b.

```csharp
List<int> result = new List<int>();
List<int> source = new List<int>(){1,2,3,4,5};

foreach(int id in source)
{
    result.Add(id);
}
```

### c.

```csharp
List<int> result = new List<int>();
List<int> source = new List<int>(){1,2,3,4,5};

result.AddRange(source);
```

### d.

```csharp
List<int> result = new List<int>();
List<int> source = new List<int>(){1,2,3,4,5};

foreach(short id in source)
{
    result.Add(id);
}
```

## 3. Se da obiectul urmator:

```csharp
public class Animal
{
    public DateTime BirthDate{get;set;}
    public string Name{get;set;}
}
```

### Este necesara crearea a doua clase noi **_Cat_** si **_Dog_** care sa aiba urmatoarele proprietati:

- Id
- BirthDate
- Name

### Cerinta este ca trebuie sa te folosesti de clasa **_Animal_** pentru a realiza asta.

## 4. Este definita clasa urmatoare:

```csharp
public class Test
{
    public string Name{get;set;}
    public string Surname{get;set;}

    public Test(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}
```

### Este creata instanta **_test1_**:

```csharp
Test test1 = new Test("name a", "surname b");
```

### **_Cum se poate afisa numele + prenumele folosind metoda ToString a clasei Test?_**

### Solutia se afla la acest link:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
