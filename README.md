## .NET C# Console Application

### Prerequisites:

Install [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)

Install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)


### Loose Agenda:

Play with C# and create a console application

### Step by Step

#### Setup playground

Create a directory for this exercise

Open Visual Studio 2019

Create a new project > Console App (.NET Core)

Name: dotnet-csharp-console
Location: C:\dev\non-zero-days\dotnet-csharp-console
Solution Name: Leave default

Click Create

#### Printing Output

You should now be in the templated project with Program.cs open. Note the files listed in the Solution Explorer window. This code is already written to print output so let's compile and run the code.

From the top ribbon select Build > Build Solution.

On success, from the top ribbon select Debug > Start Debugging.

Note that a command prompt should open which says "Hello World!"

At the time of creating this exercise the template for a .NET 5.0 Console Application is still not available. If you experience an error in these steps do this following:

From the Solution Explorer window open the dotnet-csharp-console project file.
If you find a TargetFramework node like

```
    <TargetFramework>netcoreapp3.1</TargetFramework>
```

Replace it with the following text
```
    <TargetFramework>net5.0</TargetFramework>
```

Save and close the file then repeat this step.


#### User Input

The default generated code for the Main method takes in an array of strings as an argument. Currently we do nothing with this input. Let's instead use it as an output.

Replace your Main method with the following code:
```
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
        }
```

Right click the dotnet-csharp-console project and select Properties

On the left side navigation menu select Debug

In Application arguments let's write the following:
```
"Non-Zero Days sample code"
```

Now you can run the code again and see the output matches what we put in the Application arguments field.


#### Conditional If

In the event that our code didn't have an argument we would have received an error. Let's write an if statement to block for that condition.

Replace your Main method with the following code:
```
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("No input received.");
            }
            else
            {
                Console.WriteLine(args[0]);
            }
        }
```

Run the code with and without Application arguments and note the different messages.


#### For Loop

In the event that multiple arguments were submit to the program, only the first would be displayed. Test this by replacing your Application arguments with the following then running the code:
```
"Bunny" "Bat" "Non-Zero Days"
```

Let's write a for loop to iterate over the arguments provided and show each.

Replace your Main method with the following code:
```
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("No input received.");
            }
            else
            {
                for(int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine(args[index]);
                }
            }
        }
```

Run the code again and note that each argument is output.

#### File Input

Let's now use text files instead of Application arguments.

In the Solution Explorer Window, right click the dotnet-csharp-console project and select Add > New Item... then use the top right search to find the "Text File" option. Enter text.txt in the name and select Add.

Open test.txt in the Solution Explorer window and enter the following text

```
Have you considered liking and subscribing?
This text is really subtle.
But actually though.
```

Right click test.txt in the Solution Rxplorer window and select Properties.
In the Properties window change 'Copy to Output Directory' to Copy always

Open Program.cs and replace with Main method with:
```
        static void Main(string[] args)
        {
            Console.WriteLine(System.IO.File.ReadAllText("test.txt"));
        }
```

Run the program and see that the result should now be the contents of the test.txt file.

#### File Output

Open Program.cs and replace with Main method with:
```
        static void Main(string[] args)
        {
            Console.WriteLine("Content of text file was:");
            Console.WriteLine(System.IO.File.ReadAllText("test.txt"));

            if (args.Length > 0)
            {
                System.IO.File.WriteAllText("test.txt", args[0]);
            }

            Console.WriteLine("Content of text file is now:");
            Console.WriteLine(System.IO.File.ReadAllText("test.txt"));
        }
```

Note once again only the first argument will be used due to the use of 'args[0]' 

Run the code with an argument such as "Bunnies" and note the output. 

Congratulations on a Non-Zero Day!
