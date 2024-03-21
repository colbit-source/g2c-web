using g2cloud.Web.Domain.DTOs;
using g2cloud.Web.Infrastructure.GestFact.DAL;

namespace g2cloud.Web.Domain.Services
{
    public class ContentService
    {
        private readonly GestFactContext _context;

        public ContentService(GestFactContext context)
        {
            _context = context;
        }

        public async Task<ContentDTO> GetContent(string path)
        {
            ContentDTO response = new();

            try
            {
                var content = await new GestFactDAO<WPAGE>().GetAsync(_context, x => x.WPA_RUT == path);

                if (content != null)
                {
                    response.Title = content.WPA_NOM;
                    response.Content = content.WPA_CON;
                }
            }
            catch (Exception ex) { }

            return response;
        }
    }
}
