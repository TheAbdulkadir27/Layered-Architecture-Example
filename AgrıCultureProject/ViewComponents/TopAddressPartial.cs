using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.ViewComponents
{
    public class TopAddressPartial:ViewComponent
    {
        private readonly AddressServices addressServices;

        public TopAddressPartial(AddressServices addressServices) =>this.addressServices = addressServices;
        public IViewComponentResult Invoke()
        {
            return View(addressServices.GetList());
        }
    }
}
