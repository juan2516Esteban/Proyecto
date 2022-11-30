using System;

namespace Proyecto_Final.Model
{
    public class MenuLateralModel
    {
        public MenuLateralModel()
        {
            TargetType = typeof(MenuLateralModel);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icono { get; set; }

        public Type TargetType { get; set; }
    }
}
