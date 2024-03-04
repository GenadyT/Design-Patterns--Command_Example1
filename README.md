## Command Design Pattern / Example 1

This .Net C# project demonstrates "Command" design pattern and is inspired by the book - 
	-------------------------------------------------------------------
	Freeman, Eric; Robson, Elisabeth; Bates, Bert; Sierra, Kathy. 
	Head First Design Patterns: A Brain-Friendly Guide. O'Reilly Media.
	-------------------------------------------------------------------

### Pattern Definition

The Command Pattern encapsulates a request as an object, thereby letting you parameterize other 
objects with different requests, queue or log requests, and support undoable operations.

### Pattern Details

Pattern Theoretical Participant Classes:
---------------------------------------
	Command: Declares an interface for executing an operation.
	ConcreteCommand: Defines a binding between a Receiver object and an action.
	Client: Creates a ConcreteCommand object and sets its receiver.
	Invoker: Asks the command to carry out the request.
	Receiver: Knows how to perform the operations associated with carrying out the request.

### Project Topic

This project participants:
-------------------------
	The pattern Invoker classes are the project  UI buttons: SwitchButton, SwitchRadioButton
	The pattern Command classes are the project LightOffCommand, LightOnCommand, MacroCommand classes
	The pattern Receiver class is the project MyRoomLight User Control	

#### External Resources

The project images are taken from - https://en.ac-illust.com/	
(no need to specify the images authors)

