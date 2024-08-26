namespace PruebaTDD
{
    public interface INotSoAwesomeClass
    {
        public int GiveMeANumber();
        public string GiveMeAString();
    }

    public class NotSoAwesomeClass
    {
        public int GiveMeANumber()
        {
            return 42;
        }

        public string GiveMeAString()
        {
            return "this is a message: " + this.GiveMeAPayload("a payload");
        }

        private string GiveMeAPayload(string payload)
        {
            return payload;
        }
    }
}
