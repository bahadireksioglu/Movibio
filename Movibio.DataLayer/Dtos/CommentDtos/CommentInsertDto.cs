using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Dtos.CommentDtos
{
    public class CommentInsertDto
    {
        public int MovieId { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public string ModifiedByUserName { get; set; }
        public string CreatedByUserName { get; set; }
    }
}
