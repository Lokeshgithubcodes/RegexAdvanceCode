namespace RegexAdvCodeProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-----Email validation
            Validation v= new Validation();
            v.emailvalid();

            //------Phone validation
            v.phoneValid();

            //-----password validation
            v.passwordValid();
        }
    }
}
