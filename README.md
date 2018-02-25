# localmicroservice


###Summary
loosely coupled class with auto discovery that act as executable nodes of a program, very old project 

###Features
it has an auto discovery feature to detect any class wich inherit from MicroService so the Main function is really simple:

```C#
namespace microservice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MicroServiceCore.Init(typeof(MainClass).Namespace,typeof(MainClass).Assembly);
		}
	}
}
```

services communicate between each other only using message, you can use custom message format with the IMessage interface, a basic StandardMessage already exists wich can transmit a string with a dictionnary of objects with string as key aswell

service communicate with MicroServiceBus, a service can send data to one or more bus(to be implemented)
the default bus is Main and will be used the most and is used in the example

the example is a simple console program wich read the user input to find a numbe + number pattern it consists of 3 services: the input service, process service and finally display service.
the input service will get the user input and sen it to the process service wich will parse input to add the two number 
it will send a message containing the result or "cant parse expression" to the display service wich will display it on the console


this readme will be updated and will contain better informations in the next updates 








