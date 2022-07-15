Add Scoped Lifetime 

In this service, with every HTTP request, we get a new instance.
The same instance is provided for the entire scope of that request.
This is a better option when you want to maintain a state within a request.

Add Transient Lifetime

A new service instance is created for each object in the HTTP request.
This is a good approach for the multithreading approach because both objects are independent of one another.
The instance is created every time they will use more memory and resources and can have a negative impact on performance
Utilize for the lightweight service with little or no state.

Add Singleton Lifetime

Only one service instance was created throughout the lifetime.
Reused the same instance in future, wherever the service is required
Since it's a single lifetime service creation, memory leaks in these services will build up over time.
Also, it has memory efficient as they are created once reused everywhere.

When to use which Service ?

Scoped approach => This is a better option when you want to maintain a state within a request.

Transient approach =>  Use this approach for the lightweight service with little or no state.

Singleton approach => We can use this for logging service, feature flag, and email service
