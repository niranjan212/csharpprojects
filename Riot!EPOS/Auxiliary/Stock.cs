using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riot_EPOS.Auxiliary
{
    internal class Stock
    {
        public class StockFile
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            public string Colour { get; set; }
            public decimal Cost { get; set; }
            public decimal Savings { get; set; }
            public decimal DiscountedPrice { get; set; }
            public decimal Tax { get; set; }
            public int StockLevel { get; set; }
            public bool IsAvailable { get; set; }
            public int Quantity { get; set; }

            public StockFile(int Id, string Name, string Size, string Colour, decimal Cost, decimal Savings, decimal DiscountedPrice, decimal Tax, int StockLevel, bool IsAvailable, int Quantity)
            {
                this.Id = Id;
                this.Name = Name;
                this.Size = Size;
                this.Colour = Colour;
                this.Cost = Cost;
                this.Savings = Savings;
                this.StockLevel = StockLevel;
                this.DiscountedPrice = DiscountedPrice;
                this.Tax = Tax;
                this.IsAvailable = IsAvailable;
                this.Quantity = 0;
            }

            public override string ToString()
            {
                return "Name: " + Name + ", Size: " + Size + ", Color: " + Colour + ", Cost: " + Cost.ToString("n2") + " EUR , Quantity: " + Quantity;
            }

            public class StockFileMethods
            {
                private string FilePath = "";
                public StockFileMethods(string TargetFile)
                {
                    FilePath = TargetFile;
                }

                public List<StockFile> ReadItemsFromFile()
                {
                    List<StockFile> Items = new List<StockFile>();

                    try
                    {
                        StreamReader Reader;
                        Reader = File.OpenText(FilePath);

                        while (!Reader.EndOfStream)
                        {
                            string R = Reader.ReadLine();
                            string[] Features = R.Split(',');

                            StockFile item = new StockFile(int.Parse(Features[0]), Features[1], Features[2], Features[3], decimal.Parse(Features[4]), decimal.Parse(Features[5]), decimal.Parse(Features[6]), decimal.Parse(Features[7]), int.Parse(Features[8]), Boolean.Parse(Features[9]), int.Parse(Features[10]));
                            Items.Add(item);
                        }
                        Reader.Close();
                    }

                    catch
                    {
                        Console.WriteLine("Error reading file");
                    }
                    return Items;
                }

                public List<String> ReadUniqueProductsFromFile()
                {
                    List<String> UniqueAvailableItems = new List<String>();
                    try
                    {
                        StreamReader Reader;
                        Reader = File.OpenText(FilePath);

                        while (!Reader.EndOfStream)
                        {
                            string R = Reader.ReadLine();
                            string[] Features = R.Split(',');

                            StockFile Item = new StockFile(int.Parse(Features[0]), Features[1], Features[2], Features[3], decimal.Parse(Features[4]), decimal.Parse(Features[5]), decimal.Parse(Features[6]), decimal.Parse(Features[7]), int.Parse(Features[8]), Boolean.Parse(Features[9]), int.Parse(Features[10]));
                            if (Item.IsAvailable)
                            {
                                if (!UniqueAvailableItems.Contains(Item.Name))
                                    UniqueAvailableItems.Add(Item.Name);
                            }
                        }
                        Reader.Close();
                    }

                    catch
                    {
                        Console.WriteLine("Error reading file");
                    }
                    return UniqueAvailableItems;
                }

                public List<String> ReadUniqueSizesFromFile()
                {
                    List<String> UniqueAvailableItems = new List<String>();
                    try
                    {
                        StreamReader Reader;
                        Reader = File.OpenText(FilePath);

                        while (!Reader.EndOfStream)
                        {
                            string f = Reader.ReadLine();
                            string[] Features = f.Split(',');

                            StockFile Item = new StockFile(int.Parse(Features[0]), Features[1], Features[2], Features[3], decimal.Parse(Features[4]), decimal.Parse(Features[5]), decimal.Parse(Features[6]), decimal.Parse(Features[7]), int.Parse(Features[8]), Boolean.Parse(Features[9]), int.Parse(Features[10]));
                            if (Item.IsAvailable)
                            {
                                if (!UniqueAvailableItems.Contains(Item.Size))
                                    UniqueAvailableItems.Add(Item.Size);
                            }
                        }
                        Reader.Close();
                    }

                    catch
                    {
                        Console.WriteLine("Error reading file");
                    }
                    return UniqueAvailableItems;
                }

                public List<String> ReadUniqueColoursFromFile()
                {
                    List<String> UniqueAvailableItems = new List<String>();
                    try
                    {
                        StreamReader Reader;
                        Reader = File.OpenText(FilePath);

                        while (!Reader.EndOfStream)
                        {
                            string f = Reader.ReadLine();
                            string[] Features = f.Split(',');

                            StockFile Item = new StockFile(int.Parse(Features[0]), Features[1], Features[2], Features[3], decimal.Parse(Features[4]), decimal.Parse(Features[5]), decimal.Parse(Features[6]), decimal.Parse(Features[7]), int.Parse(Features[8]), Boolean.Parse(Features[9]), int.Parse(Features[10]));
                            if (Item.IsAvailable)
                            {
                                if (!UniqueAvailableItems.Contains(Item.Colour))
                                    UniqueAvailableItems.Add(Item.Colour);
                            }
                        }
                        Reader.Close();
                    }

                    catch
                    {
                        Console.WriteLine("Error reading file");
                    }
                    return UniqueAvailableItems;
                }
            }
        }
    }
}
