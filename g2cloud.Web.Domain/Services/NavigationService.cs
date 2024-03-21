using g2cloud.Web.Domain.DTOs;
using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Domain.Services
{
    public class NavigationService
    {
        private readonly GestFactContext _context;

        public NavigationService(GestFactContext context)
        {
            _context = context;
        }

        public async Task<NavigationDTO> GetNavigationMenu(string site)
        {
            NavigationDTO navigation = new NavigationDTO();
            
            var mItems = await new GestFactDAO<WPAGE>().GetListAsync(_context, x => x.WSITE.WSI_URL == site && x.WPA_EST == "ACTIVO" && x.WPA_TOPVER == "SI", x => x.WSITE);

            if (mItems != null && mItems.Count() > 0) 
            {
                foreach (var mItem in mItems.OrderBy(x => x.WPA_TOPORD))
                {
                    LinkDTO item = new LinkDTO
                    {
                        Text = mItem.WPA_NOM,
                        //Url = mItem.WSITE.WSI_URL + "/" + mItem.WPA_RUT,
                        Url = "/" + mItem.WPA_RUT,
                        Order = mItem.WPA_TOPORD
                    };

                    navigation.Items.Add(item);
                }
            }

            return navigation;
        }
    }
}