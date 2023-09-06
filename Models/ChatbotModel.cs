using System.ComponentModel.DataAnnotations;
using UmbracoProject1.Models;
namespace UmbracoProject1.Models
{
    public class ChatbotModel
    {
        public ICollection<PYRModel> Chats { get; set; }
    }
}
