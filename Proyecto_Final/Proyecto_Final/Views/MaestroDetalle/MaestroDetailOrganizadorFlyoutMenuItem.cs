using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Views.MaestroDetalle
{
    public class MaestroDetailOrganizadorFlyoutMenuItem
    {
        public MaestroDetailOrganizadorFlyoutMenuItem()
        {
            TargetType = typeof(MaestroDetailOrganizadorFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}