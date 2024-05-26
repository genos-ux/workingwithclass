namespace WorkingWIthClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankA = new Bank(){Deposit = 100};
            Bank bankB = new Bank(){Deposit = 150};
            Bank bankC = new Bank(){Deposit = 200};

            bankA.getBalance();
            bankB.getBalance();
            bankC.getBalance();
        }
    }

    class Bank
    {
        private double deposit;

        public double Deposit
        {
            get{ return deposit; }
            set {deposit = value;}
        }
        public void getBalance()
        {
            Console.WriteLine("The amount balance is {0:C}",this.Deposit);

        }

    }


}
