namespace LR4
{
    class Money
    {
        public Money(int nominal, int quantity)
        {
            this.nominal = nominal;
            this.quantity = quantity;
        }

        public int nominal
        {
            get; 
            set;
        }
        public int quantity
        {
            get; 
            set;
        }

        public int value 
        {
            get => quantity * nominal;
        }

        // Подсчитать сколько единиц товара можно купить на имеющиеся деньги
        public int CalculateCountOfItems(int price)
        {
            return quantity * nominal / price; 
        }

        public int this[int i]
        {
            get 
            {
                if (i == 1) return nominal;
                else if (i == 2) return quantity;
                throw new IndexOutOfRangeException("Index can be 1 and 2");
            }
        }

        public static Money operator ++(Money money)
        {
            money.quantity++;
            money.nominal++;
            return money;
        }

        public static Money operator --(Money money)
        {
            money.quantity--;
            money.nominal--;
            return money;
        }

        public static bool operator !(Money money)
        {
            return money.quantity != 0;
        }

        public static Money operator +(Money money, int quantity)
        {
            money.quantity += quantity;
            return money;
        }
    }
}