namespace ProjectGSM
{
    using System;

    public class GSMTests
    {
        public static void Main()
        {
            GSMTest();

            GSMCallHistoryTest();
        }

        private static void GSMCallHistoryTest()
        {
            GSM gsmTest = new GSM("Sony", "Ulala");

            gsmTest.AddCall("+359773444444", 12);
            gsmTest.AddCall("+359881555555", 431);
            gsmTest.AddCall("+359888666666", 12);

            gsmTest.ShowCallHistory();

            Console.WriteLine("Total call price: " + gsmTest.TotalCallPrice(0.20m));

            gsmTest.DeleteCall(2);
            Console.WriteLine("Removed Longest call!");

            Console.WriteLine("Total call price: " + gsmTest.TotalCallPrice(0.20m));

            gsmTest.ClearCallHistory();
            Console.WriteLine("Cleared call history!");
            gsmTest.ShowCallHistory();
        }

        private static void GSMTest()
        {
            GSM test1 = new GSM("Sony", "Blabla", 134000, "SomeOwner", 
                new Battery("SomeBattery", 555, 555, Type.NiCd),
                new Display(100, 20000000));

            GSM test2 = new GSM("LG", "Thailand");

            GSM test3 = new GSM("Samsung", "Samsung", 100, "Mmmm", 
                new Battery(), 
                new Display());

            GSM[] testAll = new GSM[] { test1, test2, test3 };

            foreach (var gsm in testAll)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
