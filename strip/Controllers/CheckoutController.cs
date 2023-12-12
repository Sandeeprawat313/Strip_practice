
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;


// namespace strip.Controllers;

// public class CheckoutController : ControllerBase
// {

//     private readonly ILogger<CheckoutController> _logger;

//     public CheckoutController(ILogger<CheckoutController> logger)
//     {
//         _logger = logger;
//     }

//     // [HttpGet]
//     // public List<ProductEntity> GetList()
//     // {
//     //     List<ProductEntity> productList = new List<ProductEntity>();
//     //     productList = new List<ProductEntity>
//     //     {
//     //         new ProductEntity{Product = "Tommy Hilfigure",Rate=1500,Quantity=2,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-full-sleeve-embroidered-men-sweatshirt%2Fp%2Fitmddeae70ba2495&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAD"},
//     //         new ProductEntity{Product = "Hilfigure",Rate=15000,Quantity=20,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ajio.com%2Ftommy-hilfiger-brand-print-round-neck-t-shirt%2Fp%2F469441369_grey&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAW"},
//     //         new ProductEntity{Product = "Tommy Hil",Rate=100,Quantity=50,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-solid-men-polo-neck-white-t-shirt%2Fp%2Fitmbe18440fffcc5%3Fpid%3DTSHGG4YAURX6FNZG%26lid%3DLSTTSHGG4YAURX6FNZGB9HQU3%26marketplace%3DFLIPKART%26cmpid%3Dcontent_t-shirt_8965229628_gmc&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABA9"},
//     //         new ProductEntity{Product = "Tommy figure",Rate=15,Quantity=102,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Ftommyhilfiger%2F&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABBO"},
//     //     };
//     //     return productList;
//     // }


//     // public IActionResult Index()
//     // {
//     //     List<ProductEntity> productList = new List<ProductEntity>();
//     //     productList = new List<ProductEntity>
//     //     {
//     //         new ProductEntity{Product = "Tommy Hilfigure",Rate=1500,Quantity=2,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-full-sleeve-embroidered-men-sweatshirt%2Fp%2Fitmddeae70ba2495&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAD"},
//     //         new ProductEntity{Product = "Hilfigure",Rate=15000,Quantity=20,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ajio.com%2Ftommy-hilfiger-brand-print-round-neck-t-shirt%2Fp%2F469441369_grey&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAW"},
//     //         new ProductEntity{Product = "Tommy Hil",Rate=100,Quantity=50,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-solid-men-polo-neck-white-t-shirt%2Fp%2Fitmbe18440fffcc5%3Fpid%3DTSHGG4YAURX6FNZG%26lid%3DLSTTSHGG4YAURX6FNZGB9HQU3%26marketplace%3DFLIPKART%26cmpid%3Dcontent_t-shirt_8965229628_gmc&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABA9"},
//     //         new ProductEntity{Product = "Tommy figure",Rate=15,Quantity=102,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Ftommyhilfiger%2F&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABBO"},
//     //     };
//     //     return View(productList);
//     // }

//     public IActionResult Index()
//     {
//         List<ProductEntity> productList = new List<ProductEntity>();
//         productList = new List<ProductEntity>
//         {
//             new ProductEntity{Product = "Tommy Hilfigure",Rate=1500,Quantity=2,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-full-sleeve-embroidered-men-sweatshirt%2Fp%2Fitmddeae70ba2495&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAD"},
//             new ProductEntity{Product = "Hilfigure",Rate=15000,Quantity=20,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ajio.com%2Ftommy-hilfiger-brand-print-round-neck-t-shirt%2Fp%2F469441369_grey&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAW"},
//             new ProductEntity{Product = "Tommy Hil",Rate=100,Quantity=50,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-solid-men-polo-neck-white-t-shirt%2Fp%2Fitmbe18440fffcc5%3Fpid%3DTSHGG4YAURX6FNZG%26lid%3DLSTTSHGG4YAURX6FNZGB9HQU3%26marketplace%3DFLIPKART%26cmpid%3Dcontent_t-shirt_8965229628_gmc&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABA9"},
//             new ProductEntity{Product = "Tommy figure",Rate=15,Quantity=102,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Ftommyhilfiger%2F&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABBO"},
//         };


//         return View(productList);
//     }


// }


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using strip.Model;

namespace strip.Controllers
{
    [Route("customroute")]
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;

        public CheckoutController(ILogger<CheckoutController> logger)
        {
            _logger = logger;
        }

        [Route("index")]
        public IActionResult Index()
        {
            List<ProductEntity> productList = new List<ProductEntity>
            {
                new ProductEntity{Product = "Tommy Hilfigure",Rate=1500,Quantity=2,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-full-sleeve-embroidered-men-sweatshirt%2Fp%2Fitmddeae70ba2495&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAD"},
                new ProductEntity{Product = "Hilfigure",Rate=15000,Quantity=20,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ajio.com%2Ftommy-hilfiger-brand-print-round-neck-t-shirt%2Fp%2F469441369_grey&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABAW"},
                new ProductEntity{Product = "Tommy Hil",Rate=100,Quantity=50,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.flipkart.com%2Ftommy-hilfiger-solid-men-polo-neck-white-t-shirt%2Fp%2Fitmbe18440fffcc5%3Fpid%3DTSHGG4YAURX6FNZG%26lid%3DLSTTSHGG4YAURX6FNZGB9HQU3%26marketplace%3DFLIPKART%26cmpid%3Dcontent_t-shirt_8965229628_gmc&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABA9"},
                new ProductEntity{Product = "Tommy figure",Rate=15,Quantity=102,ImagePath="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Ftommyhilfiger%2F&psig=AOvVaw3TP8eIBgfZqba58ZgHQBGq&ust=1702473128466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCOD2y-L8iYMDFQAAAAAdAAAAABBO"},
            };

            return View(productList);
        }
    }
}
