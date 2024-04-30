using CQRSDesignPattern.CQRSPATTERN.Commands;
using CQRSDesignPattern.CQRSPATTERN.Handlers;
using CQRSDesignPattern.CQRSPATTERN.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;


        public HomeController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler,
                              RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }



        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetProduct(int Id)
        {
            var values = _getProductByIdQueryHandler.Handle(new  GetProductByIdQuery(Id));
            return View(values);
        }
        [HttpGet]
        public IActionResult DeleteProduct(int Id)
        {
         _removeProductCommandHandler.Handle(new RemoveProductCommand(Id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int Id)
        {
            _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(Id));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
