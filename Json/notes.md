# C# JSON Attributes — `System.Text.Json`

The `System.Text.Json` namespace provides attributes that allow us to control how C# properties are represented during **JSON serialization and deserialization**.

Import the namespace:

```csharp
using System.Text.Json;
using System.Text.Json.Serialization;
```

---

## 1. `[JsonPropertyName]`

### Definition

`[JsonPropertyName]` is used to specify a **custom name for a C# property in JSON**.

By default, the JSON property name is the same as the C# property name.

### Syntax

```csharp
[JsonPropertyName("json_name")]
public string PropertyName { get; set; }
```

### Example

```csharp
public class Student
{
    [JsonPropertyName("student_name")]
    public string Name { get; set; }

    public int Age { get; set; }
}
```

Serialization:

```csharp
Student student = new Student
{
    Name = "Vanshika",
    Age = 21
};

string json = JsonSerializer.Serialize(student);
Console.WriteLine(json);
```

Output:

```json
{
  "student_name": "Vanshika",
  "Age": 21
}
```

Here:

```text
C# property       JSON property
--------------------------------
Name          →   student_name
Age           →   Age
```

### Important

`[JsonPropertyName]` affects **both serialization and deserialization**.

---

# 2. `[JsonIgnore]`

### Definition

`[JsonIgnore]` is used to **exclude a C# property from JSON serialization and deserialization**.

### Syntax

```csharp
[JsonIgnore]
public string PropertyName { get; set; }
```

### Example

```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    [JsonIgnore]
    public string Password { get; set; }
}
```

Object:

```csharp
Student student = new Student
{
    Name = "Vanshika",
    Age = 21,
    Password = "abc123"
};

string json = JsonSerializer.Serialize(student);
```

Output:

```json
{
  "Name": "Vanshika",
  "Age": 21
}
```

The `Password` property is not included.

### Important

`[JsonIgnore]` means:

```text
Property
   ↓
Ignored by JSON
```

It applies to both **serialization and deserialization** by default.

---

# 3. `[JsonIgnore(Condition = ...)]`

Instead of always ignoring a property, we can tell the serializer to ignore it **only under a specific condition**.

### Syntax

```csharp
[JsonIgnore(Condition = JsonIgnoreCondition.Condition)]
public string PropertyName { get; set; }
```

The most important conditions are:

```text
JsonIgnoreCondition.Never
JsonIgnoreCondition.Always
JsonIgnoreCondition.WhenWritingNull
JsonIgnoreCondition.WhenWritingDefault
```

---

## 3.1 `WhenWritingNull`

### Definition

`WhenWritingNull` means:

> Ignore the property when its value is `null` during serialization.

### Example

```csharp
public class Student
{
    public string Name { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Email { get; set; }
}
```

If:

```csharp
Student student = new Student
{
    Name = "Vanshika",
    Email = null
};
```

Then:

```csharp
string json = JsonSerializer.Serialize(student);
```

Output:

```json
{
  "Name": "Vanshika"
}
```

`Email` is omitted because it is `null`.

But if:

```csharp
Student student = new Student
{
    Name = "Vanshika",
    Email = "vanshika@gmail.com"
};
```

Output:

```json
{
  "Name": "Vanshika",
  "Email": "vanshika@gmail.com"
}
```

### Remember

```text
Email = null
      ↓
Ignored

Email = "abc@gmail.com"
      ↓
Included
```

---

# 4. `WhenWritingDefault`

### Definition

`WhenWritingDefault` means:

> Ignore the property when its value is the default value for its type.

### Example

```csharp
public class Student
{
    public string Name { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Age { get; set; }
}
```

For an `int`, the default value is:

```text
0
```

Therefore:

```csharp
Student student = new Student
{
    Name = "Vanshika",
    Age = 0
};
```

Output:

```json
{
  "Name": "Vanshika"
}
```

The `Age` property is omitted because its value is `0`.

If:

```csharp
Age = 21;
```

Output:

```json
{
  "Name": "Vanshika",
  "Age": 21
}
```

---

# 5. Default Values of Common C# Types

`WhenWritingDefault` depends on the type.

| C# Type | Default Value |
|---|---|
| `int` | `0` |
| `double` | `0` |
| `float` | `0` |
| `decimal` | `0` |
| `bool` | `false` |
| `char` | `'\0'` |
| `string` | `null` |
| Object/reference type | `null` |

For example:

```csharp
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
public int Age { get; set; }
```

`Age = 0` → ignored.

```csharp
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
public bool IsActive { get; set; }
```

`IsActive = false` → ignored.

---

# 6. Difference Between `[JsonIgnore]` and Conditional Ignore

### `[JsonIgnore]`

Always ignores the property.

```csharp
[JsonIgnore]
public string Password { get; set; }
```

Whether:

```text
Password = "abc123"
```

or:

```text
Password = null
```

the property is ignored.

---

### `WhenWritingNull`

Ignores the property **only when it is null**.

```csharp
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
public string Email { get; set; }
```

Therefore:

```text
Email = null
       → ignored

Email = "abc@gmail.com"
       → included
```

---

### `WhenWritingDefault`

Ignores the property **only when it has its default value**.

```csharp
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
public int Age { get; set; }
```

Therefore:

```text
Age = 0
     → ignored

Age = 21
     → included
```

---

# 7. Complete Example

```csharp
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Student
{
    [JsonPropertyName("student_name")]
    public string Name { get; set; }

    public int Age { get; set; }

    [JsonIgnore]
    public string Password { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Email { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsActive { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Vanshika",
            Age = 21,
            Password = "abc123",
            Email = null,
            IsActive = false
        };

        string json = JsonSerializer.Serialize(student);

        Console.WriteLine(json);
    }
}
```

Output:

```json
{
  "student_name": "Vanshika",
  "Age": 21
}
```

Why?

```text
Name
 ↓
[JsonPropertyName]
 ↓
student_name

Age
 ↓
Normal property
 ↓
Included

Password
 ↓
[JsonIgnore]
 ↓
Ignored

Email
 ↓
WhenWritingNull
 ↓
Value is null
 ↓
Ignored

IsActive
 ↓
WhenWritingDefault
 ↓
Value is false (default)
 ↓
Ignored
```

---

# 8. Quick Revision Table

| Attribute / Condition | Purpose |
|---|---|
| `[JsonPropertyName("x")]` | Changes JSON property name |
| `[JsonIgnore]` | Always ignores the property |
| `WhenWritingNull` | Ignores property when value is `null` |
| `WhenWritingDefault` | Ignores property when value is its default |
| `JsonIgnoreCondition.Never` | Never ignore the property |
| `JsonIgnoreCondition.Always` | Always ignore the property |

---

## Interview Answer

**Q: What are JSON attributes in `System.Text.Json`?**

**Answer:**

> JSON attributes are C# attributes provided by `System.Text.Json.Serialization` that allow us to control how C# properties are serialized and deserialized. Common attributes include `[JsonPropertyName]` for changing a JSON property name and `[JsonIgnore]` for excluding properties. `[JsonIgnore]` can also use conditions such as `WhenWritingNull` and `WhenWritingDefault` for conditional ignoring.

---

## Key Point to Remember

```text
[JsonPropertyName]
        ↓
Change the JSON name

[JsonIgnore]
        ↓
Always ignore

WhenWritingNull
        ↓
Ignore if null

WhenWritingDefault
        ↓
Ignore if default
```