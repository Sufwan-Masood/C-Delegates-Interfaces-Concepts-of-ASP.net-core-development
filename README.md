<h1>C# Concepts: Interfaces and Delegates</h1>
<p>Welcome to this repository, which contains examples and explanations of various C# concepts related to interfaces and delegates. Below are the key topics covered in this repository:</p>

<h2>Table of Contents</h2>
<ul>
    <li><a href="#interfaces">Interfaces</a></li>
    <li><a href="#delegates">Delegates</a>
        <ul>
            <li><a href="#multicast-delegates">Multicast Delegates</a></li>
            <li><a href="#built-in-delegates">Built-in Delegates</a></li>
            <li><a href="#event-handling">Event Handling</a></li>
            <li><a href="#callbacks">Callbacks</a></li>
            <li><a href="#dynamic-method-invocation">Dynamic Method Invocation</a></li>
            <li><a href="#anonymous-delegates">Anonymous Delegates</a></li>
        </ul>
    </li>
</ul>

<h2 id="interfaces">Interfaces</h2>
<p>Interfaces define a contract that implementing classes must fulfill. They are used to achieve abstraction and multiple inheritance in C#.</p>

<pre>
<code>
public interface IVehicle {
    void Display();
}

public class Car : IVehicle {
    public void Display() {
        Console.WriteLine("Car Display");
    }
}

public class Bike : IVehicle {
    public void Display() {
        Console.WriteLine("Bike Display");
    }
}
</code>
</pre>

<h2 id="delegates">Delegates</h2>
<p>Delegates are type-safe pointers to methods. They allow methods to be passed as parameters and enable event-driven programming.</p>

<h3 id="multicast-delegates">Multicast Delegates</h3>
<p>A multicast delegate can point to multiple methods and invoke them in sequence.</p>

<pre>
<code>
public delegate void showInfo();
showInfo displayDelegate = Method1;
displayDelegate += Method2;
displayDelegate();
</code>
</pre>

<h3 id="built-in-delegates">Built-in Delegates</h3>
<p>C# provides built-in delegates like <code>Action</code>, <code>Func</code>, and <code>Predicate</code> to simplify common delegate scenarios.</p>

<pre>
<code>
Action showMessage = () => Console.WriteLine("Hello, World!");
showMessage();

Func<int, int, int> add = (x, y) => x + y;
Console.WriteLine(add(3, 4));
</code>
</pre>

<h3 id="event-handling">Event Handling</h3>
<p>Delegates are the foundation of event handling in C#. Events are used to signal actions.</p>

<pre>
<code>
public class Publisher {
    public event Action OnChange;

    public void RaiseEvent() {
        OnChange?.Invoke();
    }
}

public class Subscriber {
    public void Subscribe(Publisher publisher) {
        publisher.OnChange += RespondToEvent;
    }

    private void RespondToEvent() {
        Console.WriteLine("Event received!");
    }
}
</code>
</pre>

<h3 id="callbacks">Callbacks</h3>
<p>Callbacks are methods passed as arguments to other methods and invoked after some operation completes.</p>

<pre>
<code>
public delegate void Callback();

public class Worker {
    public void DoWork(Callback callback) {
        Console.WriteLine("Working...");
        callback();
    }
}

public class Example {
    public static void Main() {
        Worker worker = new Worker();
        worker.DoWork(() => Console.WriteLine("Work complete!"));
    }
}
</code>
</pre>

<h3 id="dynamic-method-invocation">Dynamic Method Invocation</h3>
<p>Delegates can be used to dynamically invoke methods at runtime.</p>

<pre>
<code>
public delegate void showInfo();

public class DynamicInvoker {
    public void InvokeMethod(showInfo method) {
        method();
    }
}

public class Example {
    public static void Main() {
        DynamicInvoker invoker = new DynamicInvoker();
        showInfo method = () => Console.WriteLine("Dynamically Invoked!");
        invoker.InvokeMethod(method);
    }
}
</code>
</pre>

<h3 id="anonymous-delegates">Anonymous Delegates</h3>
<p>Anonymous delegates provide a way to define inline methods without explicitly declaring them.</p>

<pre>
<code>
public class Example {
    public static void Main() {
        showInfo showMessage = delegate {
            Console.WriteLine("Anonymous delegate invoked!");
        };

        showMessage();
    }
}
</code>
</pre>
