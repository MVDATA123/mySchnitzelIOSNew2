using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCloud.Shared.Dto.Domain
{
    public class NotificationDto
    {
        public Guid Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime NotifyDateTime { get; set; }
        public string Message { get; set; }

        public virtual StoreDto Store { get; set; }
        public Guid StoreId { get; set; }
    }
}
