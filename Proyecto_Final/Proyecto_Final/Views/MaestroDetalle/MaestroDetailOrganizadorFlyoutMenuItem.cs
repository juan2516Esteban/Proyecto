using System;

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