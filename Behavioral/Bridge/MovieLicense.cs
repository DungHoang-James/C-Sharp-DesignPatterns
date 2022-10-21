using System;

namespace Bridge
{
    public class MovieLicense
    {
        private readonly Discount _discount;
        private readonly LicenceType _licenceType;

        public string Movie { get; }
        public DateTime PurchaseTime { get; }

        public MovieLicense(
            string movie,
            DateTime purchaseTime,
            Discount discount,
            LicenceType licenceType)
        {
            Movie = movie;
            PurchaseTime = purchaseTime;
            _discount = discount;
            _licenceType = licenceType;
        }

        public decimal GetPrice()
        {
            int discount = GetDiscount();
            decimal multiplier = 1 - discount / 100m;
            return GetBasePrice() * multiplier;
        }

        private int GetDiscount()
        {
            return _discount switch
            {
                Discount.None => 0,
                Discount.Military => 10,
                Discount.Senior => 20,

                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private decimal GetBasePrice()
        {
            return _licenceType switch
            {
                LicenceType.TwoDays => 4,
                LicenceType.LifeLong => 8,

                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private DateTime? GetBaseExpirationDate()
        {
            return _licenceType switch
            {
                LicenceType.TwoDays => PurchaseTime.AddDays(2) as DateTime?,
                LicenceType.LifeLong => null,

                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}