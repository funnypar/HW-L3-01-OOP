namespace Hospital_Management.Exceptions
{
    public class RoomFullException : Exception
    {
        public RoomFullException() : base("The room is full.")
        {
        }

        public RoomFullException(string message) : base(message)
        {
        }

        public RoomFullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
