// using System;
// namespace Adapter.Structural
// {
//  /// <summary>
//  /// Adapter Design Pattern
//  /// </summary>
//  public class Program
//  {
//  public static void Main(string[] args)
//  {
//  // Create adapter and place a request
//  Target target = new Adapter();
//  target.Request();
//  // Wait for user
//  Console.ReadKey();
//  }
//  }
// /// <summary>
//  /// The 'Target' class
//  /// </summary>
//  public class Target
//  {
//  public virtual void Request()
//  {
//  Console.WriteLine("Called Target Request()");
//  }
//  }
//  /// <summary>
//  /// The 'Adapter' class
//  /// </summary>
//  public class Adapter : Target
//  {
//  private Adaptee adaptee = new Adaptee();
//  public override void Request()
//  {
//  // Possibly do some other work
//  // and then call SpecificRequest
//  adaptee.SpecificRequest();
//  }
//  }
//  /// <summary>
//  /// The 'Adaptee' class
//  /// </summary>
//  public class Adaptee
//  {
//  public void SpecificRequest()
//  {
//  Console.WriteLine("Called SpecificRequest()");
//  }
//  }
// }

using System;

namespace Adapter.Structural
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            TwoPinSocket socket = new SocketAdapter();
            socket.ConnectTwoPinDevice();

            // Wait for user input before closing
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Target' class representing a two-pin socket
    /// </summary>
    public class TwoPinSocket
    {
        public virtual void ConnectTwoPinDevice()
        {
            Console.WriteLine("Two-pin device connected to a two-pin socket.");
        }
    }

    /// <summary>
    /// The 'Adapter' class representing the adapter between a three-pin plug and two-pin socket
    /// </summary>
    public class SocketAdapter : TwoPinSocket
    {
        private ThreePinPlug threePinPlug = new ThreePinPlug();

        public override void ConnectTwoPinDevice()
        {
            Console.WriteLine("Adapter converts the connection for a two-pin socket...");
            threePinPlug.ConnectThreePinDevice();
        }
    }

    /// <summary>
    /// The 'Adaptee' class representing a three-pin plug
    /// </summary>
    public class ThreePinPlug
    {
        public void ConnectThreePinDevice()
        {
            Console.WriteLine("Three-pin device connected using an adapter.");
        }
    }
}


