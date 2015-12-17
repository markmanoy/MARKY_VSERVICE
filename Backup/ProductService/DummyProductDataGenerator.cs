using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService
{
    public class DummyProductDataGenerator
    {

        public List<ProductType> DummyProductType()
        {
            var retVal = new List<ProductType>();

            retVal.Add(new ProductType(1, "PC & Laptops"));
            retVal.Add(new ProductType(2, "Mobile & Tablets"));
            retVal.Add(new ProductType(3, "Cameras"));
            retVal.Add(new ProductType(4, "Others"));

            return retVal;


        }


        public List<ProductSubType> DummyProductSubType()
        {
            var retVal = new List<ProductSubType>();
            retVal.Add(new ProductSubType(1, 1, "Computer"));
            retVal.Add(new ProductSubType(2, 1, "Laptop and Netbooks"));
            retVal.Add(new ProductSubType(3, 1, "Parts & Accessories"));
            retVal.Add(new ProductSubType(4, 1, "Others "));


            retVal.Add(new ProductSubType(5, 2, "Smartphone"));
            retVal.Add(new ProductSubType(6, 2, "Tablet"));
            retVal.Add(new ProductSubType(7, 2, "Phablet"));
            retVal.Add(new ProductSubType(8, 2, "Accessories"));

            retVal.Add(new ProductSubType(9, 3, "DSLR"));
            retVal.Add(new ProductSubType(10, 3, "Mirrorless"));
            retVal.Add(new ProductSubType(11, 3, "Point & shoot"));
            retVal.Add(new ProductSubType(12, 3, "Accessories"));
            return retVal;
        }


        public List<Product> DummyProduct()
        {
            var retVal = new List<Product>();
            //PC and Laptops (type 1)
            int id = GetNExtId(retVal);
            retVal.Add(new Product(id, "Compaq Presario CQ1130L PC", "HP", 13450, 1, 1));
            retVal.Add(new Product(id+1, "Lenovo C225 All in one Desktop", "Lenovo", 18200, 1, 1));
            retVal.Add(new Product(id+2, "Lenovo C200 (5712-5982)", "Lenovo", 18700, 1, 1));
            retVal.Add(new Product(id+3, "LENOVO H520S 57306501 DESKTOP", "Lenovo", 25700, 1, 1));
            retVal.Add(new Product(id+4, "LENOVO B320 57304412 DESKTOP", "Lenovo", 33700, 1, 1));
            retVal.Add(new Product(id + 5, "ASUS ET2210IUTS-B028C", "Asus", 38600, 1, 1));
            retVal.Add(new Product(id + 6, "ASUS CP6230-PH001M (H61)", "Asus", 26700, 1, 1));
            retVal.Add(new Product(id + 7, "Asus Essentio CP6130", "Asus", 26395, 1, 1));
            retVal.Add(new Product(id + 8, "ACER VERITON X4610G", "Acer", 23650, 1, 1));
            retVal.Add(new Product(id + 9, "Acer Veriton S6610G (Ci5-2320 DOS)", "Acer", 25300, 1, 1));
            retVal.Add(new Product(id + 10, "HP P2-1150I", "HP", 19250, 1, 1));
            retVal.Add(new Product(id + 11, "HP P2-1150I DESKTOP", "HP", 23300, 1, 1));
            retVal.Add(new Product(id + 12, "ACER Z5770 Limited Olympic Edition", "Acer", 44500, 1, 1));

            retVal.Add(new Product(id + 13, "Acer AS4752-32352G50Mn", "Acer", 28900, 1, 2));
            retVal.Add(new Product(id + 14, "Asus VivoBook X202E-CT010H", "Asus", 20995, 1, 2));
            retVal.Add(new Product(id + 14, "Asus K45VD-VX161", "Asus", 26500, 1, 2));
            retVal.Add(new Product(id + 15, "Asus K45VM-VX073R", "Asus", 35995, 1, 2));
            retVal.Add(new Product(id + 16, "Asus K55VJ-SX074H", "Asus", 42995, 1, 2));
            retVal.Add(new Product(id + 17, "Asus Zenbook Touch UX31A-C4027H", "Asus", 76995, 1, 2));
            retVal.Add(new Product(id + 18, "Asus G75VX-CV040H", "Asus", 99995, 1, 2));
            retVal.Add(new Product(id + 19, "Samsung NP-300E4A SO4PHSV", "Samsung", 26000, 1, 2));
            retVal.Add(new Product(id + 20, "SAMSUNG NP-300E4C-A03PHSV", "Samsung", 18400, 1, 2));
            retVal.Add(new Product(id + 21, "Samsung NP-RV415", "Samsung", 19250, 1, 2));
            retVal.Add(new Product(id + 22, "Samsung NP-300E4A-A-04", "Samsung", 27500, 1, 2));
            retVal.Add(new Product(id + 23, "SAMSUNG NP-535U3C-A02PH", "Samsung", 27600, 1, 2));
            retVal.Add(new Product(id + 24, "Acer E1-431-B822G50Mnks", "Acer",22995 , 1, 2));


            retVal.Add(new Product(id + 25, "PS2 Scroll Mouse", "", 60, 1, 3));
            retVal.Add(new Product(id + 26, "18.5 Asus VH197D LED Widescreen", "Asus", 4200, 1, 3));
            retVal.Add(new Product(id + 27, "23 ASUS VS239H LED MONITOR", "Asus", 8900, 1, 3));
            retVal.Add(new Product(id + 28, "Intel G630 2.7Ghz 3mb Pentium Dual Core", "Intel", 2230, 1, 3));
            retVal.Add(new Product(id + 29, "Intel Core i3 3210 3.2Ghz 3MB LGA1155", "Intel", 4680, 1, 3));
            retVal.Add(new Product(id + 30, "Intel Core i3 3220 3.3Ghz 3MB LGA1155", "Intel", 4930, 1, 3));
            retVal.Add(new Product(id + 31, "Intel Core i5-3330 3.0Ghz 6MB LGA1155", "Intel", 7800, 1, 3));
            retVal.Add(new Product(id + 32, "Intel Core i5 3550 3.30Ghz 6MB LGA1155", "Intel", 8830, 1, 3));
            retVal.Add(new Product(id + 33, "Intel Core i7 3770 3.4Ghz(Up to 3.90Ghz) 8MB LGA1155", "Intel", 12730, 1, 3));
            retVal.Add(new Product(id + 34, "Intel Core i7 3820 3.6Ghz 10MB LGA2011", "Intel", 12850, 1, 3));
            retVal.Add(new Product(id + 35, "Intel Core i7 3930K 3.2Ghz 12MB LGA2011", "Intel", 25600, 1, 3));

            


            //Mobile & Tablets(type 2)
             id = GetNExtId(retVal);
             retVal.Add(new Product(id , "Galaxy S4 16GB", "Samsung", 30990, 2, 5));
            retVal.Add(new Product(id +1, "Galaxy S3 16GB", "Samsung", 28900, 2, 5));
            retVal.Add(new Product(id +2, "Xperia Z 16GB", "Sony", 29990, 2, 5));
            retVal.Add(new Product(id +3, "Xperia V 8GB", "Sony", 26490, 2, 5));
            retVal.Add(new Product(id +4, "Apple iPhone 5 16GB", "Apple", 46489, 2, 5));
            retVal.Add(new Product(id +5, "Blackberry z10", "BlackBerry", 29990, 2, 5));
            retVal.Add(new Product(id +6, "Lumia 820", "Nokia", 18990, 2, 5));

            retVal.Add(new Product(id +7, "Apple iPad Mini 16GB WIFI and 3G", "Apple", 21990, 2, 6));
            retVal.Add(new Product(id +8, "Apple iPad 4 16GB WIFI", "Apple", 22998, 2, 6));

            retVal.Add(new Product(id +9, "Galaxy Note 2", "Samsung", 2200, 2, 7));


            //Cameras (type 3)
            id = GetNExtId(retVal);
            retVal.Add(new Product(id, "Canon 1000d DSLR Camera w/ 18-55 Lens", "Cannon", 13999, 3, 9));
            retVal.Add(new Product(id+1, "NIKON D40x 18-55mm lens 10.2mp", "Nikon", 13000, 3, 9));
            retVal.Add(new Product(id+2, "NIKON D50", "Nikon", 18000, 3, 9));
            retVal.Add(new Product(id+3, "Canon X5", "Cannon", 21000, 3, 9));
            retVal.Add(new Product(id+4, "Nikon D3100", "Nikon", 16500, 3, 9));


            retVal.Add(new Product(id+5, "Panasonic Lumix DMC G3 16MP Mirrorless Camera", "Panasonic", 16500, 3, 10));
            retVal.Add(new Product(id + 6, "Olympus Pen E-PL1 micro 4/3 mirrorless semi pro camera", "Olympus", 15000, 3, 10));
            retVal.Add(new Product(id + 7, "Pentax Q Zoom Lens Kit Mirrorless Digital Camera", "Pentax", 13900, 3, 10));
            retVal.Add(new Product(id+8, "Sony a NEX 6L 16.1 MP Digital camera - mirrorless system", "Sony", 32400, 3, 210));


            retVal.Add(new Product(id + 9, "Kodak PixPro Camera FZ51", "Kodak", 3595, 3, 11));
            retVal.Add(new Product(id + 10, "Samsung Camera ES95", "Samsung", 3595, 3, 11));
            retVal.Add(new Product(id + 11, "Panasonic Lumix LX2 Camera", "Panasonic", 7500, 3, 11));

            retVal.Add(new Product(id + 11, "Camera Flash, Speedlight Montana C600", "Montana", 2460, 3, 12));

  

            //Others
            id =  GetNExtId(retVal);
            retVal.Add(new Product() { ID = id, Name = "Hitachi Window Type Aircon RA-15MA/ RA-15MB 1.5 HP", Manufacturer = "Hitachi", Cost = (decimal)19495.00, TypeID = 4 });
            retVal.Add(new Product(id + 1, "Samsung LED Prices Smart TV HD 32 Inches UA-32EH4500", "Samsung", 25900, 4, 0));
            retVal.Add(new Product(id + 2, "Samsung Led Tv 32f4100", "Samsung", 17795, 4, 0));
            retVal.Add(new Product(id + 3, "Toshiba 40 Inch FullHD LED TV 40PU200", "Toshiba", 22500, 4, 0));
            retVal.Add(new Product(id + 4, "Toshiba 55 Inch L6200 FullHD 1080p 3D Smart LED TV WIFI", "Toshiba", 22500, 4, 0));
            retVal.Add(new Product(id + 5, "Toshiba 32 Inch Full Hd Led Tv 32ps200", "Toshiba", 14999, 4, 0));
            retVal.Add(new Product(id + 6, "Apple iPod touch 5th Get", "Apple", 11450, 4, 0));
            retVal.Add(new Product(id + 7, "Ipod Nano 4GB", "Apple", 1980, 4, 0));
            retVal.Add(new Product(id + 8, "iPod touch 4th gen 32gb", "Apple", 5999, 4, 0));
            return retVal;
        }


        public int GetNExtId(List<Product> products)
        {
            int retVal = 0;

            if(products != null && products.LongCount() > 0) retVal = products.Max(p => p.ID);

            return retVal + 1;



        }
    }
}