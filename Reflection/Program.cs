using System;
using System.Reflection;


//Reflection, bir programın çalışma zamanında kendi yapısını incelemesine ve 
//değiştirmesine olanak tanıyan bir C# özelliğidir. Reflection, sınıfların, özelliklerin, yöntemlerin 
//ve diğer türlerin bilgilerini elde etmek, oluşturmak veya değiştirmek için kullanılır.
// bir örnekle inceleyelim


public class MyClass
{                                                
    public string MyProperty { get; set; }

    public void MyMethod()
    {
        Console.WriteLine("Hello, Reflection!");
    }
}

public class Program
{
    public static void Main()
    {
        // Sınıf tipini elde etme
        Type myClassType = typeof(MyClass);

        // Özelliklere erişim
        PropertyInfo propertyInfo = myClassType.GetProperty("MyProperty");
        Console.WriteLine("Property: " + propertyInfo.Name);

        // Bir örneği oluşturma
        object instance = Activator.CreateInstance(myClassType);
        propertyInfo.SetValue(instance, "Reflection Example");
        Console.WriteLine("Value: " + propertyInfo.GetValue(instance));

        // Yöntemlere erişim
        MethodInfo methodInfo = myClassType.GetMethod("MyMethod");
        methodInfo.Invoke(instance, null);
        Console.ReadLine();
    }
}
