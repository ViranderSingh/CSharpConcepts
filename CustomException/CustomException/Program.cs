#nullable enable

using System;
using System.IO;
using System.Runtime.Serialization; //As SerializationInfo is a part of the System.Runtime.Serialization namespace

namespace CustomException
{
    class Program
    {
        static void Main()
        {
            //throw new FileNotFoundException("File XYZ is not found");
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in : No duplicate sessions allowed");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
    public UserAlreadyLoggedInException(string? message) : base(message)
    {

    }
    public UserAlreadyLoggedInException(string? message, Exception? innerException) : base(message, innerException)
    {

    }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}