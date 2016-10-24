using Microsoft.Azure.Mobile.Server;

namespace CatchUpIAB330_2Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}