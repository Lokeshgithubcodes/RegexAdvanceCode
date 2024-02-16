namespace RegexAdvCodeProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////-----Email validation
            Validation v= new Validation();
            //v.emailvalid();

            ////------Phone validation
            //v.phoneValid();

            ////-----password validation
            //v.passwordValid();


            //------lICENSE PLATES

            string filepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\LicensePlateNumbers.txt";
            if(File.Exists(filepath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string plateNo= sr.ReadLine();
                            v.licenseplate(plateNo);
                        }
                        
                    }

                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Not exsits");
            }
            Console.WriteLine("------phone number validation");
            // phone number validation

            string phonefilepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\Phone numbers.txt";
            if(File.Exists(phonefilepath))
            {
                try
                {
                    using (StreamReader srr = new StreamReader(phonefilepath))
                    {
                        while (!srr.EndOfStream)
                        {
                            string phoneNo = srr.ReadLine();
                            v.phoneValid(phoneNo);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("not exists");
            }
            Console.WriteLine("------password validation");
            // password validation

            string pwdfilepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\Password Validation.txt";
            if (File.Exists(pwdfilepath))
            {
                try
                {
                    using(StreamReader srp = new StreamReader(pwdfilepath))
                    {
                        while (!srp.EndOfStream)
                        {
                            string pwdNo = srp.ReadLine();
                            v.passwordValid(pwdNo);
                        }
                    }

                }catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                 }

            }
            else
            {
                Console.WriteLine("file not found");
            }

            Console.WriteLine("-----Html Regex");

               Html.html();
        }
    }
}
