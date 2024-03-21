using g2cloud.Web.Infrastructure.GestFact.DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g2cloud.Web.Application.WebUI.Models
{
    /* Para los menus principales */
    public enum MenuType { Navigation, Footer, Private }

    public class Link
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; }
        public bool Active { get; set; } = false;
        public int Order { get; set; } = 0;
        public string Target { get; set; }
    }

    public class Menu
    {
        #region Attributes

        public List<Link> Items { get; set; } = new List<Link>();

        #endregion

        //public Menu() 
        //{
        //    Link itemHome = new Link
        //    {
        //        Text = "Home",
        //        Url = "/",
        //        CssClass = "",
        //        Active = false,
        //        Order = 1
        //    };

        //    Items.Add(itemHome);

        //    Link itemAbout = new Link
        //    {
        //        Text = "About",
        //        Url = "/about",
        //        CssClass = "",
        //        Active = false,
        //        Order = 2
        //    };

        //    Items.Add(itemAbout);
        //}

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

    //public class Node : Link
    //{
    //    public List<Link> Items { get; set; }
    //}

    //public class NodeMenu
    //{
    //    #region Attributes

    //    public List<Node> Items { get; set; }

    //    #endregion

    //    public NodeMenu()
    //    {
    //        Items = new List<Node>();

    //        /* Por ahora este menú será solo para la página de manual, no preveemos que se use para nada más */
    //        try
    //        {
    //            var nodes = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TIP == "NODO", x => x.WSITE);

    //            Node menuHome = new Node
    //            {
    //                Text = "Búsqueda",
    //                Url = "/manual",
    //                CssClass = "active collapsible",
    //                Active = false,
    //                Order = 0,
    //                Items = new List<Link>()
    //            };

    //            Items.Add(menuHome);

    //            if (nodes != null && nodes.Count() > 0)
    //            {
    //                foreach (var node in nodes.OrderBy(x => x.WPA_TOPORD))
    //                {
    //                    Node item = new Node
    //                    {
    //                        Text = node.WPA_NOM,
    //                        Url = "",
    //                        CssClass = "collapsible",
    //                        Active = false,
    //                        Order = node.WPA_TOPORD,
    //                        Items = new List<Link>()
    //                    };

    //                    var pages = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WPA_EST == "ACTIVO" && (x.WPA_TIP == "MANUAL" || x.WPA_TIP == "FAQ") && x.WPA_NOD == node.COD_WPA);

    //                    foreach (var page in pages.OrderBy(x => x.WPA_TOPORD))
    //                    {
    //                        Link link = new Link
    //                        {
    //                            Text = page.WPA_NOM,
    //                            Url = "/" + page.WPA_RUT,
    //                            CssClass = "",
    //                            Active = false,
    //                            Order = page.WPA_TOPORD
    //                        };

    //                        item.Items.Add(link);
    //                    }

    //                    Items.Add(item);
    //                }
    //            }
    //        }
    //        catch { }
    //    }

    //    /* Constructor parametrizado */
    //    public NodeMenu(string nodeRoute, string pageRoute)
    //    {
    //        Items = new List<Node>();

    //        /* Por ahora este menú será solo para la página de manual, no preveemos que se use para nada más */
    //        try
    //        {
    //            var nodes = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TIP == "NODO", x => x.WSITE);

    //            Node menuHome = new Node
    //            {
    //                Text = "Búsqueda",
    //                Url = "/manual",
    //                CssClass = "",
    //                Active = false,
    //                Order = 0,
    //                Items = new List<Link>()
    //            };

    //            Items.Add(menuHome);

    //            if (nodes != null && nodes.Count() > 0)
    //            {
    //                foreach (var node in nodes.OrderBy(x => x.WPA_TOPORD))
    //                {
    //                    string nodeName = node.WPA_RUT.Split('/').Length > 1 ? node.WPA_RUT.Split('/')[1] : "";

    //                    Node item = new Node
    //                    {
    //                        Text = node.WPA_NOM,
    //                        Url = "",
    //                        CssClass = nodeName == nodeRoute ? "active" : "collapsible",
    //                        Active = false,
    //                        Order = node.WPA_TOPORD,
    //                        Items = new List<Link>()
    //                    };

    //                    var pages = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WPA_EST == "ACTIVO" && (x.WPA_TIP == "MANUAL" || x.WPA_TIP == "FAQ") && x.WPA_NOD == node.COD_WPA);

    //                    foreach (var page in pages.OrderBy(x => x.WPA_TOPORD))
    //                    {
    //                        string pageName = page.WPA_RUT.Split('/').Length > 2 ? page.WPA_RUT.Split('/')[2] : "";

    //                        Link link = new Link
    //                        {
    //                            Text = page.WPA_NOM,
    //                            Url = "/" + page.WPA_RUT,
    //                            CssClass = nodeName == nodeRoute && pageRoute == pageName ? "selected" : "",
    //                            Active = false,
    //                            Order = page.WPA_TOPORD
    //                        };

    //                        item.Items.Add(link);
    //                    }

    //                    Items.Add(item);
    //                }
    //            }
    //        }
    //        catch { }
    //    }
    //}

    //public class FaqMenu
    //{
    //    #region Attributes

    //    public List<Node> Items { get; set; }

    //    #endregion

    //    public FaqMenu()
    //    {
    //        Items = new List<Node>();

    //        try
    //        {
    //            var nodes = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TIP == "NODO", x => x.WSITE);

    //            Node menuHome = new Node
    //            {
    //                Text = "Búsqueda",
    //                Url = "/faq",
    //                CssClass = "active collapsible",
    //                Active = false,
    //                Order = 0,
    //                Items = new List<Link>()
    //            };

    //            Items.Add(menuHome);

    //            if (nodes != null && nodes.Count() > 0)
    //            {
    //                foreach (var node in nodes.OrderBy(x => x.WPA_TOPORD))
    //                {
    //                    Node item = new Node
    //                    {
    //                        Text = node.WPA_NOM,
    //                        CssClass = "collapsible",
    //                        Active = false,
    //                        Order = node.WPA_TOPORD,
    //                        Items = new List<Link>()
    //                    };

    //                    var page = new GestFactDAO<WPAGE>().Get(Constants.CONNECTION_STRING, x => x.WPA_EST == "ACTIVO" && x.WPA_TIP == "FAQ" && x.WPA_NOD == node.COD_WPA);

    //                    if (page != null)
    //                    {
    //                        item.Url = page.WPA_RUT.Replace("manual", "faq");
    //                        Items.Add(item);
    //                    }
    //                }
    //            }
    //        }
    //        catch { }
    //    }

    //    public FaqMenu(string nodeRoute)
    //    {
    //        Items = new List<Node>();

    //        /* Por ahora este menú será solo para la página de manual, no preveemos que se use para nada más */
    //        try
    //        {
    //            var nodes = new GestFactDAO<WPAGE>().GetList(Constants.CONNECTION_STRING, x => x.WSITE.WSI_URL == Constants.SITE && x.WPA_EST == "ACTIVO" && x.WPA_TIP == "NODO", x => x.WSITE);

    //            Node menuHome = new Node
    //            {
    //                Text = "Búsqueda",
    //                Url = "/faq",
    //                CssClass = "",
    //                Active = false,
    //                Order = 0,
    //                Items = new List<Link>()
    //            };

    //            Items.Add(menuHome);

    //            if (nodes != null && nodes.Count() > 0)
    //            {
    //                foreach (var node in nodes.OrderBy(x => x.WPA_TOPORD))
    //                {
    //                    string nodeName = node.WPA_RUT.Split('/').Length > 1 ? node.WPA_RUT.Split('/')[1] : "";

    //                    Node item = new Node
    //                    {
    //                        Text = node.WPA_NOM,
    //                        Url = "",
    //                        CssClass = nodeName == nodeRoute ? "active" : "collapsible",
    //                        Active = false,
    //                        Order = node.WPA_TOPORD,
    //                        Items = new List<Link>()
    //                    };

    //                    var page = new GestFactDAO<WPAGE>().Get(Constants.CONNECTION_STRING, x => x.WPA_EST == "ACTIVO" && x.WPA_TIP == "FAQ" && x.WPA_NOD == node.COD_WPA);

    //                    if (page != null)
    //                    {
    //                        item.Url = "/" + page.WPA_RUT.Replace("manual", "faq");
    //                        Items.Add(item);
    //                    }
    //                }
    //            }
    //        }
    //        catch { }
    //    }
    //}
}
