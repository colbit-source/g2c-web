using g2cloud.Web.Infrastructure.GestFact.DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Domain.DTOs
{
    /* Para los menus principales */
    public enum MenuType { Navigation, Footer, Private }

    public class LinkDTO
    {
        public string Text  { get; set; }
        public string Url   { get; set; }
        public int    Order { get; set; } = 0;
    }

    public class NavigationDTO
    {
        #region Attributes

        public List<LinkDTO> Items { get; set; } = new List<LinkDTO>();

        #endregion


        ///* Constructor parametrizado */
        //public Menu(string page, MenuType type, bool isUserLoggedIn)
        //{
        //    Items = new List<Link>();

        //    try
        //    {
        //        /* Para menú de navegación */
        //        if (type == MenuType.Navigation)
        //        {
        //            var mItems = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TOPVER == "SI", x => x.WSITE);

        //            if (mItems != null && mItems.Count() > 0)
        //            {
        //                foreach (var mItem in mItems.OrderBy(x => x.WPA_TOPORD))
        //                {
        //                    Link item = new Link
        //                    {
        //                        Text = mItem.WPA_NOM,
        //                        //Url = mItem.WSITE.WSI_URL + "/" + mItem.WPA_RUT,
        //                        Url = "/" + mItem.WPA_RUT,
        //                        CssClass = "",
        //                        Active = page == mItem.WPA_RUT,
        //                        Order = mItem.WPA_TOPORD
        //                    };

        //                    Items.Add(item);
        //                }

        //                if (isUserLoggedIn)
        //                {
        //                    Link itemHome = new Link
        //                    {
        //                        Text = "Área Clientes",
        //                        Url = "/area-de-clientes",
        //                        CssClass = "",
        //                        Active = false,
        //                        Order = 100
        //                    };

        //                    Items.Add(itemHome);
        //                }
        //            }
        //        }
        //        else if (type == MenuType.Footer)
        //        {
        //            var mItems = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_BOTVER == "SI", x => x.WSITE);

        //            if (mItems != null && mItems.Count() > 0)
        //            {
        //                foreach (var mItem in mItems)
        //                {
        //                    Link item = new Link
        //                    {
        //                        Text = mItem.WPA_NOM,
        //                        //Url = mItem.WSITE.WSI_URL + "/" + mItem.WPA_RUT,
        //                        Url = "/" + mItem.WPA_RUT,
        //                        CssClass = "",
        //                        Active = page == mItem.WPA_RUT,
        //                        Order = mItem.WPA_BOTORD
        //                    };

        //                    Items.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    catch { }
        //}

        ///* Constructor para el menu de area privada */
        //public Menu(string route, string erpUrl, string token)
        //{
        //    Items = new List<Link>();

        //    Link itemHome = new Link
        //    {
        //        Text = "Área de Clientes",
        //        Url = "/area-de-clientes",
        //        CssClass = "",
        //        Active = route == "area-de-clientes",
        //        Order = 1,
        //        Target = "_self"
        //    };

        //    Items.Add(itemHome);

        //    Link itemManual = new Link
        //    {
        //        Text = "Manual",
        //        Url = "/manual",
        //        CssClass = "",
        //        Active = route == "manual",
        //        Order = 2,
        //        Target = "_self"
        //    };

        //    Items.Add(itemManual);

        //    Link itemIview = new Link
        //    {
        //        Text = "iView",
        //        Url = "/iview",
        //        CssClass = "",
        //        Active = route == "iview",
        //        Order = 3,
        //        Target = "_self"
        //    };

        //    Items.Add(itemIview);

        //    Link itemErp = new Link
        //    {
        //        Text = "ERP",
        //        Url = erpUrl,
        //        CssClass = "erp-link",
        //        Active = false,
        //        Order = 4,
        //        Target = "_blank"
        //    };

        //    Items.Add(itemErp);

        //    Link itemPizarra = new Link
        //    {
        //        Text = "Pizarra de Cargas",
        //        Url = "https://web.gestfrut.es/origen/pizarraCarga/" + token,
        //        CssClass = "",
        //        Active = false,
        //        Order = 5,
        //        Target = "_blank"
        //    };

        //    Items.Add(itemPizarra);

        //    Link itemPizarraDesc = new Link
        //    {
        //        Text = "Pizarra de Descargas",
        //        Url = "https://web.gestfrut.es/destino/pizarraExpedicion/" + token,
        //        CssClass = "",
        //        Active = false,
        //        Order = 6,
        //        Target = "_blank"
        //    };

        //    Items.Add(itemPizarraDesc);
        //}
    }
}