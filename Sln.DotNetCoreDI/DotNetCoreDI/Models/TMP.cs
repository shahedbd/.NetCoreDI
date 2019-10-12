using System;

namespace DotNetCoreDI.Models
{
    public class TMP
    {
    }

    public interface IMobilePhone
    {
        void IneternetBrowse();
        void CallFunction();
    }

    public class MobilePhone : IMobilePhone
    {
        public void IneternetBrowse()
        {
            Console.WriteLine("It Ensure Mobile Call Function");
        }

        public void CallFunction()
        {
            Console.WriteLine("It Ensure Ineternet Browse Function");
        }
    }


    //With DI
    public class Human
    {
        IMobilePhone _mobilePhone;
        public Human(IMobilePhone mobilePhone)
        {
            _mobilePhone = mobilePhone;
        }
        public void BasciNeed()
        {
            _mobilePhone.CallFunction();
            _mobilePhone.IneternetBrowse();
        }
    }

    //Without DI
    public class Human2
    {
        MobilePhone _MobilePhone = new MobilePhone();
        public void BasciNeed()
        {
            _MobilePhone.CallFunction();
            _MobilePhone.IneternetBrowse();
        }
    }

}
