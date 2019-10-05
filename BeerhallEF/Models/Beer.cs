namespace BeerhallEF.Models
{
    public class Beer
    {
        #region Properties
        public int BeerId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? AlcoholByVolume { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Getters
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        #endregion

        #region Constructors
        protected Beer()
        {
        }

        public Beer(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        #endregion
    }
}
