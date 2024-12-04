using Ilyasi_Garments.Models;
using static System.Net.Mime.MediaTypeNames;
using System.IO.Pipelines;
using System.Drawing;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System.Collections;
using System.Diagnostics.Metrics;
using System.IO;
using System.Reflection.Metadata;
using System.ComponentModel;
using System.Text;

namespace Ilyasi_Garments.Models
{
    public class ViewModelService
    {

        public ViewModel ViewModel { get; private set; }

        public ViewModelService()
        {
            // Initialize ViewModel with some sample data
            ViewModel = new ViewModel
            {
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = "P_001",
                        Name = "3 Piece Suit",
                        Type = "UNISTITCHED",
                        Price = 3473,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product1.jpg",
                        Description = "3-Piece A-Line Shirt with Trousers & Dupatta\r\nExude elegance in our grey textured Khaddar. A-line shirt, dupatta and light khaddar pajama.\r\nDetails:\r\nDyed Front and Back with border Full Sleeves and khaddar Dupatta",
                        Color = "Grey",
                        FabricMaterial ="KHADDAR"
                    },
                    new Product
                    {
                        Id = "P_003",
                        Name = "2 Piece Suit",
                        Type ="UNSTITCHED",
                        Price = 3340,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product3.jpg",
                        Description = "2-Piece A-Line Shirt & Dupatta\r\nExude elegance in our off white, sequins, lace and tilla embroidered blended textured khaddar A-line shirt and dupatta. \r\nDetails:\r\nDyed Front with Sequins & Tilla Embroidery, Dyed Back with Lace Finish, Full Sleeves, Keyhole Neckline",
                        Color = "OFF WHITE",
                        FabricMaterial = "KHADDAR"
                    },
                    new Product
                    {
                        Id = "P_004",
                        Name = "3 Piece Suit",
                        Type ="UNSTITCHED",
                        Price = 5673,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product4.webp",
                        Description = "3-Piece A-Line Shirt with Trousers & Dupatta\r\nExude elegance in our sea blue, sequins, lace and tilla embroidered blended textured karandi A-line shirt, dupatta and viscose raw silk chooridar pajama.\r\n\r\nDetails:\r\nDyed Front with Sequins & Tilla Embroidery, Dyed Back with Lace Finish, Full Sleeves, Keyhole Neckline",
                        Color = "SEA GREEN",
                         FabricMaterial = "KARANDI"
                    },
                    new Product
                    {
                        Id = "P_005",
                        Name = "3 Piece Suit",
                        Type ="UNSTITCHED",
                        Price = 6673,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product5.webp",
                        Description = "3-Piece A-Line Shirt with Trousers & Dupatta\r\nExude elegance in our blue, sequins, lace and tilla embroidered blended textured lawn. A-line shirt, dupatta and viscose raw silk pajama.\r\nDetails:\r\nDyed Front with Sequins & Tilla Embroidery, Dyed Back with Lace Finish, Full Sleeves and Chiffon Dupatta",
                        Color = "BLUE",
                        FabricMaterial = "LAWN"
                    },
                    new Product
                    {
                        Id = "P_006",
                        Name = "2 Piece Suit",
                        Type ="MAN",
                        Price = 6673,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/men1.webp",
                        Description ="Kurta Shalwar\r\nLeave a lasting impression this season in our coffee, wash & wear straight kurta and shalwar with embroidery.\r\n\r\nDetails:\r\nDyed Embroidered Front, Dyed Plain Back, Full Sleeves with Cuff, Band Neckline\r\nColour: Coffee",
                        Color = "COFFEE",
                        FabricMaterial = "LAWN"
                    },
                    new Product
                    {
                        Id = "P_007",
                        Name = "2 Piece Suit",
                        Type ="MAN",
                        Price = 3673,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/men2.webp",
                        Description ="Kurta Shalwar\r\nElevate your everyday style with our sea green, wash & wear straight kurta and shalwar with band and cuff detailing.\r\n\r\nDetails:\r\nDyed Plain Front, Dyed Plain Back, Full Sleeves with Cuff, Band Neckline",
                        Color = "LIGHT GREEN",
                        FabricMaterial = "WASH AND WEAR"
                    },
                    new Product
                    {
                        Id = "P_008",
                        Name = "EMBROIDERED KURTA",
                        Type ="MAN",
                        Price = 3673,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/men3.webp",
                        Description ="Straight Kurta\r\nElevate your festive style statement in our red, printed cotton kurta with embroidery.\r\n\r\nDetails:\r\nDyed Embroidered Front, Dyed Plain Back, Full Sleeves, Band Neckline",
                        Color = "RED",
                        FabricMaterial = "COTTON"
                    },
                    new Product
                    {
                        Id = "P_0010",
                        Name = "Black mini bag",
                        Type ="BEAUTY_AND_ACCESSORIES",
                        Price = 3473,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/wallet1.webp",
                        Description ="Spruce up your style with our black mini bag, featuring a top handle and crossbody strap with a metal lock closure.",
                        Color = "BLACK",
                        FabricMaterial = "NOTHING"
                    },
                    new Product
                    {
                        Id = "P_0011",
                        Name = "Beige Mini Bag",
                        Type ="BEAUTY_AND_ACCESSORIES",
                        Price = 3473,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/wallet2.webp",
                        Description ="Our spacious yet compact beige mini bag with a magnet button closure is perfect for the transitioning season.",
                        Color = "BEIGE",
                        FabricMaterial = "NOTHING"
                    },
                    new Product
                    {
                        Id = "P_0012",
                        Name = "Embroidered Cotton Shirt",
                        Type ="READY_TO_WEAR",
                        Price = 3473,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product6.webp",
                        Description ="A-Line Shirt\r\nLook effortlessly chic in our festive off-white A-line cotton jacquard shirt dyed with sequins and embroidery and featuring a round neckline.\r\n\r\nDetails:\r\nDyed Front with Sequins Embroidery, Dyed Back, Full Sleeves, Round Neckline",
                        Color = "OFF WHITE",
                        FabricMaterial = "COTTON"
                    },
                    new Product
                    {
                        Id = "P_0013",
                        Name = "3 Piece Suit",
                        Type ="READY_TO_WEAR",
                        Price = 3473,
                        Quantity = 10,
                        ImageUrl = "/UploadedFiles/product8.webp",
                        Description ="3-Piece A-Line Shirt with Trousers & Dupatta\r\nExude elegance in our beig, sequins, lace and tilla embroidered blended textured karandi A-line shirt, dupatta and viscose raw silk pajama.\r\n\r\nDetails:\r\nDyed Front with Sequins & Tilla Embroidery, Dyed Back with Lace Finish, Full Sleeves, Keyhole Neckline",
                        Color = "BEIGE",
                        FabricMaterial = "KARANDI"
                    },
                   

                },
                Categories = new List<Category>
                {
                    new Category { Id = "c_001", Type = "UNSTITCHED" },
                    new Category { Id = "c_002", Type = "READY_TO_WEAR" },
                    new Category { Id = "c_003", Type = "NEW_IN" },
                    new Category { Id = "c_004", Type = "MAN" },
                    new Category { Id ="c_005",Type= "BEAUTY_AND_ACCESSORIES" }

                }
            };
        }

        public List<Product> GetProducts()
        {
            return ViewModel.Products;
        }

        public List<Category> GetCategories()
        {
           return ViewModel.Categories;
        }
        public void AddProduct(Product product)
        {
          ViewModel.Products.Add(product);
        }

        public void AddCategory(Category category)
        {
            ViewModel.Categories.Add(category);
        }
    }
}


