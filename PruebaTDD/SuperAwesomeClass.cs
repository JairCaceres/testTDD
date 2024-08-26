namespace PruebaTDD
{
    public class SuperAwesomeClass
    {
        private INotSoAwesomeClass _notSoAwesomeClass;
        private float _myNumber;

        public SuperAwesomeClass(INotSoAwesomeClass notSoAwesomeClass, float number)
        {
            _notSoAwesomeClass = notSoAwesomeClass;
            _myNumber = number;
        }

        public float SuperTesteableMethod()
        {
            var aNumber = _notSoAwesomeClass.GiveMeANumber();

            if (aNumber == 0)
                throw new ArithmeticException("Division by zero");

            if (aNumber < 0)
                return _myNumber;

            return _myNumber / aNumber;
        }

        public bool AnotherSuperTesteableMethod()
        {
            return "control text" == this._notSoAwesomeClass.GiveMeAString();
        }


    }
}