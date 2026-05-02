namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class ReservationResult
    {
        public bool Success { get; }
        public string Message { get; }

        private ReservationResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static ReservationResult Ok(string message)
        {
            return new ReservationResult(true, message);
        }

        public static ReservationResult Fail(string message)
        {
            return new ReservationResult(false, message);
        }
    }
}
