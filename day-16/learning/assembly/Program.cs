using System.Reflection;

// Assembly assembly = Assembly.GetExecutingAssembly();
// Console.WriteLine(assembly.FullName);
// Assembly.Load("MyLibrary");
// Assembly.LoadFrom("MyPlugin.dll");

// Assembly assembly = Assembly.GetExecutingAssembly();

// foreach (Type type in assembly.GetTypes())
// {
//     if (type.Name.EndsWith("Service"))
//     {
//         Console.WriteLine("Discovered Service: " + type.Name);
//     }
// }


// Type type = typeof(Demo);
// object obj = Activator.CreateInstance(type);
// // Type type = demoObject.GetType();
// // Type type = Type.GetType("Demo");
// MethodInfo method = type.GetMethod("ShowSalary");
// method.Invoke(obj, null);

// Type type = typeof(Demo);
// object objectInstance = Activator.CreateInstance(type);
// FieldInfo field = type.GetField(
//     "_salary",
//     BindingFlags.NonPublic | BindingFlags.Instance
// );
// Console.WriteLine("Before: " + field.GetValue(objectInstance));
// field.SetValue(objectInstance, 50000);
// Console.WriteLine("After: " + field.GetValue(objectInstance));

// Type type = typeof(Demo);
// ConstructorInfo? ctor1 = type.GetConstructor(Type.EmptyTypes);
// if (ctor1 == null)
// {
//     Console.WriteLine("Parameterless constructor not found");
//     return;
// }
// object obj1 = ctor1.Invoke(null);

// // Constructor with parameters:
// ConstructorInfo ctor2 = type.GetConstructor(
//     new Type[] { typeof(string), typeof(int) }
// );
// object obj2 = ctor2.Invoke(new object[] { "Ayush", 23 });
// MethodInfo methodInfo = type.GetMethod("Show");
// methodInfo.Invoke(obj2, null);


Type type = typeof(Employee);
Console.WriteLine("Class Name: " + type.Name);
Console.WriteLine("Namespace: " + type.Namespace);
Console.WriteLine("\nProperties:");
foreach (PropertyInfo prop in type.GetProperties())
{
    Console.WriteLine($"{prop.Name} - {prop.PropertyType}");
}
Console.WriteLine("\nMethods:");
foreach (MethodInfo method in type.GetMethods())
{
    Console.WriteLine(method.Name);
}

Type type1 = typeof(Demo);
Console.WriteLine("Class Name: " + type1.Name);
Console.WriteLine("Namespace: " + type1.Namespace);
Console.WriteLine("\nProperties:");
foreach(PropertyInfo prop in type1.GetProperties())
{
    Console.WriteLine($"{prop.Name} - {prop.PropertyType}");
}
Console.WriteLine("\nMethods:");
foreach(MethodInfo methodInfo in type1.GetMethods())
{
    Console.WriteLine(methodInfo.Name);
}
Console.WriteLine("\nFields:");
foreach(FieldInfo fieldInfo in type1.GetFields())
{
    Console.WriteLine($"{fieldInfo.Name}");
}
Console.WriteLine("\nConstructor: ");
foreach(ConstructorInfo constructorInfo in type1.GetConstructors())
{
    Console.WriteLine($"{constructorInfo.Name}");
}
